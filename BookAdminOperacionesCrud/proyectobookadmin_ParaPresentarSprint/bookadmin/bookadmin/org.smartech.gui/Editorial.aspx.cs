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
    public partial class Editorial : System.Web.UI.Page
    {
        static List<EntClsEditorial> lstEditorial = new List<EntClsEditorial>();
        static BsnClsEditorial bsn_edit = new BsnClsEditorial();
        static EntClsEditorial ent_edit = new EntClsEditorial();
        static EntClsEditorial obj_edit = new EntClsEditorial();
        static EntClsBook ent_book = new EntClsBook();
        static BsnClsBook bsn_book = new BsnClsBook(); 
        static int insert = 0;        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["author"] == null)
            {
                Response.Redirect("Autor.aspx");
            }
            
            if (Session["book"] != null)
            {
                 ent_book = bsn_book.SearchBookForCode(Session["book"].ToString());
                 obj_edit = bsn_edit.checkEditorialForId(ent_book.IdEdit);
                 textName.Text = obj_edit.Name;
                 textCity.Text=obj_edit.City;
                 textCountry.Text=obj_edit.Country;
                 btnNextBook.Visible = true;                
                 btnNextEditorial.Visible = false;
                 btnUpdateCont.Enabled = true;
                 insert = 3;                 
                 Session["book"] = null;                 
            }

            if (!IsPostBack)
            {
                rblEditorial.AutoPostBack = true;

            }
        }

        protected void rblEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblEditorial.SelectedItem.Text == "Nuevo")
            {
                textName.Enabled = true;
                textCountry.Enabled = true;
                textCity.Enabled = true;
                btnNextBook.Enabled = true;
                insert = 1;
                clean();
            }
            else
            {
                listAdd();
                btnNextBook.Enabled = true;
                ddlEditorial.AutoPostBack = true;
                insert = 0;
            }
        }

        public void listAdd()
        {
            lstEditorial = bsn_edit.EditorialList();
            if (lstEditorial != null)
            {

                ddlEditorial.DataSource = lstEditorial;
                ddlEditorial.DataValueField = "id";
                ddlEditorial.DataTextField = "name";
                ddlEditorial.DataBind();
            }
        }

        protected void ddlEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(ddlEditorial.SelectedValue);
            foreach (EntClsEditorial edit in lstEditorial)
            {
                if (edit.Id == valor)
                {
                    ent_edit = edit;
                }
            }
            ShowEditorial(ent_edit);
        }

        protected void ShowEditorial(EntClsEditorial objEdit) {
            textName.Text = objEdit.Name;
            textCountry.Text = objEdit.Country;
            textCity.Text = objEdit.City;
        }

        protected void clean()
        {
            textName.Text = "";
            textCity.Text = "";
            textCountry.Text = "";
        }
        
        protected void btnNextBook_Click(object sender, EventArgs e)
        {
            if (insert == 1)
            {
                bsn_edit.insertEditorial(textName.Text, textCountry.Text, textCity.Text);
                ent_edit = bsn_edit.checkEditorial(textName.Text);
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("Book.aspx");
            }

            if (insert == 0)
            {                
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("Book.aspx");
            }            
        }

        protected void btnUpdateCont_Click(object sender, EventArgs e)
        {
            if (insert == 1)
            {
                Session["book"] = ent_book.Code;
                bsn_edit.insertEditorial(textName.Text, textCountry.Text, textCity.Text);
                ent_edit = bsn_edit.checkEditorial(textName.Text);
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("Book.aspx");
            }

            if (insert == 0)
            {
                Session["book"] = ent_book.Code;
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("Book.aspx");
            }
            else{
            Session["book"] = ent_book.Code;
            Session.Add("edit", ent_book.IdEdit);
            Response.Redirect("Book.aspx");
        }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Autor.aspx");
        }


        


    }
}