using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAdmin.org.SmarTech.entities;
using BookAdmin.org.SmarTech.Bussines;


namespace BookAdmin.org.SmarTech.GUI
{
    public partial class RegistroPrestamo1 : System.Web.UI.Page
    {

        private static BsnClsCustomer bsn_customer = new BsnClsCustomer();
        private static EntClsCustomer ent_customer = new EntClsCustomer();     
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            } 
        }

        protected void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            ent_customer = bsn_customer.CustomerSearch(txtIdCustomer.Text);

            if (ent_customer.Cedula == null)
            {

                if (cedulavalidation(txtIdCustomer.Text))
                {
                    Response.Redirect("RegistroCliente.aspx");

                }
                else
                {
                    errorCiNonV();
                }
            }
            else
            {
                txtIdentificationCard.Enabled = true;
                txtName.Enabled = true;
                txtLastName.Enabled = true;
                txtPhone.Enabled = true;
                txtCellPhone.Enabled = true;
                txtAddress.Enabled = true;
                txtEmail.Enabled = true;

                showCustomer(ent_customer);

                btnNextBook.Enabled = true;
                
            }

        }

        protected void showCustomer(EntClsCustomer ent_customer)
        {
            txtIdentificationCard.Text = ent_customer.Cedula;
            txtName.Text = ent_customer.Nombre;
            txtLastName.Text = ent_customer.Apellido;
            txtPhone.Text = ent_customer.Telefono;
            txtCellPhone.Text = ent_customer.Celular;
            txtAddress.Text = ent_customer.Direccion;
            txtEmail.Text = ent_customer.Email;
        }

        protected void btnNextBook_Click(object sender, EventArgs e)
        {
            Session.Add("customer", ent_customer.Cedula);
            Response.Redirect("BookLoan.aspx");
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



        protected void errorCiNonV()
        {
            string script = @"<script type='text/javascript'>
                    alert('El numero de cedula no es valido');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }
    }
}