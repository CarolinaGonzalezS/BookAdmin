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

        protected void showBook(EntClsBook book) 
        {
            textTitle.Text = book.Name;
            textIsbn.Text = book.Isbn;
            textDatePublish.Text = book.DatePublish;
            textStock.Text = Convert.ToString(book.Stock);
            textState.Text = book.StateB;
            EntClsCategory ent_categ=bsn_cate.listCategoryForid(book.IdCateg);
            textCategory.Text=ent_categ.Name;
            EntClsEditorial ent_edit = bsn_edit.checkEditorialForId(book.IdEdit);
            textEdit.Text = ent_edit.Name;
            EntClsWrite ent_write = bsn_write.listWriteForCode(book.Code);
            EntClsAuthor ent_author = bsn_auth.checkAuthorForId(ent_write.IdAuthor);
            textAuthor.Text = ent_author.Name + ' '+ ent_author.LastName;   
        }

        protected void btnDoLoan_Click(object sender, EventArgs e)
        {
            ent_book.Stock = ent_book.Stock - 1;
            if (ent_book.Stock == 0)
            {
                ent_book.StateB = "No Disponible";
            }

            Session.Add("bookview", ent_book.Code);
            Response.Redirect("FinalizarPrestamo.aspx");
        }

        protected void btnSearchBook_Click(object sender, EventArgs e)
        {
            string search = txtCodeBook.Text;
            ent_book = bsn_book.checkBook(search);

            if (ent_book.Name == null)
            {
                Response.Redirect("Book.aspx");
            }
            else
            {
                textTitle.Enabled = true;
                textDatePublish.Enabled = true;
                textCategory.Enabled = true;
                textStock.Enabled = true;
                textIsbn.Enabled = true;
                textEdit.Enabled = true;
                textAuthor.Enabled = true;
                textState.Enabled = true;

                showBook(ent_book);

                btnNextLoan.Enabled = true;
            }
        }

    }
}