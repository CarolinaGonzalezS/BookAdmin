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
    public partial class RegistroLibro : System.Web.UI.Page
    {
        public static int change1 = 0;
        public static int change2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }            

            if (!IsPostBack)
            {
                Calendar1.Visible = false;
                loadDropDownList();
                ddlCategory.AutoPostBack = true;
            }
        }

        private void loadDropDownList()
        {
            BsnClsCategory bsn_Categoria = new BsnClsCategory();
            ddlCategory.DataSource = bsn_Categoria.listCategory();
            ddlCategory.DataValueField = "id";
            ddlCategory.DataTextField = "name";
            ddlCategory.DataBind();
        }


        protected void ddlCategoria_TextChanged(object sender, EventArgs e)
        {
            BsnClsCategory bsn_Categoria = new BsnClsCategory();
            //ClsCategoria objCategoria = ngCategoria.listarCategoriaid(itemSelec);            
        }

        protected void clear()
        {
            textNameAuth.Text = "";
            textCountry.Text = "";
            textCode.Text = "";
            textDate.Text = "";
            textCity.Text = "";
            textNameEdit.Text = "";
            textTitle.Text = "";
            textStock.Text = "";
            textNationality.Text = "";
            textIsbn.Text = "";
            textLastName.Text = "";
            textCity.Enabled = false;
            textCountry.Enabled = false;
            textNationality.Enabled = false;

            buttonCheckAuthor.Enabled = true;
            buttonCheckEditorial.Enabled = true;

        }
        protected void registerSucces()
        {
            string script = @"<script type='text/javascript'>
                    alert('Libro registrado exitosamente!');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }
        protected void registerFail()
        {
            string script = @"<script type='text/javascript'>
                    alert('el libro ya existe en el sistema!');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }
        protected EntClsAuthor registerBook()
        {
            int itemSelec = (ddlCategory.SelectedIndex) + 1;
            BsnClsBook bsn_book = new BsnClsBook();
            BsnClsEditorial bsn_edit = new BsnClsEditorial();
            EntClsEditorial obj_edit = bsn_edit.checkEditorial(textNameEdit.Text);
            int idedit = obj_edit.Id;
            int stock = Convert.ToInt16(textStock.Text);
            EntClsAuthor obj_author = new EntClsAuthor();
            BsnClsAuthor bsn_author = new BsnClsAuthor();
            obj_author = bsn_author.checkAuthor(textNameAuth.Text, textLastName.Text);
            bsn_book.insertBook(textTitle.Text, textCode.Text, textIsbn.Text, textDate.Text, Convert.ToInt16(textStock.Text), itemSelec, idedit, "Disponible", 1);
            return obj_author;
        }

        protected void buttonCheckEditorial_Click(object sender, EventArgs e)
        {

            BsnClsEditorial bsn_editorial = new BsnClsEditorial();
            EntClsEditorial editFind = bsn_editorial.checkEditorial(textNameEdit.Text);
            if (editFind.Name == null)
            {
                textCity.Enabled = true;
                textCountry.Enabled = true;
                change2 = 1;
            }
            else
            {
                textNameEdit.Text = editFind.Name;
                textCountry.Text = editFind.Country;
                textCity.Text = editFind.City;
            }
            buttonCheckEditorial.Enabled = false;

        }

        protected void buttonRegister_Click(object sender, EventArgs e)
        {

            BsnClsBook bsn_Libro = new BsnClsBook();
            EntClsBook bookFind = bsn_Libro.checkBook(textTitle.Text);
            if (bookFind.Code == null)
            {
                if (change1 == 1)
                {

                    BsnClsAuthor bsn_author = new BsnClsAuthor();
                    bsn_author.insertAuthor(textNameAuth.Text, textLastName.Text, textNationality.Text);
                }
                if (change2 == 1)
                {
                    BsnClsEditorial bsn_editorial = new BsnClsEditorial();
                    bsn_editorial.insertEditorial(textNameEdit.Text, textCountry.Text, textCity.Text);
                }
                List<EntClsSearch> consulExist = new List<EntClsSearch>();
                BsnClsSearch bsn_search = new BsnClsSearch();
                consulExist = bsn_search.ForCodeBook(textCode.Text);
                if (consulExist.Count() == 0)
                {
                    //verificar que no se repita el isbn
                    consulExist = bsn_search.ForIsbnBook(textIsbn.Text);
                    if (consulExist.Count() == 0)
                    {
                        //verificar que no se repita el titulo                        
                        consulExist=bsn_search.ForNameInPartBook(textTitle.Text);
                        if(consulExist.Count()==0)
                        {                        
                            EntClsAuthor obj_Author = registerBook();
                            BsnClsWrite bsn_write = new BsnClsWrite();
                            bsn_write.insertWrite(obj_Author.Id, textCode.Text);
                            registerSucces();
                            clear();
                        } 
                        else
                        {
                            string script = @"<script type='text/javascript'>
                            alert('Ya existe este libro ingrese otro');
                            </script>";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
                        }
                    }
                    else 
                    {
                        string script = @"<script type='text/javascript'>
                    alert('Ya existe ese ISBN ingrese otro');
                    </script>";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
                    }
                }
                else 
                {
                    string script = @"<script type='text/javascript'>
                    alert('Ya existe ese codigo ingrese otro');
                    </script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
                }

                
            }
            else
            {
                registerFail();
            }            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else 
            {
                Calendar1.Visible = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            textDate.Text = Calendar1.SelectedDate.ToString("dd /MM /yyyy");
            Calendar1.Visible = false;
        }

        protected void buttonCheckAuthor_Click(object sender, EventArgs e)
        {

            BsnClsAuthor bsn_author = new BsnClsAuthor();
            EntClsAuthor authorFind = bsn_author.checkAuthor(textNameAuth.Text, textLastName.Text);
            if (authorFind.Name == null)
            {
                textNationality.Enabled = true;
                change1 = 1;
            }
            else
            {
                textNameAuth.Text = authorFind.Name;
                textLastName.Text = authorFind.LastName;
                textNationality.Text = authorFind.Nationality;
            }
            buttonCheckAuthor.Enabled = false;
        }
   }

}