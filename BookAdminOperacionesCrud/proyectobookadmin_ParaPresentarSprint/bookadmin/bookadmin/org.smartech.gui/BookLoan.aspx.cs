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
    public partial class BookLoan : System.Web.UI.Page
    {
        private static BsnClsBook bsn_book = new BsnClsBook();
        private static EntClsBook ent_book = new EntClsBook();
        private static List<EntClsBook> listBook = new List<EntClsBook>();
        public static BsnClsAuthor bsn_auth = new BsnClsAuthor();
        public static BsnClsEditorial bsn_edit = new BsnClsEditorial();
        public static BsnClsCategory bsn_cate = new BsnClsCategory();
        public static BsnClsWrite bsn_write = new BsnClsWrite();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }  

            if (Session["customer"] == null)
            {
                Response.Redirect("RegistroPrestamo.aspx");
            }
        }

        protected void showBook(EntClsBook ent_book)
        {
            txtTitle.Text = ent_book.Name;
            txtStock.Text = Convert.ToString(ent_book.Stock);
            txtCode.Text = ent_book.Code;
            EntClsWrite ent_write = bsn_write.listWriteForCode(ent_book.Code);
            EntClsAuthor ent_author = bsn_auth.checkAuthorForId(ent_write.IdAuthor);
            txtAuthor.Text = ent_author.Name + ' ' + ent_author.LastName;
            txtStateB.Text = ent_book.StateB;
        }

        protected void btnNextLoan_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(txtStock.Text);

            if (stock == 0)
            {
                updateMessage();
            }
            else
            {
                int newStock = bsn_book.minStock(ent_book.Stock);
                bsn_book.updateStateB(ent_book.Code, newStock);

                string idCustomer = Convert.ToString(Session["customer"]);
                Session.Add("stock", stock);
                Session.Add("bookview", ent_book.Code = txtCode.Text);
                Session.Add("IdCustomer", idCustomer);
                Response.Redirect("FinishLoan.aspx");
            }
        }

        protected void updateMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('No hay existencias');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void btnSearchBook_Click(object sender, EventArgs e)
        {
            string search = txtSearchBook.Text;
            EntClsBook book = bsn_book.checkBook2(search);
            showBook(book);

            txtTitle.Enabled = true;
            txtStock.Enabled = true;
            txtCode.Enabled = true;
            txtAuthor.Enabled = true;
            txtStateB.Enabled = true;

            btnNextLoan.Enabled = true;
        }
    }
}