using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code;

public partial class NewAccount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonCrearUsuario_Click(object sender, EventArgs e)
    {
        var arrayUser = UsersControl.arrayUser;
        lblErrorNewAccount.Text = "";
        if (newName.Text == "")
        {
            lblErrorNewAccount.Text = "\nEl nombre es obligatorio";
        }
        else if (newSurname.Text == "")
        {
            lblErrorNewAccount.Text = "\nEl apellido es obligatorio";
        }
        else if (newAddress.Text == "")
        {
            lblErrorNewAccount.Text = "\nLa direccion es obligatoria";
        }
        else if (newUsername.Text == "")
        {
            lblErrorNewAccount.Text = "\nEl nombre de usuario es obligatorio";
        }
        else if (newPassword.Text == "")
        {
            lblErrorNewAccount.Text = "\nLa contraseña es obligatoria";
        }
        else if (confirmPassword.Text == "")
        {
            lblErrorNewAccount.Text = "\nLa confirmación de contraseña es obligatoria";
        }
        else if (newPassword.Text != confirmPassword.Text)
        {
            lblErrorNewAccount.Text = "Las contraseñas deben coincidir";
        }
        else
        {
            Boolean exists = true;
            foreach (User u in arrayUser)
            {
                exists = false;
                if (u.username == newUsername.Text)
                {
                    lblErrorNewAccount.Text = "El nombre de usuario ya existe";
                    exists = true;
                    break;
                }
            }
            if (exists == false)
            {
                UsersControl.arrayUser.Add(new User(newName.Text, newSurname.Text, newUsername.Text, newPassword.Text, "123", newAddress.Text));
                foreach (User u in arrayUser)
                {
                    lblErrorNewAccount.Text += "\n"+u.username+" "+u.password;
                }
                Response.Redirect("Login.aspx");
            }
        }
    }
}