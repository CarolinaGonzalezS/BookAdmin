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
    public partial class ResultCategorySearch : System.Web.UI.Page
    {
        string searchvalue = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }            
            searchvalue = Session["search"].ToString();
            Response.Write(searchvalue);
            List<EntClsSearch> searchCategory = new List<EntClsSearch>();
            BsnClsSearch bls_search = new BsnClsSearch();
            searchCategory = bls_search.ForCategoryBook(searchvalue);
            loadGrid(searchCategory);
        }

        private void loadGrid(List<EntClsSearch> extract)
        {
            grvResult.DataSource = extract;
            grvResult.DataBind();
        }
    }
}