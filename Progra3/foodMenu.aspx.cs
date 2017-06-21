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

        foreach (Products product in arrayProducts)
        {
            if (product.id == 1)
            {

                lblOpc1.Text = product.descripcion;
            }
            /*if (product.id == 4)
            {

                lblOpc2.Text = product.descripcion;
            }
            */
        }

    }

    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}