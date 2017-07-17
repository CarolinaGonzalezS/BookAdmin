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
        static private EntClsReturnBook objReturnBook = new EntClsReturnBook();
        static private BsnClsReturnBook bsn_returnBook = new BsnClsReturnBook();
        static private EntClsReturnBook ent_returnBook= new EntClsReturnBook();
        List<EntClsReturnBook> result = new List<EntClsReturnBook>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }            

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            int search = Convert.ToInt32(textticket.Text);
            ent_returnBook=bsn_returnBook.ReturnBook(search);
            if(ent_returnBook.Isbn==null)
            {
                errorMessage();
            }
            else
            {
                showReturnBook(ent_returnBook);
            }

            }
                     

        protected void showReturnBook(EntClsReturnBook ReturnBook)
        {
            textName.Text = ReturnBook.Name;
            textIdentificationCard.Text = ReturnBook.IdentificationCard;
            textName.Text = ReturnBook.Name;
            textLastname.Text = ReturnBook.LastName;
            textNameBook.Text = ReturnBook.NameBook;
            textISBN.Text = ReturnBook.Isbn;
        }

        protected void errorMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('No existe ningun Libro');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void btnReturnBook_Click(object sender, EventArgs e)
        {
            bsn_returnBook.UpdateStateLoan(Convert.ToInt32(textticket.Text));
            EntClsSearch ent_seachInReturn=bsn_returnBook.searchBook(textNameBook.Text);
            int Newstock=bsn_returnBook.UpdateStock(ent_seachInReturn.Stock);
            bsn_returnBook.UpdateStockBook(ent_seachInReturn.Code, Newstock);                                  
        }
    }
}