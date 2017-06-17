using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class menuComidas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button4_Click(object sender, EventArgs e)
    {
        
        var arrayProducts = productList.productArray;
        foreach (Products product in arrayProducts)
        {
            if (product.ID == 0)
            {
                
            }
            Server.Transfer("Order.aspx", true);

        }
    }
}