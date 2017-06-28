using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAdmin.org.SmarTech.entities;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.Bussines;


namespace BookAdmin.org.SmarTech.GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            

        }

        
        protected void btnEnter_Click(object sender, EventArgs e)
        {

            BsnClsAdministrator bsn_administrator = new BsnClsAdministrator();
            EntClsAdministrator obj_administrator = new EntClsAdministrator();
            obj_administrator = bsn_administrator.Login(textNameUser.Text, textPassword.Text);
            Session.Add("admin", obj_administrator.PasswordA);
            Response.Redirect("Principal.aspx");                  
           
        }
    }
}