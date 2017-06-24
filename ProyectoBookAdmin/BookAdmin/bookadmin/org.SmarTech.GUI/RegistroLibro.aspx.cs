using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookAdmin.org.SmarTech.entities;
using BookAdmin.org.SmarTech.Controller;
using BookAdmin.org.SmarTech.Bussines;


namespace BookAdmin.org.SmarTech.GUI
{
    public partial class RegistroLibro : System.Web.UI.Page
    {
        public static int cambio1 = 0;
        public static int cambio2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDropDownList();
                ddlCategoria.AutoPostBack = true;
            }
        }

        private void loadDropDownList()
        {
            BsCategoria ngCategoria = new BsCategoria();
            ddlCategoria.DataSource = ngCategoria.listarCategoria();
            ddlCategoria.DataValueField = "ID";
            ddlCategoria.DataTextField = "NOMBRE";
            ddlCategoria.DataBind();
        }


        protected void ddlCategoria_TextChanged(object sender, EventArgs e)
        {
            BsCategoria ngCategoria = new BsCategoria();
            //ClsCategoria objCategoria = ngCategoria.listarCategoriaid(itemSelec);            
        }

        protected void buttonVeriAutor_Click(object sender, EventArgs e)
        {

            BsAutor dtautor = new BsAutor();
            ClsAutor autorEnc = dtautor.verificarAutor(textNomAut.Text, textApellido.Text);
            if (autorEnc.Nombre == null)
            {
                textNacionalidad.Enabled = true;
                cambio1 = 1;
            }
            else
            {
                textNomAut.Text = autorEnc.Nombre;
                textApellido.Text = autorEnc.Apellido;
                textNacionalidad.Text = autorEnc.Nacionalidad;
            }



        }

        protected void buttonVeriEditorial_Click(object sender, EventArgs e)
        {
            DtEditorial dteditorial = new DtEditorial();
            ClsEditorial editEnc = dteditorial.VerificarEditorial(textNomEdit.Text);
            if (editEnc.Nombre == null)
            {
                textCiudad.Enabled = true;
                textPais.Enabled = true;
                cambio2 = 1;
            }
            else
            {
                textNomEdit.Text = editEnc.Nombre;
                textPais.Text = editEnc.Pais;
                textCiudad.Text = editEnc.Ciudad;
            }

        }

        protected void buttonRegistrar_Click(object sender, EventArgs e)
        {
            BsLibro dtLibro = new BsLibro();
            ClsLibro LibroEnc = dtLibro.verificarLibro(textTitulo.Text);            
            if (LibroEnc.Codigo == null)
            {
                if (cambio1 == 1)
                {

                    BsAutor autor = new BsAutor();
                    autor.insertarAutor(textNomAut.Text, textApellido.Text, textNacionalidad.Text);
                }
                if (cambio2 == 1)
                {
                    BsEditorial editorial = new BsEditorial();
                    editorial.insertarEditorial(textNomEdit.Text, textPais.Text, textCiudad.Text);
                }
                ClsAutor objAutor= registroLibro();
                BsEscribir dtEscribir = new BsEscribir();
                dtEscribir.insertarEscribir(objAutor.Id, textCodigo.Text);
                registroExi();
            }
            else
            {
                registroFall();
            }
            clear();
        }

        protected void clear() 
        {
            textNomAut.Text = "";
            textNomEdit.Text = "";
            textFech.Text = "";
            textCiudad.Text = "";
            textCodigo.Text = "";
            textIsbn.Text = "";
            textNacionalidad.Text = "";
            textPais.Text = "";
            textApellido.Text = "";
            textCodigo.Text = "";
            textStock.Text = "";
            textTitulo.Text = "";
        }
        protected void registroExi() 
        {
            string script = @"<script type='text/javascript'>
                    alert('Libro registrado exitosamente!');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }
        protected void registroFall() 
        {
            string script = @"<script type='text/javascript'>
                    alert('el libro ya existe en el sistema!');
                    </script>";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }
        protected ClsAutor registroLibro() 
        {
            int itemSelec = (ddlCategoria.SelectedIndex) + 1;
            BsLibro bsbook = new BsLibro();
            BsEditorial dtedit = new BsEditorial();
            ClsEditorial edito = dtedit.verificarEditorial(textNomEdit.Text);
            int idedit = edito.Id;
            int stock = Convert.ToInt16(textStock.Text);
            ClsAutor objAutor = new ClsAutor();
            BsAutor dtAutor = new BsAutor();
            objAutor = dtAutor.verificarAutor(textNomAut.Text, textApellido.Text);
            bsbook.insertarLibro(textTitulo.Text, textCodigo.Text, textIsbn.Text, textFech.Text, stock, itemSelec, idedit, "Disponible", 1);
            return objAutor;
        }
    }
}