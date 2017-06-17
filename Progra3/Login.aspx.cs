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

        foreach (User u in arrayUser) {
            if (u.username== txtUserName.Text && u.password== txtPassword.Text)
            {
                Response.Redirect("menuComidas.aspx");
            }
        }

        if (txtUserName.Text == "")
        {
            lblerror.Text = "\nUsuario incorrecto";
            txtUserName.BorderColor = System.Drawing.Color.Red;
        }
        if (txtPassword.Text == "")
        {
            lblerror.Text += "\nContraseña incorrecta";
            txtPassword.BorderColor = System.Drawing.Color.Red;
        }
    }
}