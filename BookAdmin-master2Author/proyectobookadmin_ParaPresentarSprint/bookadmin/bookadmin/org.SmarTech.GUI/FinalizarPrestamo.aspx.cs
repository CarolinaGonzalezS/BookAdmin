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
    public partial class FinalizarPrestamo : System.Web.UI.Page
    {
        private static string code;
        private static string titlebook;
        private static string nameCustomer;
        private static BsnClsBook bsn_book = new BsnClsBook();

        protected void Page_Load(object sender, EventArgs e)
        {

            loadInformation();

            
        }

        protected void loadInformation()
        {
            code = Convert.ToString(Session["bookview"]);
            textTitleBook.Text =code;

            nameCustomer = Convert.ToString(Session["idCustomer"]);
            textNameCustomer.Text = nameCustomer;


 
        }


    }
}