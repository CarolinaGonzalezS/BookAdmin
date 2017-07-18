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
        public static BsnClsEditorial bsn_editorial = new BsnClsEditorial();
        public static EntClsEditorial ent_editorial = new EntClsEditorial();
        public static CntClsEditorial cnt_editorial = new CntClsEditorial();
        static int insert = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["author"] == null)
            {
                Response.Redirect("Autor.aspx");
            }

            rblEditorial.AutoPostBack= true;
        }

        protected void rblEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblEditorial.SelectedItem.Text == "Nuevo")
            {
                textName.Enabled = true;
                textCountry.Enabled = true;
                textCity.Enabled = true;
                btnNextEditorial.Enabled = true;
                insert = 1;
            }
            else
            {
                listAdd();
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

        protected void btnNextBook_Click(object sender, EventArgs e)
        {
            if (insert == 1)
            {
                bsn_edit.insertEditorial(textName.Text, textCountry.Text, textCity.Text);
                ent_edit = bsn_edit.checkEditorial(textName.Text);
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("Book.aspx");
            }
            else
            {
                Session.Add("edit", ent_edit.Id);
                Response.Redirect("Book.aspx");
            }
        }

        protected void btnUpdateEditorial_Click(object sender, EventArgs e)
        {
            //insertar el nuevo registro actualizado
            textName.Enabled = true;
            textCountry.Enabled = true;
            textCity.Enabled = true;
            
                string valor = ddlEditorial.SelectedValue;
                int valor2 = ddlEditorial.SelectedIndex + 1;
                foreach (EntClsEditorial edit in lstEditorial)
                {
                    if (Convert.ToString(edit.Id) == valor)
                    {
                        ent_editorial = edit;
                    }
                }
                cnt_editorial.updateEditorial(valor2, textName.Text, textCountry.Text, textCity.Text);
                loadDrop();
                //updateMessage();
                clear();
            
            
        }

        public void loadDrop()
        {
            lstEditorial = bsn_editorial.listEditorial();
            if (lstEditorial != null)
            {
                ddlEditorial.DataSource = lstEditorial;
                ddlEditorial.DataValueField = "id";
                ddlEditorial.DataTextField = "name";
                ddlEditorial.DataBind();
            }
        }

        protected void clear()
        {
            textName.Text = "";
            textCountry.Text = "";
            textCity.Text = "";

        }

        protected void updateMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('Actualizacion exitosa');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

    }
}