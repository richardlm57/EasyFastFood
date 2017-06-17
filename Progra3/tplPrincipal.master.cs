using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;

public partial class tplPrincipal : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UsersControl.arrayUser = new ArrayList();
        UsersControl.arrayUser.Add(new User("David", "De Souza", "salasbar97@gmail.com","ronaldinhogaucho","123","Rio Do Janeiro"));
    }
}