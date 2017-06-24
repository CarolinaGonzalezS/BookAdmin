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
    public partial class ResultadoBusqueda : System.Web.UI.Page
    {
        string valorBusq=" ";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["busca"].ToString() == "")
            {
                Response.Redirect("principal.aspx");
            }
            else 
            {
                valorBusq = Session["busca"].ToString();
                List<ClsBusqueda> resultado = Consulta();
                if (resultado == null)
                {
                    errorMessage();
                    Response.Write("No existe registros");
                }
                else
                {
                    loadGrid(resultado);
                }
            }
           
        }

        public List<ClsBusqueda> Consulta() 
        {
            List<ClsBusqueda> resultadoList= new List<ClsBusqueda>();
            string nombre;
            string apellido;
            BsBusqueda bsBusqueda= new BsBusqueda();
            nombre=bsBusqueda.retornarNombre(valorBusq);
            apellido=bsBusqueda.retornarApellido(valorBusq);
            resultadoList=bsBusqueda.BusquedaPorAutorCompleto(nombre,apellido);                        
            if(resultadoList.Count()==0)
            {                
                return null;
            }
            return resultadoList;
        }

         private void loadGrid(List<ClsBusqueda> extraer)
        {            
            grvResult.DataSource = extraer;
            grvResult.DataBind();            
        }

         protected void errorMessage()
        {
            string script = @"<script type='text/javascript'>
                    alert('No existe ningun Libro');
                    </script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "BookAdmin", script, false);
        }

    }
}