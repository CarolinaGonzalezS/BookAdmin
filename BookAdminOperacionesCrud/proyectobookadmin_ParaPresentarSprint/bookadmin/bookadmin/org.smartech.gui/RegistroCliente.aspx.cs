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
            obj_customer = bsn_customer.CustomerSearch(textIdentificationCard.Text);
            if (obj_customer.IdentificationCard == null)
            {
                if (cedulavalidation(textIdentificationCard.Text))
                {
                    bsn_customer.RegisterCustomer(textIdentificationCard.Text, textName.Text, textLastName.Text, textphone.Text, textCelphone.Text, textAddres.Text, textMail.Text);
                    clear();
                }
                else
                {
                    errorCiNonV();
                }
            }
            else
            {
                errorExistCus();
            }


        }

        protected void errorExistCus()
        {
            string script = @"<script type='text/javascript'>
                    alert('Ya existe un cliente con esta cedula ingrese otra');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void errorCiNonV()
        {
            string script = @"<script type='text/javascript'>
                    alert('El numero de cedula no es valido');
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

        protected bool cedulavalidation(string ci)
        {
            int isNumeric;
            var total = 0;
            const int lengthCi = 10;
            int[] coefficient = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int provinceNumeric = 24;
            const int thirdNumer = 6;

            if (int.TryParse(ci, out isNumeric) && ci.Length == lengthCi)
            {
                var province = Convert.ToInt32(string.Concat(ci[0], ci[1], string.Empty));
                var digitThird = Convert.ToInt32(ci[2] + string.Empty);
                if ((province > 0 && province <= provinceNumeric) && digitThird < thirdNumer)
                {
                    var checkDigitReceived = Convert.ToInt32(ci[9] + string.Empty);
                    for (var k = 0; k < coefficient.Length; k++)
                    {
                        var value = Convert.ToInt32(coefficient[k] + string.Empty) * Convert.ToInt32(ci[k] + string.Empty);
                        total = value >= 10 ? total + (value - 9) : total + value;
                    }
                    var checkDigitObtained = total >= 10 ? (total % 10) != 0 ? 10 - (total % 10) : (total % 10) : total;
                    return checkDigitObtained == checkDigitReceived;
                }
                return false;
            }
            return false;
        }
    }
}