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
    public partial class Fine1 : System.Web.UI.Page
    {
        private static EntClsLoan ent_loan = new EntClsLoan();
        private static CntClsLoan cnt_loan = new CntClsLoan();
        private static BsnClsLoan bsn_loan = new BsnClsLoan();
        private static EntClsFine ent_fine = new EntClsFine();
        private static CntClsFine cnt_fine = new CntClsFine();
        private static BsnClsFine bsn_fine = new BsnClsFine();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void showFine(EntClsLoan fineloan)
        {
            txtIdLoan.Text = Convert.ToString(fineloan.Id);
            txtIdentificationCard.Text = fineloan.IdentificationCard;
            txtDateLoan.Text = fineloan.DateLoan; 
        }

        protected void btnSearchLoan_Click(object sender, EventArgs e)
        {
            string search = txtSearchFine.Text;
            EntClsLoan fineloan = bsn_loan.fineLoan(Convert.ToInt32(search));
            showFine(fineloan);

            txtDateFine.Enabled = true;
            txtCostoLibro.Enabled = true;
            btnFillFine.Enabled = true;
        }

        protected void btnDays_Click(object sender, EventArgs e)
        {
            // Resta la Fecha Final ingresada con la Fecha Inicial del prestamo
            DateTime oldTime = Convert.ToDateTime(txtDateLoan.Text);
            DateTime newTime = Convert.ToDateTime(txtDateFine.Text);
            TimeSpan dias = newTime - oldTime;
            txtDays.Text = dias.Days.ToString();
        }

        protected void btnFillFine_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(txtCostoLibro.Text);
            int days = Convert.ToInt32(txtDays.Text);

            txtValueFine.Text = Convert.ToString(0.00);
            double fine = Convert.ToDouble(txtValueFine.Text);
            
            if (days == 30 || days == 31)
            {
                fine = 0;
                txtValueFine.Text = Convert.ToString(fine);
                txtDescFine.Text = "No existe multa";
            }
            else if (days > 31 && days < 60)
            {
                fine = costo * 0.10;
                txtValueFine.Text = Convert.ToString(fine);
                txtDescFine.Text = "Ha exedido 1 mes de prestamo. Multa 10%";
            }
            else if (days > 61 && days < 90)
            {
                fine = costo * 0.20;
                txtValueFine.Text = Convert.ToString(fine);
                txtDescFine.Text = "Ha exedido 2 meses de prestamo. Multa 20%";
            }
            else
            {
                fine = costo;
                txtValueFine.Text = Convert.ToString(fine);
                txtDescFine.Text = "Ha exedido 3 meses de prestamo. Multa 100%";
            }

            btnFinishFine.Enabled = true;
        }

        protected void clear()
        {
            txtSearchFine.Text = null;
            txtIdentificationCard.Text = null;
            txtIdLoan.Text = null;
            txtCostoLibro.Text = null;
            txtDescFine.Text = null;
            txtDateLoan.Text = null;
            txtDateFine.Text = null;
            txtDays.Text = null;
            txtValueFine.Text = null;  
        }

        protected void btnFinishFine_Click(object sender, EventArgs e)
        {
            bsn_fine.insertFine(Convert.ToDouble(txtValueFine.Text), txtDescFine.Text);

            clear();
        }
    }
}