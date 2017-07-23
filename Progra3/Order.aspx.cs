using System;
using System.Net.Mail;
using System.Net;
using App_Code;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    ArrayList userOrder;
    protected void Page_Load(object sender, EventArgs e)
    {
        userOrder = (ArrayList)Session["order"];
        var arrayUser = UsersControl.arrayUser;

        foreach (User user in arrayUser)
        {
            if (user.username.Equals(Session["LoggedUser"]))
            {
                user.orders = (ArrayList)Session["order"];
            }
        }
       // var source = new BindingSource();
       /* DataTable tableTmp = new DataTable("order");
        tableTmp.Columns.Add(new DataColumn("Nombre del producto"));
        tableTmp.Columns.Add(new DataColumn("Cantidad"));
        tableTmp.Columns.Add(new DataColumn("Precio"));
        foreach (Product p in userOrder)
        {
            tableTmp.AcceptChanges();
            DataRow row = tableTmp.NewRow();
            row[0] = p.descripcion;
            row[1] = p.cantidad.ToString();
            row[2] = p.precio.ToString();
            tableTmp.Rows.Add(row);
        }
        GridView1.DataSource = tableTmp;
        */
    }

    protected void ButtonEnded_Click(object sender, EventArgs e)
    {
       // ArrayList userOrder = (ArrayList)Session["order"];
        var arrayUserOrder = (ArrayList)Session["order"];
        String emailUser = (String)Session["emailUser"];
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("salasbar97@gmail.com", "davidsalas97"),
            EnableSsl = true
        };
        foreach (Product product in arrayUserOrder)
        {


            {
                {
                    client.Send("salasbar97@gmail.com", emailUser, "Comprobante de compra", "Su orden fue procesada correctamente" + "\n" + "Comprobante de compra" + " \n " + product.descripcion + "\n" + "\n" + product.tiempoRealizacion + "\n" + "por un total de: " + product.precio + "\n" + "Gracias por preferir Easy Fast Food ");
                    Console.WriteLine("Sent");
                }
            }
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