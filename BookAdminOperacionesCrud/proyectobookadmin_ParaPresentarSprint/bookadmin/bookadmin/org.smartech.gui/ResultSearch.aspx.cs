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
    public partial class ResultSearch : System.Web.UI.Page
    {        
        string searchvalue = " ";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }            

            if (Session["search"].ToString() == "")
            {
                Response.Redirect("principal.aspx");
            }
            else
            {
                searchvalue = Session["search"].ToString();
                List<EntClsSearch> result = new List<EntClsSearch>();
                result = queryForNameEditorial();
                if (result == null)
                {
                    result = queryForBookName();
                    if (result == null)
                    {
                        result = queryForOnlyLastNameAuthor();
                        if (result == null)
                        {
                            result = queryForOnlyNameAuthor();
                            if (result == null)
                            {                                
                                result = queryForIsbnName();
                                if (result == null)
                                {
                                    result = queryForCodeName();
                                    if (result == null)
                                    {
                                        result = queryForAuthorCompleteName();
                                        if (result == null)
                                        {
                                            errorMessage();
                                        }
                                        else
                                        {
                                            loadGrid(result);
                                        }
                                    }
                                    else
                                    {
                                        loadGrid(result);
                                    }

                                }
                                else
                                {
                                    loadGrid(result);
                                }
                            }
                            else
                            {
                                loadGrid(result);
                            }
                        }
                        else
                        {
                            loadGrid(result);
                        }
                    }
                    else
                    {
                        loadGrid(result);
                    }
                }
                else
                {
                    loadGrid(result);
                }
            }

        }

        public List<EntClsSearch> queryForAuthorCompleteName()
        {
            List<EntClsSearch> resultList = new List<EntClsSearch>();
            string name;
            string lastName;
            BsnClsSearch bsn_search = new BsnClsSearch();
            name = bsn_search.returnName(searchvalue);
            lastName = bsn_search.returnLastName(searchvalue);
            resultList = bsn_search.ForAuthorCompleteName(name, lastName);
            if (resultList.Count() == 0)
            {
                return null;
            }
            return resultList;
        }

        public List<EntClsSearch> queryForBookName()
        {
            char signo = '%';
            List<EntClsSearch> resultList = new List<EntClsSearch>();
            BsnClsSearch bsn_search = new BsnClsSearch();
            string searchN = signo + searchvalue + signo;
            resultList = bsn_search.ForNameInPartBook(searchN);
            if (resultList.Count() == 0)
            {
                return null;
            }
            return resultList;            
        }

        public List<EntClsSearch> queryForOnlyNameAuthor()
        {
            char signo = '%';
            List<EntClsSearch> resultList = new List<EntClsSearch>();
            BsnClsSearch bsn_search = new BsnClsSearch();
            string searchN = signo + searchvalue + signo;
            resultList = bsn_search.ForOnlyNameAuthor(searchN);
            if (resultList.Count() == 0)
            {
                return null;
            }
            return resultList;
        }

        public List<EntClsSearch> queryForOnlyLastNameAuthor()
        {
            char signo = '%';
            List<EntClsSearch> resultList = new List<EntClsSearch>();
            BsnClsSearch bsn_search = new BsnClsSearch();
            string searchN = signo + searchvalue + signo;
            resultList = bsn_search.ForOnlyLastnameAuthor(searchN);
            if (resultList.Count() == 0)
            {
                return null;
            }
            return resultList;
        }

        public List<EntClsSearch> queryForCodeName()
        {
            List<EntClsSearch> resultList = new List<EntClsSearch>();
            BsnClsSearch bsn_search = new BsnClsSearch();
            resultList = bsn_search.ForCodeBook(searchvalue);
            if (resultList.Count() == 0)
            {
                return null;
            }
            return resultList;
        }

        public List<EntClsSearch> queryForNameEditorial()
        {
            char signo = '%';
            List<EntClsSearch> resultList = new List<EntClsSearch>();
            BsnClsSearch bsn_search = new BsnClsSearch();
            string searchN = signo + searchvalue + signo;
            resultList = bsn_search.ForNameEditorial(searchN);
            if (resultList.Count() == 0)
            {
                return null;
            }
            return resultList;
        }



        public List<EntClsSearch> queryForIsbnName()
        {
            List<EntClsSearch> resultList = new List<EntClsSearch>();
            BsnClsSearch bsn_search = new BsnClsSearch();
            resultList = bsn_search.ForIsbnBook(searchvalue);
            if (resultList.Count() == 0)
            {
                return null;
            }
            return resultList;
        }

        private void loadGrid(List<EntClsSearch> extract)
        {
            grvResult.DataSource = extract;
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