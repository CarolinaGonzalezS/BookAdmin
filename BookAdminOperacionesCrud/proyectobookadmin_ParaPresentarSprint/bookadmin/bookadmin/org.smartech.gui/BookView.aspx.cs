﻿using System;
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
        public static BsnClsEditorial bsn_edit = new BsnClsEditorial();
        public static BsnClsLoan bsn_loan = new BsnClsLoan();
        public static BsnClsCategory bsn_cate = new BsnClsCategory();
        public static BsnClsWrite bsn_write = new BsnClsWrite();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["succe"] != null)
            {
                SuccMessage();
                Session["succe"] = null;
            }
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {                
                listAdd();
                ddlBook.AutoPostBack = true;
                rblPrestado.AutoPostBack = true;
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            if (ValidFull())
            {
                Session.Add("book", ent_book.Code);
                Response.Redirect("AuthorOfBook.aspx");
            }
            else
            {
                ErrorMessage();
            }
         
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (rblPrestado.Visible)
            {
                if (rblPrestado.SelectedItem.Text == "Si")
                {
                    List<EntClsLoan> list_loan = bsn_loan.checkForCodeLoan(ent_book.Code);
                    foreach (EntClsLoan loan in list_loan)
                    {
                        bsn_loan.deleteLoan(loan.Id);
                    }
                    bsn_book.deleteBook(ent_book.Code);
                    clean();
                    listAdd();
                }
            }
            else
            {
                try
                {
                    if (ValidFull())
                    {
                        bsn_book.deleteBook(ent_book.Code);
                        clean();
                        listAdd();
                    }
                    else
                    {
                        ErrorMessage();
                    }
                }
                catch
                {
                    rblPrestado.Visible = true;
                    lblPrestado.Visible = true;
                    btnDelete.Enabled = false;
                    ErrorMessageLoan();
                }
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
            EntClsCategory ent_categ = bsn_cate.listCategoryForid(book.IdCateg);
            textCategory.Text = ent_categ.Name;
            EntClsEditorial ent_edit = bsn_edit.checkEditorialForId(book.IdEdit);
            textEdit.Text = ent_edit.Name;
            EntClsWrite ent_write = bsn_write.listWriteForCode(book.Code);
            EntClsAuthor ent_author = bsn_auth.checkAuthorForId(ent_write.IdAuthor);
            textAuthor.Text = ent_author.Name + ' ' + ent_author.LastName;

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

        protected void btnNewBook_Click(object sender, EventArgs e)
        {
            Session.Add("regis", 1);
            Response.Redirect("AuthorOfBook.aspx");
        }

        protected bool ValidFull()
        {
            bool full = true;
            if (String.IsNullOrEmpty(textAuthor.Text))
            {
                full = false;
            }
            return full;
        }

        protected void SuccMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('Operacion Exitosa');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void ErrorMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('Los campos no estan llenos');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void ErrorMessageLoan()
        {
            string script = @"<script type='text/javascript'>
                    alert('El libro esta prestado si desea eliminarlo seleccione si lo esta y continue con eliminar');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void rblPrestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblPrestado.SelectedItem.Text == "Si")
            {
                btnDelete.Enabled = true;
            }     
        }
    }
}