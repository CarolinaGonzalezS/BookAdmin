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
    public partial class ReportLoan : System.Web.UI.Page
    {
        private static string loan;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            loan = Session["loan"].ToString();
            Response.Write(loan);

            List<EntClsReportLoan> ent_rLoan = new List<EntClsReportLoan>();
            BsnClsReports bsn_rLoan = new BsnClsReports();

            if (loan == "Loan")
            {
                ent_rLoan = bsn_rLoan.LoanReport();
                loadGrid(ent_rLoan);
            }
        }

        private void loadGrid(List<EntClsReportLoan> extract)
        {
            grvLoanReport.DataSource = extract;
            grvLoanReport.DataBind();

        }

        protected void btnReturnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }
    }
}