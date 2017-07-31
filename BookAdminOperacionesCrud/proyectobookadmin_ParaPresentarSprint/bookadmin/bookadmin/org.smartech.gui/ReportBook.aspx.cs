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
    public partial class ResultReports : System.Web.UI.Page
    {
        private static string book;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            book = Session["book"].ToString();
            Response.Write(book);

            List<EntClsReports> ent_rbook = new List<EntClsReports>();
            BsnClsReports bsn_rbook = new BsnClsReports();

            if (book == "Book")
            {
                ent_rbook = bsn_rbook.BookReport();
                loadGrid(ent_rbook);
            }
        }

        private void loadGrid(List<EntClsReports> extract)
        {
            grvBookReport.DataSource = extract;
            grvBookReport.DataBind();
        }

        protected void btnReturnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

    }
}