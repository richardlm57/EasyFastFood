using System;
using System.Net.Mail;
using System.Net;
using App_Code;
using System.Collections;
using System.ComponentModel;

public partial class _Default : System.Web.UI.Page
{
    ArrayList userOrder;
    int userBalance;
    protected void Page_Load(object sender, EventArgs e)
    {
        userOrder = (ArrayList)Session["order"];
        var arrayUser = UsersControl.arrayUser;

        foreach (User user in arrayUser)
        {
            if (user.username.Equals(Session["LoggedUser"]))
            {
                userBalance = user.balance;
                user.orders = (ArrayList)Session["order"];
                
            }
        }
        string tableContent = "";
        double totalTmp = 0;
        foreach (Product p in userOrder){
            tableContent += "<tr><td>"+p.descripcion+"</td><td>"+p.tiempoRealizacion+"</td>";
            tableContent += "<td>" + p.precio + "</td><td>" + p.cantidad + "</td><td>" + (p.precio*p.cantidad);
            totalTmp += (p.precio * p.cantidad);
        }
        var tableText = "<table bgcolor=\"af3a11\" id=\"order\"><tr><th>Descripción</th>";
        tableText += "<th>Tiempo</th><th>Precio</th><th>Cantidad</th><th>Total</th>";
        tableText += tableContent + "</table>";
        orderTable.Text = tableText;
        LabelTotal.Text = "Total = " + totalTmp.ToString();
    }

    protected void ButtonEnded_Click(object sender, EventArgs e)
    {
        ArrayList arrayUserOrder = (ArrayList)Session["order"];
        String emailUser = (String)Session["emailUser"];
        String orderDetail= "Su orden fue procesada correctamente" + "\n" + "Comprobante de compra";
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("salasbar97@gmail.com", "davidsalas97"),
            EnableSsl = true
        };

        foreach (Product product in userOrder)
        {
            orderDetail += "\n" + product.descripcion + "\n" + "por un total de: " + product.precio;
        }
        orderDetail += "\nGracias por preferir Easy Fast Food ";
        if (userBalance >=100) {
            client.Send("salasbar97@gmail.com", "salasbar97@gmail.com", "Comprobante de compra", orderDetail);
            Response.Redirect("compraConfirmada.aspx");
        }
        else
        {
            Response.Redirect("compraRechazada.aspx");
        }
    }
    protected void ButtonAtras_Click(object sender, EventArgs e)
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
}