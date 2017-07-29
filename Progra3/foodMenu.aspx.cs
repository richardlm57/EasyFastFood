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

    protected void addProduct(Product product)
    {

        ArrayList orderTmp = (ArrayList)Session["order"];
        Boolean exists = false;
        foreach (Product productTmp in orderTmp)
        {
            if (productTmp.id == product.id)
            {
                productTmp.cantidad += product.cantidad;
                exists = true;
            }
        }
        if (!(exists))
        {
            orderTmp.Add(product);
        }
        Session["order"] = orderTmp;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["order"] == null)
        {
            Session["order"] = new ArrayList();
        }
        if (Session["login"] == null)
        {
            Session["login"] = false;
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

    protected void confirmBuy(object sender, EventArgs e)
    {
        var status = Session["login"];
        Boolean validation = Convert.ToBoolean(status);
        if (validation == true)
        {
            ArrayList orderTmp = (ArrayList)Session["order"];
            Session["orderObject"] = new Order(0, 0, "Efectivo", "Pendiente", 1, orderTmp);
            Response.Redirect("Order.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }

    protected void addBtnOpc1_Click(object sender, EventArgs e)
    {
        int qty = Convert.ToInt32(QtyOption1.Value);
        if (qty >= 0)
        {
            Product tmp = (Product)ProductList.products[0];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[0] = tmp;
                LabelAddOpc1.Text = "Anadido";
                addProduct(productOrder);
            }
            else
            {
                LabelAddOpc1.Text = "No hay productos disponibles";
            }
        }
    }



    protected void addBtnOpc2_Click(object sender, EventArgs e)
    {
        int qty = Convert.ToInt32(QtyOption2.Value);
        if (qty >= 0)
        {
            Product tmp = (Product)ProductList.products[1];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[1] = tmp;
                addProduct(productOrder);
                LabelAddOpc2.Text = "Anadido";
            }
            else
            {
                LabelAddOpc2.Text = "No hay productos disponibles";
            }
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        ArrayList orderTmp = (ArrayList)Session["order"];

    }

    protected void addBtnOpc3_Click(object sender, EventArgs e)
    {
        int qty = Convert.ToInt32(QtyOption3.Value);
        if (qty >= 0)
        {
            Product tmp = (Product)ProductList.products[2];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[2] = tmp;
                addProduct(productOrder);
                LabelAddOpc3.Text = "Anadido";
            }
            else
            {
                LabelAddOpc3.Text = "No hay productos disponibles";
            }

        }
    }

    protected void addBtnOpc4_Click(object sender, EventArgs e)
    {

        int qty = Convert.ToInt32(QtyOption4.Value);
        if (qty >= 0)
        {
            Product tmp = (Product)ProductList.products[3];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[3] = tmp;
                addProduct(productOrder);
                LabelAddOpc4.Text = "Anadido";
            }
            else
            {
                LabelAddOpc4.Text = "No hay productos disponibles";
            }

        }
    }


    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}