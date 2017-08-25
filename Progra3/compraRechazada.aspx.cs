using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //This method redirect to order web page
    protected void ButtonAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("Order.aspx");
    }
}