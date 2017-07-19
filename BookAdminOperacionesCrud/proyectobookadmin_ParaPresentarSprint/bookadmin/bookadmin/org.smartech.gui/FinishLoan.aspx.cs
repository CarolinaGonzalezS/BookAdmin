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
        private static BsnClsBook bsn_book = new BsnClsBook();
        private static CntClsBook cnt_book = new CntClsBook();
        private static CntClsLoan cnt_loan = new CntClsLoan();

        protected void Page_Load(object sender, EventArgs e)
        {
            loadInformation();

        }

        protected void loadInformation()
        {
            code = Convert.ToString(Session["bookview"]);
            textCodeBook.Text = code;

            nameCustomer = Convert.ToString(Session["idCustomer"]);
            textIdCustomer.Text = nameCustomer;

            //stock = Convert.ToInt32((Session["stock"]));
            //textCodeLoan.Text = Convert.ToString(stock);

        }

        protected void updateBook()
        {
            stock = Convert.ToInt32(Session["stock"]);
            cnt_book.updateStockBook(textCodeBook.Text, Convert.ToInt32(stock));

        }

        protected void btnDoLoan_Click(object sender, EventArgs e)
        {
            code = Convert.ToString(Session["bookview"]);
            textCodeBook.Text = code;

            nameCustomer = Convert.ToString(Session["idCustomer"]);
            textIdCustomer.Text = nameCustomer;

            cnt_loan.insertLoan(textDateLoan.Text, textDateLimit.Text, textIdCustomer.Text, textCodeBook.Text);
            updateBook();

            Session.Add("idCustomer", nameCustomer);
            Response.Redirect("frm_PrestamoCliente.aspx");
            
        }



    }
}