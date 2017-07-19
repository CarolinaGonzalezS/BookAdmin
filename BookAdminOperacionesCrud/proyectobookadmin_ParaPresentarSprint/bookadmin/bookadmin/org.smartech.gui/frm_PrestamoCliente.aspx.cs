using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BookAdmin.Reportes;
using BookAdmin.org.SmarTech.GUI;

namespace BookAdmin.org.SmarTech.GUI
{
    public partial class frm_PrestamoCliente : System.Web.UI.Page

    {
        private static string nameCustomer;
        private static rptPrestamoCliente orden = new rptPrestamoCliente();
        protected void Page_Load(object sender, EventArgs e)
        {
            nameCustomer = Convert.ToString(Session["idCustomer"]);
            orden.SetParameterValue("@identificationCard", nameCustomer);
            CrystalReportViewer1.ReportSource = orden;

        }
    }
}