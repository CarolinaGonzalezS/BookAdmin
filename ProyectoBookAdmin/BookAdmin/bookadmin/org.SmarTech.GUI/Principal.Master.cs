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
            string busqueda = textBuscar.Text;
            Session.Add("busca", busqueda);
            Response.Redirect("ResultadoBusqueda.aspx");  
        }
    }
}