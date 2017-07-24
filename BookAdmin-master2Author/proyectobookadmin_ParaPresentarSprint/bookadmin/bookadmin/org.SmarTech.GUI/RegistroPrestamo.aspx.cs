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
        static BsnClsCustomer bsn_customer = new BsnClsCustomer();
        static EntClsCustomer ent_customer = new EntClsCustomer(); 

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");

            }

        }
 
        protected void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            string search = txtIdCustomer.Text;
            ent_customer = bsn_customer.CustomerSearch(search);

            if (ent_customer.IdentificationCard == null)
            {
                Response.Redirect("RegistroCliente.aspx");
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

                btnUpdateCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnNextBook.Enabled = true;
            }
        }

        protected void showCustomer(EntClsCustomer ent_customer)
        {
            txtIdentificationCard.Text = ent_customer.IdentificationCard;
            txtName.Text = ent_customer.Name;
            txtLastName.Text = ent_customer.Lastname;
            txtPhone.Text = ent_customer.Phone;
            txtCellPhone.Text = ent_customer.Celphone;
            txtAddress.Text = ent_customer.Addres;
            txtEmail.Text = ent_customer.Mail;
        }

        protected void btnNextBook_Click(object sender, EventArgs e)
        {
            Session.Add("customer", ent_customer.IdentificationCard);
            Response.Redirect("BookView.aspx");
        }

    }
}