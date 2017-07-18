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
    public partial class Autor : System.Web.UI.Page
    {
        static private List<EntClsAuthor> lstAuthor = new List<EntClsAuthor>();
        static private List<EntClsWrite> lstWrite = new List<EntClsWrite>();
        static private BsnClsAuthor bsn_author = new BsnClsAuthor();
        static private EntClsAuthor ent_Auth = new EntClsAuthor();
        static private BsnClsWrite bsn_write = new BsnClsWrite();
        static private EntClsWrite ent_write = new EntClsWrite();
        static private int insert = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            rblAuthor.AutoPostBack = true;

        }

        protected void rblAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblAuthor.SelectedItem.Text == "Nuevo")
            {
                textName.Enabled = true;
                textLastName.Enabled = true;
                textNationality.Enabled = true;
                btnNextEditorial.Enabled = true;
                insert = 1;
            }
            else
            {
                listAdd();
                ddlAuthor.AutoPostBack = true;
                btnNextEditorial.Enabled = true;
                insert = 0;
            }
        }

        public void listAdd()
        {
            lstAuthor = bsn_author.AuthorList();
            if (lstAuthor != null)
            {

                ddlAuthor.DataSource = lstAuthor;
                ddlAuthor.DataValueField = "id";
                ddlAuthor.DataTextField = "name";
                ddlAuthor.DataBind();
            }
        }

        protected void ddlAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(ddlAuthor.SelectedValue);
            foreach (EntClsAuthor auth in lstAuthor)
            {
                if (auth.Id == valor)
                {
                    ent_Auth = auth;
                }
            }
            ShowAuthor(ent_Auth);
        }

        protected void ShowAuthor(EntClsAuthor author)
        {
            textName.Text = author.Name;
            textLastName.Text = author.LastName;
            textNationality.Text = author.Nationality;
        }

        protected void btnNextEditorial_Click(object sender, EventArgs e)
        {
            if (insert == 1)
            {
                bsn_author.insertAuthor(textName.Text, textLastName.Text, textNationality.Text);
                ent_Auth = bsn_author.checkAuthor(textName.Text, textLastName.Text);
                Session.Add("author", ent_Auth.Id);
                Response.Redirect("Editorial.aspx");
            }
            else
            {
                Session.Add("author", ent_Auth.Id);
                Response.Redirect("Editorial.aspx");
            }
        }

        private void clean()
        {
            textName.Text = null;
            textLastName.Text = null;
            textNationality.Text = null;
        }

        protected void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            BsnClsAuthor bsn_author = new BsnClsAuthor();
            if ((bsn_author.updateAuthor(Convert.ToInt16(ddlAuthor.SelectedValue), textName.Text, textLastName.Text, textNationality.Text) > 0))
            {
                clean();
                listAdd();
                
                string script = @"<script type='text/javascript'>
                
                alert('El Autor ha sido Modificado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
            }
        }

        protected void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            List<EntClsWrite> lstWrite = new List<EntClsWrite>();
            BsnClsWrite bsn_write = new BsnClsWrite();
            int id = Convert.ToInt16(ddlAuthor.SelectedValue);
            lstWrite = bsn_write.SearchBookForIdAuthor(id);
            if (lstWrite.Count() == 0)
            {
                bsn_author.deleteAuthor(Convert.ToInt16(ddlAuthor.SelectedValue));
     
                listAdd();
                clean();

                string script = @"<script type='text/javascript'>
                
                alert('El Autor ha sido Eliminado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
            }
            else  
            {
                string script = @"<script type='text/javascript'>
                
                alert('No se puede Eliminar el Autor');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
            }
        }

    }
}