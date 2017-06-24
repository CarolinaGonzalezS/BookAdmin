using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAdmin.org.SmarTech.entities;
using BookAdmin.org.SmarTech.Controller;
using BookAdmin.org.SmarTech.Bussines;


namespace BookAdmin.org.SmarTech.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {

            BsAdministrador ng_administrador = new BsAdministrador();
            ClsAdministrador cm_administrador = new ClsAdministrador();
            cm_administrador = ng_administrador.Login(textNombreUsuario.Text, textClave.Text);
            Session.Add("admin", cm_administrador.Clave);
            Response.Redirect("Principal.aspx");                  
           
        }
    }
}