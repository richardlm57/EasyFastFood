﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;

public partial class Login : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["login"]==null)
        {
            Application["login"] = false;
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewAccount.aspx");
    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        var arrayUser = UsersControl.arrayUser;

        txtUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
        txtPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
        lblErrorLogin.Text = "";
       

      
            foreach (User u in arrayUser) {
                if (u.username == txtUserName.Text && u.password == txtPassword.Text)
                {
                
                Application["login"] = true;
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
    
    protected void ButtonAtras_Click(object sender, EventArgs e)
    {
        Response.Redirect("foodMenu.aspx");
    }
}