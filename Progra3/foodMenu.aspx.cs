using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;


public partial class foodMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
        {
            Session["login"] = false;
        }
        Label1.Text = "Alguna otra";
        if (ProductList.products == null)
        {
            Label1.Text = "Primera vez";
        }
        ProductList p = new ProductList();
        p.createProductList();
        foreach (Product product in ProductList.products)
        {
            if (product.id == 1)
            {

                lblOpc1.Text = product.descripcion;
                lbltTiemOpc1.Text = "Tiempo estimado";
                lblTiemTotOpc1.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc1.Text = "Precio total";
                lblPriceTot1.Text = product.precio.ToString() + " Colones";
            }


            else if (product.id == 2)
            {

                lblOpc2.Text = product.descripcion;
                lblTiemOcp2.Text = "Tiempo estimado";
                lblTiemTot2.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc2.Text = "Precio total";
                lblPriceTot2.Text = product.precio.ToString() + " Colones";
            }
            else if (product.id == 3)
            {

                lblOpc3.Text = product.descripcion;
                lblTiemOpc3.Text = "Tiempo estimado";
                lblTiemTot3.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc3.Text = "Precio total";
                lblPriceTot3.Text = product.precio.ToString() + " Colones";
            }
            else
            {

                lblOpc4.Text = product.descripcion;
                lblTiemOpc4.Text = "Tiempo estimado";
                lblTiemTot4.Text = product.tiempoRealizacion.ToString() + "" + "min";
                lblPriceOpc4.Text = "Precio total";
                lblPriceTot4.Text = product.precio.ToString() + " Colones";
            }
        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        var status = Session["login"];
        Boolean validation = Convert.ToBoolean(status);
        if ( validation == true)
        {
            Response.Redirect("Order.aspx");
        }else
        {
            Response.Redirect("Login.aspx");
        }
       
    }

    protected void addBtnOpc1_Click(object sender, EventArgs e)
    {
        int qty = Convert.ToInt32(QtyOption1.Value);
        if (qty >= 0) {
            Product tmp = (Product)ProductList.products[0];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[0] = tmp;
                LabelAddOpc1.Text = "Anadido";
            }
            else {
                LabelAddOpc1.Text = "No hay productos disponibles";
            }
        }
    }
}