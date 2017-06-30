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
        var status = Session["login"];
        Boolean validation = Convert.ToBoolean(status);
        if (validation == true)
        {
            logged.Attributes.CssStyle.Add("display", "inline-block");
            notlogged.Attributes.CssStyle.Add("display", "none");
        }
        else
        {
            notlogged.Attributes.CssStyle.Add("display", "inline-block");
            logged.Attributes.CssStyle.Add("display", "none");
        }
    }

    protected void ButtonMiniLogin_Click(object sender, EventArgs e)
    {
        var arrayUser = UsersControl.arrayUser;

        txtMiniUserName.BorderColor = System.Drawing.Color.WhiteSmoke;
        txtMiniPassword.BorderColor = System.Drawing.Color.WhiteSmoke;
        lblErrorLogin.Text = "";



        foreach (User u in arrayUser)
        {
            if (u.username == txtMiniUserName.Text && u.password == txtMiniPassword.Text)
            {

                Session["login"] = true;
                Response.Redirect("foodMenu.aspx");

            }
        }

        if (txtMiniUserName.Text == "")
        {
            lblErrorLogin.Text += "\nUsuario inválido";
            txtMiniUserName.BorderColor = System.Drawing.Color.Red;
        }
        if (txtMiniPassword.Text == "")
        {
            lblErrorLogin.Text += "\nContraseña inválida";
            txtMiniPassword.BorderColor = System.Drawing.Color.Red;
        }
        else
        {
            lblErrorLogin.Text += "\nEl usuario o la contraseña son incorrectos";
            txtMiniUserName.BorderColor = System.Drawing.Color.Red;
            txtMiniPassword.BorderColor = System.Drawing.Color.Red;
        }
    }

    protected void ButtonMiniLogout_Click(object sender, EventArgs e)
    {
        Session["login"] = false;
        Response.Redirect(Request.RawUrl);
    }
}
