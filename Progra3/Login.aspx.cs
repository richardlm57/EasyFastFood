using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;

public partial class Login : System.Web.UI.Page
{
    /**
     * 
     * On the page load we validate if a user is already logged
     */ 
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["pageLogin"] = true;
        if (Session["login"]==null)
        {
            Session["login"] = false;
        }
    }

    /*
     * This is the method to be redirected to the webpage in order to create your new account.
     */
    protected void NewAccount(object sender, EventArgs e)
    {
        Response.Redirect("NewAccount.aspx");
    }
    /*
     * This is method is to be logged in the system in order to buy the food
     */ 
    protected void BtnLogin(object sender, EventArgs e)
    {
        var arrayUser = UsersControl.arrayUser;

        txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
        txtPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
        lblErrorLogin.Text = "";
       

      
            foreach (User u in arrayUser) {
                if (u.username == txtUserName.Text && u.password == txtPassword.Text)
                {
                Session["login"] = true;
                Session["LoggedName"] = u.name;
                Session["LoggedUser"] = u.username;
                Session["emailUser"] = u.email;
                Session["pageLogin"] = "";
                Response.Redirect("foodMenu.aspx");
                
                }
            }

            if (txtUserName.Text == "")
            {
                lblErrorLogin.Text += "\nUsuario inválido";
                txtUserName.BorderColor = System.Drawing.Color.Red;
            }
            if (txtPassword.Text == "")
            {
                lblErrorLogin.Text += "\nContraseña inválida";
                txtPassword.BorderColor = System.Drawing.Color.Red;
            }
            else {
                lblErrorLogin.Text += "\nEl usuario o la contraseña son incorrectos";
                txtUserName.BorderColor = System.Drawing.Color.Red;
                txtPassword.BorderColor = System.Drawing.Color.Red;
            }
        }
    /*
     * This button is to go back to the main page.
     */ 
    protected void BtnAtras(object sender, EventArgs e)
    {
        Session["pageLogin"] = "";
        Response.Redirect("foodMenu.aspx");
    }
}