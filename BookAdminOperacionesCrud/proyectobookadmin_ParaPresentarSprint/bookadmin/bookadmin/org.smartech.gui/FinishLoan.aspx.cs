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
    public partial class FinishLoan : System.Web.UI.Page
    {
        private static string code;
        private static int stock;
        private static string nameCustomer;
        private static EntClsBook ent_book = new EntClsBook();
        private static BsnClsBook bsn_book = new BsnClsBook();
        private static CntClsBook cnt_book = new CntClsBook();
        private static EntClsLoan ent_loan = new EntClsLoan();
        private static BsnClsLoan bsn_loan = new BsnClsLoan();
        private static CntClsLoan cnt_loan = new CntClsLoan();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }  

            loadInformation();

            if (!IsPostBack)
            {
                textDateLoan.Text = DateTime.Now.ToString("yyy-MM-dd");
            }
        }

        protected void loadInformation()
        {
            code = Convert.ToString(Session["bookview"]);
            textCodeBook.Text = code;

            nameCustomer = Convert.ToString(Session["idCustomer"]);
            textIdCustomer.Text = nameCustomer;

            ent_loan.StateL = "En Proceso";
            txtStateL.Text = ent_loan.StateL;

            //stock = Convert.ToInt32((Session["stock"]));
            //textCodeLoan.Text = Convert.ToString(stock);

        }

        protected void updateBook()
        {
            stock = Convert.ToInt32(Session["stock"]);
        }

        protected void btnDoLoan_Click(object sender, EventArgs e)
        {
            code = Convert.ToString(Session["bookview"]);
            textCodeBook.Text = code;

            nameCustomer = Convert.ToString(Session["idCustomer"]);
            textIdCustomer.Text = nameCustomer;

            bsn_loan.insertLoan(textDateLoan.Text, textDateLimit.Text, textIdCustomer.Text, textCodeBook.Text, txtStateL.Text);
            updateBook();

            Session.Add("idCustomer", nameCustomer);
            Response.Redirect("frm_PrestamoCliente.aspx");



        }



    }
}