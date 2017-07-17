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
    public partial class RegistroCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }            

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            EntClsCustomer obj_customer = new EntClsCustomer();
            BsnClsCustomer bsn_customer = new BsnClsCustomer();
            obj_customer=bsn_customer.CustomerSearch(textIdentificationCard.Text);
            if (obj_customer.IdentificationCard == null)
            {
                bsn_customer.RegisterCustomer(textIdentificationCard.Text, textName.Text, textLastName.Text, textphone.Text, textCelphone.Text, textAddres.Text, textMail.Text);
                clear();
            }
            else 
            {
                errorMessage();
            }
           
            
        }

        protected void errorMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('Ya existe un cliente con esta cedula ingrese otra');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }


        protected void clear()
        {
            textName.Text = "";
            textLastName.Text = "";
            textIdentificationCard.Text = "";
            textAddres.Text = "";
            textphone.Text = "";
            textCelphone.Text = "";
            textMail.Text = "";
        }

        protected void cedulavalidation()
        {
            string IdentificationCard = textIdentificationCard.Text;
            char[] vector = IdentificationCard.ToArray();
            int sumaTotal = 0;
            if (vector.Length == 10)
            {
                for (int i = 0; i < vector.Length-1; i++)
                {
                    int number = Convert.ToInt32(vector[i].ToString());
                    if((i+1)%2==1)
                    {
                        number = Convert.ToInt32(vector[i].ToString())*2;
                        if (number<9)
                        {
                            number = number - 9;
                        }
                    }
                    sumaTotal +=  number;
                }
                sumaTotal=10-(sumaTotal % 10);
   
            }
            else
            {
                string script = @"<script type='text/javascript'>
                    alert('Esta no es una cedula');
                    </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);  
            }
        }

        protected void btnLoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistroPrestamo.aspx");
        }
    }
}