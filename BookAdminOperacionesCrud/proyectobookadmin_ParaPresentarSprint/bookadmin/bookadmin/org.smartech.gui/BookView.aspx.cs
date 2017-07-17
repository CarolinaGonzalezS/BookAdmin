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
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                listAdd();
                ddlBook.AutoPostBack = true;
            }  
            
        }

        public void listAdd()
        {
            listBook = bsn_book.listBook();
            if (listBook != null)
            {

                ddlBook.DataSource = listBook;
                ddlBook.DataValueField = "code";
                ddlBook.DataTextField = "name";
                ddlBook.DataBind();
            }
        }

        protected void ddlBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = ddlBook.SelectedValue;
            textAuthor.Text = valor;            
            foreach (EntClsBook book in listBook)
            {
                if (book.Code == valor)
                {
                    ent_book = book;
                }
            }
            ShowBook(ent_book);             
        }

        protected void ShowBook(EntClsBook book) 
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

        protected void clean() 
        {
            textAuthor.Text = "";
            textCategory.Text = "";
            textDatePublish.Text = "";
            textEdit.Text = "";
            textIsbn.Text = "";
            textState.Text = "";
            textStock.Text = "";
            textTitle.Text = "";
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Session.Add("book",ent_book.Code);
            Response.Redirect("AuthorOfBook.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            bsn_book.deleteBook(ent_book.Code);
            clean();
        }
    }
}