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
    public partial class BookRegister : System.Web.UI.Page
    {
        static EntClsBook ent_book = new EntClsBook();
        static BsnClsBook bsn_book = new BsnClsBook();
        static BsnClsWrite bsn_write = new BsnClsWrite();
        static BsnClsCategory bsn_category = new BsnClsCategory();
        static BsnClsSearch bsn_search = new BsnClsSearch();
        static List<EntClsSearch> list_search = new List<EntClsSearch>();
        static EntClsCategory ent_category = new EntClsCategory();
        int idEditorial;
        int idAuthor;                
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");

            }

            if (Session["edit"] == null || Session["author"] == null)
            {
                Response.Redirect("Autor.aspx");
            }
            if (Session["book"] != null)
            {
                btnUpdate.Visible = true;
                btnRegister.Visible = false;
                btnUpdate.Enabled = true;
                ent_book = bsn_book.SearchBook(Session["book"].ToString());
                textTitle.Text = ent_book.Name;
                textCode.Text = ent_book.Code;
                textCode.Enabled = false;
                textDate.Text = ent_book.DatePublish;
                textIsbn.Text = ent_book.Isbn;
                textStock.Text = Convert.ToString(ent_book.Stock);
                ent_category = bsn_category.listCategoryForid(ent_book.IdCateg);                
                Session["book"] = null;
            }
            else
            {
                if(Session["regis"]!=null)
                {             
                btnRegister.Enabled = true;
                btnUpdate.Visible = false;                
                }
            }
            idEditorial = Convert.ToInt32(Session["edit"].ToString());
            idAuthor = Convert.ToInt32(Session["author".ToString()]);                
            if (!IsPostBack)
            {
                loadDropDownList();
                ddlCategory.AutoPostBack = true;
                ddlState.AutoPostBack = true;
            }
        }

        private void loadDropDownList()
        {
            BsnClsCategory bsn_Category = new BsnClsCategory();
            ddlCategory.DataSource = bsn_Category.listCategory();
            ddlCategory.DataValueField = "id";
            ddlCategory.DataTextField = "name";
            ddlCategory.DataBind();

            List<string> state = new List<string>();
            state.Add("Disponible");
            state.Add("No Disponible");
            ddlState.DataSource = state;
            ddlState.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int idcateg = Convert.ToInt32(ddlCategory.SelectedValue);
                string state = ddlState.SelectedItem.Text;
                bsn_book.updateBook(textCode.Text, textIsbn.Text, textTitle.Text, textDate.Text, idEditorial, idcateg, state, Convert.ToInt32(textStock.Text));
                bsn_write.insertWrite(idAuthor, textCode.Text);
                Session.Add("succe", 1);
                Response.Redirect("BookView.aspx");
            }
            catch 
            {
                string script = @"<script type='text/javascript'>
                    alert('Algun dato esta erroneo revisa');
                    </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
            }


        }

        protected void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                            int itemSelec = (ddlCategory.SelectedIndex) + 1;
                            bsn_book.insertBook(textTitle.Text, textCode.Text, textIsbn.Text, textDate.Text, Convert.ToInt32(textStock.Text), itemSelec, idEditorial, "Disponible", 1);
                            bsn_write.insertWrite(idAuthor, textCode.Text);
                            Session.Add("succe", 1);
                            Response.Redirect("BookView.aspx");
            }
            catch
            {
                string script = @"<script type='text/javascript'>
                    alert('No se ha registrado el libro revise los datos ingresados');
                    </script>";
                ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
            }

        }
        
        protected void clear() 
        {
            textCode.Text = "";            
            textTitle.Text = "";
            textStock.Text = "";
            textIsbn.Text = "";
            textDate.Text = "";
            
        }

        
    }
}