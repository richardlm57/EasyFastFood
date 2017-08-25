﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;


public partial class foodMenu : System.Web.UI.Page
{
    //On this page load method we validate if an order already has been created with our session value.
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["order"] == null)
        {
            Session["order"] = new Order(0,0,"","",1,new ArrayList());
        }
        if (Session["login"] == null)
        {
            Session["login"] = false;
        }
        if (Session["idOrder"] == null)
        {
            Session["idOrder"] = 1;
        }
        ProductList p = new ProductList();
        p.createProductList();
        setMenuData();

    }
    //In this method we are going to confirm our buy, first we validate if the user is already logged
    protected void confirmBuy(object sender, EventArgs e)
    {
        var status = Session["login"];
        Boolean validation = Convert.ToBoolean(status);
        if (validation == true)
        {
            Order orderTmp = (Order)Session["order"];
            Response.Redirect("Order.aspx");
        }
        else
        {
            Response.Redirect("Login.aspx");
        }

    }
    /*
     *In this method we set the values of the information that we see in our menu 
     */
    protected void setMenuData()
    {
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
    /*
     * This is the first button that we see on our first option of the menu.
     * We validate if the selection is higher than 0 then we add this to the user order.
     */ 
    protected void AddBtnOpc1(object sender, EventArgs e)
    {
        Order orderTmp = (Order)Session["order"];

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
                orderTmp.addProduct(productOrder);
            }
            else
            {
                LabelAddOpc1.Text = "No hay productos disponibles";
            }
        }
    }
    /*
     * This is the second button that we see on our second option of the menu.
     * We validate if the selection is higher than 0 then we add this to the user order.
     */
    protected void AddBtnOpc2(object sender, EventArgs e)
    {
        Order orderTmp = (Order)Session["order"];

        int qty = Convert.ToInt32(QtyOption2.Value);
        if (qty >= 0)
        {
            Product tmp = (Product)ProductList.products[1];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[1] = tmp;
                orderTmp.addProduct(productOrder);
                LabelAddOpc2.Text = "Anadido";
            }
            else
            {
                LabelAddOpc2.Text = "No hay productos disponibles";
            }
        }
    }
    /*
     * This is the third button that we see on our third option of the menu.
     * We validate if the selection is higher than 0 then we add this to the user order.
     */
    protected void AddBtnOpc3(object sender, EventArgs e)
    {
        Order orderTmp = (Order)Session["order"];

        int qty = Convert.ToInt32(QtyOption3.Value);
        if (qty >= 0)
        {
            Product tmp = (Product)ProductList.products[2];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[2] = tmp;
                orderTmp.addProduct(productOrder);
                LabelAddOpc3.Text = "Anadido";
            }
            else
            {
                LabelAddOpc3.Text = "No hay productos disponibles";
            }

        }
    }
    /*
     * This is the fourth button that we see on our fourth option of the menu.
     * We validate if the selection is higher than 0 then we add this to the user order.
     */
    protected void AddBtnOpc4(object sender, EventArgs e)
    {

        Order orderTmp = (Order)Session["order"];

        int qty = Convert.ToInt32(QtyOption4.Value);
        if (qty >= 0)
        {
            Product tmp = (Product)ProductList.products[3];
            if (tmp.cantidad - qty >= 0)
            {
                tmp.cantidad -= qty;
                Product productOrder = new Product(tmp.id, tmp.descripcion, tmp.precio, tmp.tiempoRealizacion, qty);
                ProductList.products[3] = tmp;
                orderTmp.addProduct(productOrder);
                LabelAddOpc4.Text = "Anadido";
            }
            else
            {
                LabelAddOpc4.Text = "No hay productos disponibles";
            }

        }
    }
}