using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookAdmin.org.SmarTech.GUI
{
    public partial class RegistroPrestamo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

     
        protected void rblLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblLoan.SelectedItem.Text == "Nuevo")
            {
                Response.Redirect("RegistroCliente.aspx");
            }
            else
            {            
                textName.Enabled = true;
                textPhone.Enabled = true;
                textEmail.Enabled = true;
                btnNextBook.Enabled = true;
            }
        }

        
    }
}