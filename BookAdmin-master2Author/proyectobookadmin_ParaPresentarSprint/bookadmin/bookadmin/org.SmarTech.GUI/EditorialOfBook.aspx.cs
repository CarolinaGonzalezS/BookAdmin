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
    public partial class EditorialOfBook : System.Web.UI.Page
    {
        static List<EntClsEditorial> lstEditorial = new List<EntClsEditorial>();
        static BsnClsEditorial bsn_edit = new BsnClsEditorial();
        static BsnClsSearch bsn_search = new BsnClsSearch();
        static EntClsEditorial ent_edit = new EntClsEditorial();
        static EntClsEditorial obj_edit = new EntClsEditorial();
        static EntClsBook ent_book = new EntClsBook();
        static BsnClsBook bsn_book = new BsnClsBook();
        static int insert = 0;
        private static string code = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (Session["author"] == null)
            {
                Response.Redirect("Autor.aspx");
            }

            if (Session["book"] != null)
            {
                ent_book = bsn_book.SearchEditorialOfBook(Session["book"].ToString());
                obj_edit = bsn_edit.checkEditorialForId(ent_book.IdEdit);
                textName.Text = obj_edit.Name;
                textCity.Text = obj_edit.City;
                textCountry.Text = obj_edit.Country;
                btnUpdateCont.Visible = true;
                btnUpdateCont.Enabled = true;
                code = Session["book"].ToString();
                insert = 3;
                Session["book"] = null;
            }
            else
            {
                if (Session["regis"] != null)
                {
                    btnNextBook.Visible = true;
                }
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
                clean();
                insert = 1;
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

        protected void ShowEditorial(EntClsEditorial objEdit)
        {
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

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthorOfBook.aspx");
        }

        protected void btnUpdateCont_Click(object sender, EventArgs e)
        {
            if (insert == 1)
            {
                if (valNameEditorial())
                {
                    errorEditorial();
                }
                else
                {
                    Session["book"] = code;
                    bsn_edit.insertEditorial(textName.Text, textCountry.Text, textCity.Text);
                    ent_edit = bsn_edit.checkEditorial(textName.Text);
                    Session.Add("edit", ent_edit.Id);
                    Response.Redirect("BookRegister.aspx");
                }
            }

            if (insert == 0)
            {
                Session["book"] = code;
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("BookRegister.aspx");
            }
            else
            {
                Session["book"] = code;
                ent_edit = bsn_edit.checkEditorial(textName.Text);
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("BookRegister.aspx");
            }
        }

        protected void btnNextBook_Click(object sender, EventArgs e)
        {
            if (insert == 1)
            {
                if (valNameEditorial())
                {
                    errorEditorial();
                }
                else
                {
                    bsn_edit.insertEditorial(textName.Text, textCountry.Text, textCity.Text);
                    ent_edit = bsn_edit.checkEditorial(textName.Text);
                    Session.Add("edit", ent_edit.Id);
                    Response.Redirect("BookRegister.aspx");
                }
            }

            if (insert == 0)
            {
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("BookRegister.aspx");
            }
        }
        protected void errorEditorial()
        {
            string script = @"<script type='text/javascript'>
                    alert('Ya existe esta editorial');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected bool valNameEditorial()
        {
            List<EntClsSearch> list_entsearch = bsn_search.ForNameEditorial(textName.Text);
            if (list_entsearch.Count() >= 1)
            {
                return true;
            }
            return false;
        }



    }
}