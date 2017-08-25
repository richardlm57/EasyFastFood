using System;
using System.Net.Mail;
using System.Net;
using App_Code;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    Order userOrder;
    int userBalance;
    int totalTmp = 0;
    string tableContent = "";
    String orderDetail;
    ArrayList arrayUser = UsersControl.arrayUser;

    protected void Page_Load(object sender, EventArgs e)
    {
        userOrder = (Order)Session["order"];
        getUserBalance();
        createTable();
    }
    protected void getUserBalance()
    {
        foreach (User user in arrayUser)
        {
            if (user.username.Equals(Session["LoggedUser"]))
            {
                userBalance = user.balance;
            }
        }
    }
    protected void createTable()
    {
        foreach (Product p in userOrder.products)
        {
            tableContent += "<tr><td>" + p.descripcion + "</td><td>" + p.tiempoRealizacion + "</td>";
            tableContent += "<td>" + p.precio + "</td><td>" + p.cantidad + "</td><td>" + (p.precio * p.cantidad);
            totalTmp += (p.precio * p.cantidad);
        }
        var tableText = "<table bgcolor=\"af3a11\" id=\"order\"><tr><th>Descripción</th>";
        tableText += "<th>Tiempo</th><th>Precio</th><th>Cantidad</th><th>Total</th>";
        tableText += tableContent + "</table>";
        orderTable.Text = tableText;
        labelTotal.Text = "Total = " + totalTmp.ToString();
        userOrder.total = totalTmp;
        userOrder.status = "Pendiente";
    }
    protected void sendEmail()
    {
        orderDetail= "Su orden fue procesada correctamente" + "\n" + "Comprobante de compra";
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("salasbar97@gmail.com", "davidsalas97"),
            EnableSsl = true
        };
        foreach (Product product in userOrder.products)
        {
            orderDetail += "\n" + product.descripcion + "\n" + "por un total de: " + product.precio;
        }
        orderDetail += "\nGracias por preferir Easy Fast Food ";
        client.Send("salasbar97@gmail.com", "salasbar97@gmail.com", "Comprobante de compra", orderDetail);

    }
    protected void endPay(object sender, EventArgs e)
    {
            if ((cardPay.Checked == true) && (cardNumber.Value == "")){
                LabelCard.Text = "El numero de tarjeta es invalido";
            } 
            else if (((userBalance >=totalTmp)&&(cardPay.Checked == true)) || (cashPay.Checked == true)){
             sendEmail();
                Session["order"] = new ArrayList();
                 foreach (User user in arrayUser)
                 {
                    if (user.username.Equals(Session["LoggedUser"]))
                    {
                        if (cardPay.Checked == true)
                        {
                            user.balance = userBalance - totalTmp;
                            userOrder.status = "Completada";
                            if (cardPay.Checked == true)
                        {
                            userOrder.tipoPago = "Tarjeta";
                        }
                            if (cashPay.Checked == true)
                        {
                            userOrder.tipoPago = "Efectivo";

                        }
                        user.orders.Add(userOrder);
                        }
                    }
                 }
                Session["order"] = null;
                Response.Redirect("compraConfirmada.aspx");
             }
             else if (((userBalance < totalTmp) && (cardPay.Checked == true)))
             {                
                 Response.Redirect("PaymentRejected.aspx");
             }

        }
    protected void backPage(object sender, EventArgs e)
    {
        Response.Redirect("foodMenu.aspx");
    }
    
    protected void compraConfirmada(object sender, EventArgs e)
    {
        Response.Redirect("compraConfirmada.aspx");
    }

    protected void compraRechazada(object sender, EventArgs e)
    {
        Response.Redirect("compraRechazada.aspx");
    }

    protected void cardPayOption(object sender, EventArgs e)
    {
        if (cardPay.Checked == true)
        {

            cardNumber.Attributes.CssStyle.Add("display", "inline-block");
        }
        else
        {
            cardNumber.Attributes.CssStyle.Add("display", "none");
        }
    }

    protected void cashPayOption(object sender, EventArgs e)
    {
        if (cashPay.Checked == true)
        {
            cardNumber.Attributes.CssStyle.Add("display", "none");
            LabelCard.Text = "";

        }
    }
}