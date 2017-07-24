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
        static private EntClsReturnBook ent_returnBook = new EntClsReturnBook();
        static private EntClsLoan ent_loan = new EntClsLoan();
        static private BsnClsLoan bsn_loan = new BsnClsLoan();
        static private EntClsBook ent_book = new EntClsBook();
        static private BsnClsBook bsn_book = new BsnClsBook();

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
            int state = Convert.ToInt32(textticket.Text);
            ent_loan = bsn_loan.searchLoan(state);

            if (ent_loan.StateL == "Finalizado")
            {
                string script = @"<script type='text/javascript'>
                    alert('Ya se devolvio el libro anteriormente');
                    </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
                btnReturnBook.Enabled = false;
            }
            else
            {
                int search = Convert.ToInt32(textticket.Text);
                ent_returnBook = bsn_returnBook.ReturnBook(search);

                if (ent_returnBook.Code == null)
                {
                    errorMessage();
                }
                else
                {
                    showReturnBook(ent_returnBook);
                    btnReturnBook.Enabled = true;
                }
            }
        }

        protected void showReturnBook(EntClsReturnBook ReturnBook)
        {
            textIdentificationCard.Text = ent_returnBook.IdentificationCard;
            textName.Text = ent_returnBook.Name;
            textLastname.Text = ent_returnBook.LastName;
            textNameBook.Text = ent_returnBook.NameBook;
            textCode.Text = ent_returnBook.Code;
        }

        protected void errorMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('Codigo de Prestamo Incorrecto');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void returnBookMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('Se ha devuelto el Libro');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void btnReturnBook_Click(object sender, EventArgs e)
        {
            bsn_returnBook.UpdateStateLoan(Convert.ToInt32(textticket.Text));
            EntClsSearch ent_returnbook = bsn_returnBook.searchBook(textNameBook.Text);
            int Newstock = bsn_returnBook.UpdateStock(ent_returnbook.Stock);
            bsn_returnBook.UpdateStockBook(ent_returnbook.Code, Newstock);

            returnBookMessage();
            btnReturnBook.Enabled = false;

            Response.Redirect("Fine.aspx");  
        }
    }
}