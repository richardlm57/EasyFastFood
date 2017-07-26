using System;
using System.Net.Mail;
using System.Net;
using App_Code;
using System.Collections;

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
            orderDetail += product.descripcion + "\n" + "\n" + product.tiempoRealizacion + "\n" + "por un total de: " + product.precio + "\n" + "\n";
        }
        orderDetail += "\nGracias por preferir Easy Fast Food ";
           // Convert.ToInt32(Session["totalTmp"];
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

}