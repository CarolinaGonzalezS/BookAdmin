using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookAdmin.org.SmarTech.GUI
{
    public partial class FinalizarPrestamo : System.Web.UI.Page
    {
        private static string code;
        private static string nameCustomer;
        protected void Page_Load(object sender, EventArgs e)
        {

            code = Convert.ToString(Session["bookview"]);
            textCodeLoan.Text = code;

            nameCustomer = Convert.ToString(Session["idCustomer"]);
            textNameCustomer.Text = nameCustomer;

            
        }


    }
}