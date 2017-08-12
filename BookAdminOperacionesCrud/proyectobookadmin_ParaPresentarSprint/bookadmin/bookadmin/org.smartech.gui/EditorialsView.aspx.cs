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
    public partial class EditorialsView : System.Web.UI.Page
    {
        static List<EntClsEditorial> lstEditorial = new List<EntClsEditorial>();
        static List<EntClsEditorial> lstEditVal = new List<EntClsEditorial>();
        static BsnClsEditorial bsn_edit = new BsnClsEditorial();
        static EntClsEditorial ent_edit = new EntClsEditorial();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlEditorial.AutoPostBack = true;
                listAdd();
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try { 
                string valor = ddlEditorial.SelectedValue;
                int valor2 = ddlEditorial.SelectedIndex + 1;
                foreach (EntClsEditorial edit in lstEditorial)
                {
                    if (Convert.ToString(edit.Id) == valor)
                    {
                        ent_edit = edit;
                    }
                }
                    bsn_edit.updateEditorial(valor2, textName.Text, textCountry.Text, textCity.Text);                                        
                    SucceUpdateEdit();
                    Response.Redirect("EditorialsView.aspx");
                }
            catch 
            {
                errorUpdateEdit();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ent_edit = bsn_edit.checkEditorial(textName.Text);            
            lstEditVal = bsn_edit.valEdit(ent_edit.Id);
            if (lstEditVal.Count() > 0)
            {
                errorDeleteEdit();
            }
            else 
            {
                bsn_edit.deleteEditorial(ent_edit.Id);                
                SucceDeleteEdit();
                Response.Redirect("EditorialsView.aspx");
            }
        }

        protected void clean() 
        {
            textCity.Text = "";
            textCountry.Text = "";
            textName.Text = "";
            ddlEditorial.AutoPostBack = true;
        }
        protected void errorDeleteEdit()
        {
            string script = @"<script type='text/javascript'>
                    alert('No se puede eliminar esta editorial, existe un libro perteneciente a esta editorial');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void errorUpdateEdit()
        {
            string script = @"<script type='text/javascript'>
                    alert('No se puede actualizar esta editorial');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void SucceDeleteEdit()
        {
            string script = @"<script type='text/javascript'>
                    alert('La editorial a sido eliminada');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

        protected void SucceUpdateEdit()
        {
            string script = @"<script type='text/javascript'>
                    alert('La editorial a sido actualizada');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }
    }
}