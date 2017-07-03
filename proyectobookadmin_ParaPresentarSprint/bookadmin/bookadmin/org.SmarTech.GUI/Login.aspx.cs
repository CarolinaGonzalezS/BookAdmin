using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text;
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

        public string encryptPassw(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {

            BsnClsAdministrator bsn_administrator = new BsnClsAdministrator();            
            string pass = encryptPassw(textPassword.Text);
            EntClsAdministrator obj_administrator = bsn_administrator.Login(textNameUser.Text, pass);            
            Session.Add("admin", obj_administrator.PasswordA);
            Response.Redirect("Principal.aspx");           
            
        }
    }
}