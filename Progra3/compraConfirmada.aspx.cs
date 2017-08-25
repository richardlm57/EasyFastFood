using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class compraConfirmada : System.Web.UI.Page
{
    //This method performs a redirect to the main page.
    protected void ButtonAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("foodMenu.aspx");
    }
    
}