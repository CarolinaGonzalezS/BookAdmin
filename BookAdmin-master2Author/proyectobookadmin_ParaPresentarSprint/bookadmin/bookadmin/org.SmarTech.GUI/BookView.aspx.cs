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
    public partial class BookView : System.Web.UI.Page
    {
        private static BsnClsBook bsn_book = new BsnClsBook();
        private static EntClsBook ent_book = new EntClsBook();
        private static CntClsBook cnt_book = new CntClsBook();
        private static List<EntClsBook> listBook = new List<EntClsBook>();
        public static BsnClsAuthor bsn_auth = new BsnClsAuthor();
        public static BsnClsEditorial bsn_edit=new BsnClsEditorial();
        public static BsnClsCategory bsn_cate = new BsnClsCategory();
        public static BsnClsWrite bsn_write = new BsnClsWrite();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["customer"] == null)
            {
                Response.Redirect("RegistroPrestamo.aspx");
            }
        }

        protected void showBook(EntClsBook ent_book) 
        {
            textTitle.Text = ent_book.Name;
            textCodeBook.Text = ent_book.Code;
            textStock.Text = Convert.ToString(ent_book.Stock);
            textState.Text = ent_book.StateB;
            EntClsWrite ent_write = bsn_write.listWriteForCode(ent_book.Code);
            EntClsAuthor ent_author = bsn_auth.checkAuthorForId(ent_write.IdAuthor);
            textAuthor.Text = ent_author.Name + ' '+ ent_author.LastName;   
        }

        protected void btnDoLoan_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(textStock.Text);
            stock = stock - 1;
            //textStock.Text = Convert.ToString(stock);


            if (stock == 0)
            {

                updateMessage();

            }
            else
            {
                string idCustomer=Convert.ToString(Session["customer"]);
                Session.Add("bookview", ent_book.Code=textCodeBook.Text);
                Session.Add("IdCustomer", idCustomer);
                Response.Redirect("FinalizarPrestamo.aspx");
            }

            
        }

        protected void btnSearchBook_Click(object sender, EventArgs e)
        {
            string search = txtCodeBook.Text;
            EntClsBook book = bsn_book.checkBook2(search);
            showBook(book);
            btnNextLoan.Enabled = true;
        }

        protected void updateMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('No hay existencias');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

    }
}