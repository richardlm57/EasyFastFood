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
    /**
     * this method is really simple because it loads all the requiered methods to see all the information on the UI 
     */ 
    protected void Page_Load(object sender, EventArgs e)
    {
        userOrder = (Order)Session["order"];
        getUserBalance();
        createTable();
    }
    /**
     * This method it is requiered to know the balance of the user, to verify if he is able to perform a buy with card
     */ 
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
    /**
     * This method will show the table that we see on this page, with all the information of the buy
     */ 
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
    /*
     * This method will send an email to the user after the buy has been already validated.
     */ 
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
    /*
     * This method will finish the buy of the user.
     * There are some validations that it should be performed in order to see if the user is able to perform the buy
     */ 
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
    /*
     * This button will redirect to the main page
     */ 
    protected void backPage(object sender, EventArgs e)
    {
        Response.Redirect("foodMenu.aspx");
    }
    /**
     * This method is where the user selects that he will be performing his buy by card payment.
     */ 
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
    /**
    * This method is where the user selects that he will be performing his buy by cash payment.
    */
    protected void cashPayOption(object sender, EventArgs e)
    {
        if (cashPay.Checked == true)
        {
            cardNumber.Attributes.CssStyle.Add("display", "none");
            LabelCard.Text = "";

        }
    }
}