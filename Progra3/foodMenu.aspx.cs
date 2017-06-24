using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;


public partial class foodMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var arrayProducts = productList.products;
        productList p = new productList();
        p.getList();
        foreach (Products product in arrayProducts)
        {
            if (product.id == 1)
            {

                lblOpc1.Text = product.descripcion;
                lbltTiemOpc1.Text = "Tiempo estimado";
                lblTiemTotOpc1.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc1.Text = "Precio total";
                lblPriceTot1.Text = product.precio.ToString() + "" + "Colones";
            }


            else if (product.id == 2)
            {

                lblOpc2.Text = product.descripcion;
                lblTiemOcp2.Text = "Tiempo estimado";
                lblTiemTot2.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc2.Text = "Precio total";
                lblPriceTot2.Text = product.precio.ToString() + "" + "Colones";
            }
            else if (product.id == 3)
            {

                lblOpc3.Text = product.descripcion;
                lblTiemOpc3.Text = "Tiempo estimado";
                lblTiemTot3.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc3.Text = "Precio total";
                lblPriceTot3.Text = product.precio.ToString() + "" + "Colones";
            }
            else
            {

                lblOpc4.Text = product.descripcion;
                lblTiemOpc4.Text = "Tiempo estimado";
                lblTiemTot4.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc4.Text = "Precio total";
                lblPriceTot4.Text = product.precio.ToString() + "" + "Colones";
            }
        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("Order.aspx");
    }
}