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
    public partial class ReportFine : System.Web.UI.Page
    {
        private static string fine;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            fine = Session["fine"].ToString();
            Response.Write(fine);

            List<EntClsReportFine> ent_rLoan = new List<EntClsReportFine>();
            BsnClsReports bsn_rLoan = new BsnClsReports();

            if (fine == "Fine")
            {
                ent_rLoan = bsn_rLoan.FineReport();
                loadGrid(ent_rLoan);
            }
        }

        private void loadGrid(List<EntClsReportFine> extract)
        {
            grvFineReport.DataSource = extract;
            grvFineReport.DataBind();

        }

        protected void btnReturnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

    }
}