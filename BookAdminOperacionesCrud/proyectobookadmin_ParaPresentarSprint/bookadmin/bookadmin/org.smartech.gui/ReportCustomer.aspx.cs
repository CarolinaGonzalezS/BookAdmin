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
    public partial class ReportCustomer : System.Web.UI.Page
    {
        private static string customer;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            customer = Session["customer"].ToString();
            Response.Write(customer);

            List<EntClsCustomer> ent_rcustomer = new List<EntClsCustomer>();
            BsnClsReports bsn_rcustomer = new BsnClsReports();

            if (customer == "Customer")
            {                
                ent_rcustomer = bsn_rcustomer.CustomerReport();                
                loadGrid(ent_rcustomer);
            }
        }

        private void loadGrid(List<EntClsCustomer> extract)
        {
            grvCustomerReport.DataSource = extract;
            grvCustomerReport.DataBind();
        }

        protected void btnReturnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }

        protected void btnReturnReport_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }


    }
}