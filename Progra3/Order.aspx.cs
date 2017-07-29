using System;
using System.Net.Mail;
using System.Net;
using App_Code;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    ArrayList userOrder;
    int userBalance;
    int totalTmp = 0;
    Boolean payTypeCard =false;
    ArrayList arrayUser = UsersControl.arrayUser;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Enabled = false;


        userOrder = (ArrayList)Session["order"];
        foreach (User user in arrayUser)
        {
            if (user.username.Equals(Session["LoggedUser"]))
            {
                userBalance = user.balance;
                user.orders = (ArrayList)Session["order"];
            }
        }
        string tableContent = "";
        foreach (Product p in userOrder){
            tableContent += "<tr><td>"+p.descripcion+"</td><td>"+p.tiempoRealizacion+"</td>";
            tableContent += "<td>" + p.precio + "</td><td>" + p.cantidad + "</td><td>" + (p.precio*p.cantidad);
            totalTmp += (p.precio * p.cantidad);
        }
        var tableText = "<table bgcolor=\"af3a11\" id=\"order\"><tr><th>Descripción</th>";
        tableText += "<th>Tiempo</th><th>Precio</th><th>Cantidad</th><th>Total</th>";
        tableText += tableContent + "</table>";
        orderTable.Text = tableText;
        labelTotal.Text = "Total = " + totalTmp.ToString();
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
        foreach (User user in arrayUser)
        {
            user.balance = userBalance - totalTmp;
        }


            foreach (Product product in userOrder)
             {
                 orderDetail += "\n" + product.descripcion + "\n" + "por un total de: " + product.precio;
             }
             orderDetail += "\nGracias por preferir Easy Fast Food ";
             if (userBalance >=totalTmp) {
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

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (RadioButton2.Checked == true)
        {
            TextBox1.Enabled = true;
        }
        else
        {
            if (RadioButton2.Checked == false)
            {
                TextBox1.Enabled = false;
            }
        }
    }
}