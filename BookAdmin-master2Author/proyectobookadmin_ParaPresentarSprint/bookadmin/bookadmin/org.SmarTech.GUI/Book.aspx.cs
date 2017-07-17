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
    public partial class Book : System.Web.UI.Page
    {
        static EntClsBook ent_book = new EntClsBook();
        static BsnClsBook bsn_book = new BsnClsBook();
        static BsnClsWrite bsn_write = new BsnClsWrite();
        static int idEditorial;
        static int idAuthor;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["edit"] == null || Session["author"] == null) 
            {
                Response.Redirect("Autor.aspx");
            }
            loadDropDownList();
            ddlCategory.AutoPostBack = true;
            idEditorial = Convert.ToInt32(Session["edit"].ToString());
            idAuthor = Convert.ToInt32(Session["author".ToString()]);

        }

        private void loadDropDownList()
        {
            BsnClsCategory bsn_Categoria = new BsnClsCategory();
            ddlCategory.DataSource = bsn_Categoria.listCategory();
            ddlCategory.DataValueField = "id";
            ddlCategory.DataTextField = "name";
            ddlCategory.DataBind();
        }

        protected void buttonRegister_Click(object sender, EventArgs e)
        {
            int itemSelec = (ddlCategory.SelectedIndex) + 1;
            bsn_book.insertBook(textTitle.Text,textCode.Text,textIsbn.Text,textDate.Text,Convert.ToInt32(textStock.Text),itemSelec,idEditorial,"Disponible",1);
            bsn_write.insertWrite(idAuthor, textCode.Text);
            
        }

        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}