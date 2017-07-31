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
    public partial class Reports1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void imgbtnBook_Click(object sender, ImageClickEventArgs e)
        {
            string book = "Book";
            Session.Add("book", book);
            Response.Redirect("ReportBook.aspx");
        }

        protected void imgbtnCustomer_Click(object sender, ImageClickEventArgs e)
        {
            string customer = "Customer";
            Session.Add("customer", customer);
            Response.Redirect("ReportCustomer.aspx");
        }

        protected void imgbtnLoan_Click(object sender, ImageClickEventArgs e)
        {
            string loan = "Loan";
            Session.Add("loan", loan);
            Response.Redirect("ReportLoan.aspx");
        }

        protected void imgbtnFine_Click(object sender, ImageClickEventArgs e)
        {
            string fine = "Fine";
            Session.Add("fine", fine);
            Response.Redirect("ReportFine.aspx");
        }
    }
}