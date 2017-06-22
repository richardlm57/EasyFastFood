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
            }


            else if (product.id == 2)
            {

                lblOpc2.Text = product.descripcion;
            }
            else if (product.id == 3)
            {

                lblOpc3.Text = product.descripcion;
            }
            else 
            {

                lblOpc4.Text = product.descripcion;
            }
        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}