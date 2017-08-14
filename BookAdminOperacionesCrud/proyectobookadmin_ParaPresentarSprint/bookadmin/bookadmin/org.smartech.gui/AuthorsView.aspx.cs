using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAdmin.org.SmarTech.entities;
using BookAdmin.org.SmarTech.Bussines;

namespace BookAdmin.org.SmarTech.GUI
{
    public partial class AuthorsView : System.Web.UI.Page
    {
        static List<EntClsAuthor> lstAuthor = new List<EntClsAuthor>();
        static BsnClsAuthor bsn_auth = new BsnClsAuthor();
        static EntClsAuthor ent_auth = new EntClsAuthor();
        static private EntClsWrite ent_write = new EntClsWrite();
        static private BsnClsWrite bsn_write = new BsnClsWrite();
        static private string code = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlAuthor.AutoPostBack = true;
                listAdd();
            }
        }

        public void listAdd()
        {
            lstAuthor = bsn_auth.createListOfAuthor();
            if (lstAuthor != null)
            {
                ddlAuthor.DataSource = lstAuthor;
                ddlAuthor.DataValueField = "id";
                ddlAuthor.DataTextField = "name";
                ddlAuthor.DataBind();
            }
        }

        protected void clean()
        {
            textName.Text = null;
            textLastName.Text = null;
            textNationality.Text = null;
            ddlAuthor.AutoPostBack = true;
        }

        protected void ddlAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent_auth = bsn_auth.checkAuthor(textName.Text, textLastName.Text);
            bsn_write.deleteWrite(ent_auth.Id, code);
            int valor = Convert.ToInt32(ddlAuthor.SelectedValue);
            foreach (EntClsAuthor auth in lstAuthor)
            {
                if (auth.Id == valor)
                {
                    ent_auth = auth;
                }
            }
            ShowAuthor(ent_auth);   
        }

        protected void ShowAuthor(EntClsAuthor objAuth)
        {
            textName.Text = bsn_auth.returnName(objAuth.Name);
            textLastName.Text = objAuth.LastName;
            textNationality.Text = objAuth.Nationality;
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
            try
            {
                bsn_auth.deleteAuthor(Convert.ToInt16(ddlAuthor.SelectedValue));

                listAdd();
                clean();

                string script = @"<script type='text/javascript'>
                
                alert('El Autor ha sido Eliminado');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
            }
            catch
            {
                string script = @"<script type='text/javascript'>
                
                alert('No se puede Eliminar el Autor');
                </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
            }
        }
    }
}