using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookAdmin.org.SmarTech.GUI
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscadorGen_Click(object sender, EventArgs e)
        {
            string search = textSearch.Text;
            Session.Add("search", search);
            Response.Redirect("ResultSearch.aspx");  
        }

        protected void btnCiencia_Click(object sender, EventArgs e)
        {
            string search = "Ciencia";
            Session.Add("search", search);
            Response.Redirect("ResultCategorySearch.aspx");
        }

        protected void btnBiografia_Click(object sender, EventArgs e)
        {
            string search = "Biografias";
            Session.Add("search", search);
            Response.Redirect("ResultCategorySearch.aspx");
        }

        protected void btnSuspenso_Click(object sender, EventArgs e)
        {
            string search = "Suspenso";
            Session.Add("search", search);
            Response.Redirect("ResultCategorySearch.aspx");
        }

        protected void btnTerror_Click(object sender, EventArgs e)
        {
            string search = "Terror";
            Session.Add("search", search);
            Response.Redirect("ResultCategorySearch.aspx");
        }

        protected void btnMisterio_Click(object sender, EventArgs e)
        {
            string search = "Misterio";
            Session.Add("search", search);
            Response.Redirect("ResultCategorySearch.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (String.IsNullOrEmpty(textSearch.Text))
            {
                errorSearch();
            }
            else 
            {
                string search = textSearch.Text;
                Session.Add("search", search);
                Response.Redirect("ResultSearch.aspx");  
            }
            
        }

        protected void errorSearch()
        {
            string script = @"<script type='text/javascript'>
                    alert('Ingrese alguna palabra para la busqueda');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

    }
}