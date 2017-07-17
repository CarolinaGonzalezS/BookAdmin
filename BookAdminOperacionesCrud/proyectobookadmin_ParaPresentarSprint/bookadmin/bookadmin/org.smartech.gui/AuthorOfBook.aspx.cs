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
    public partial class AuthorOfBook : System.Web.UI.Page
    {
        static private List<EntClsAuthor> lstAuthor = new List<EntClsAuthor>();
        static private BsnClsAuthor bsn_author = new BsnClsAuthor();
        static private EntClsAuthor ent_Auth = new EntClsAuthor();
        static private EntClsBook ent_book = new EntClsBook();
        static private int insert = 0;
        static private BsnClsBook bsn_book = new BsnClsBook();
        static EntClsAuthor obj_Auth = new EntClsAuthor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (Session["book"] != null)
            {
                ent_book = bsn_book.SearchBookForCode(Session["book"].ToString());
                ent_Auth = bsn_author.checkAuthorForId(ent_book.IdUser);
                textName.Text = ent_Auth.Name;
                textLastName.Text = ent_Auth.LastName;
                textNationality.Text = ent_Auth.Nationality;
                btnUpdateCont.Visible = true;
                btnNextEditorial.Visible = false;
                insert = 3;
                Session["book"] = null;
            }
            else
            {
                btnNextEditorial.Visible = true;
                btnUpdateCont.Visible = false;
            }
            if (!IsPostBack)
            {
                rblAuthor.AutoPostBack = true;

            }

        }

        protected void rblAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblAuthor.SelectedItem.Text == "Nuevo")
            {
                clean();
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

        protected void btnUpdateCont_Click(object sender, EventArgs e)
        {

            if (insert == 1)
            {
                Session["book"] = ent_book.Code;
                bsn_author.insertAuthor(textName.Text, textLastName.Text, textNationality.Text);
                ent_Auth = bsn_author.checkAuthor(textName.Text, textLastName.Text);
                Session.Add("author", ent_Auth.Id);
                Response.Redirect("EditorialOfBook.aspx");
            }

            if (insert == 0)
            {
                Session["book"] = ent_book.Code;
                Session.Add("author", ent_Auth.Id);
                Response.Redirect("EditorialOfBook.aspx");
            }
            else
            {
                Session["book"] = ent_book.Code;
                Session.Add("author", ent_book.IdUser);
                Response.Redirect("EditorialOfBook.aspx");
            }
        }

        protected void btnNextEditorial_Click(object sender, EventArgs e)
        {
            if (insert == 1)
            {
                bsn_author.insertAuthor(textName.Text, textLastName.Text, textNationality.Text);
                ent_Auth = bsn_author.checkAuthor(textName.Text, textLastName.Text);
                Session.Add("author", ent_Auth.Id);
                Response.Redirect("EditorialOfBook.aspx");
            }

            if (insert == 0)
            {
                Session.Add("author", ent_Auth.Id);
                Response.Redirect("EditorialOfBook.aspx");
            }

        }
        protected void clean()
        {
            textName.Text = "";
            textLastName.Text = "";
            textNationality.Text = "";
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
                bsn_author.deleteAuthor(Convert.ToInt16(ddlAuthor.SelectedValue));

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