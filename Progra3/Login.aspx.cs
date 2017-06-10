using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    String userName = "admin";
    String password = "admin";
    protected void Page_Load(object sender, EventArgs e)
    {

    }

        protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Server.Transfer("NewAccount.aspx", true);
    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text == "" && txtPassword.Text == "")
        {
            lblerror.Text = "Ingreso usuario y contrasena incorrecto";
            txtUserName.BorderColor = System.Drawing.Color.Red;
            txtPassword.BorderColor = System.Drawing.Color.Red;
        }
        else if (txtPassword.Text == "")
        {
            lblerror.Text = "Ingreso contrasena incorrecta";
            txtPassword.BorderColor = System.Drawing.Color.Red;
            txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
        }
        else if (txtUserName.Text == "")
        {
            lblerror.Text = "Ingreso usuario incorrecto";
            txtUserName.BorderColor = System.Drawing.Color.Red;
            txtPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
        }
        else if (txtUserName.Text == userName && txtPassword.Text == password)
        {
            lblerror.Text = "usuario correcto";
            txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
            txtPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
        }
        else
        {
            txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
            txtPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
            txtUserName.Text = "";
            txtPassword.Text = "";
            lblerror.Text = "Error al consultar la base de datos";
        }
    }
}