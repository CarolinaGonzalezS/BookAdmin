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
    public partial class ReturnBook1 : System.Web.UI.Page
    {
        static private List<EntClsReturnBook> lstReturnBook = new List<EntClsReturnBook>();
        static private BsnClsReturnBook bsn_returnBook = new BsnClsReturnBook();
        static private EntClsReturnBook ent_returnBook= new EntClsReturnBook();
        List<EntClsReturnBook> result = new List<EntClsReturnBook>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
           
            int search = Convert.ToInt32(textticket.Text);
            if (search == null)
            {
                errorMessage();
            }
            else
            {
                textName.Text = ent_returnBook.Name;
                textIdentificationCard.Text = ent_returnBook.IdentificationCard;
                textName.Text = ent_returnBook.Name;
                textNameBook.Text = ent_returnBook.NameB;
                textISBN.Text = ent_returnBook.Isbn;
            }
            
        }
        protected void errorMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('No existe ningun Libro');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }
    }
}