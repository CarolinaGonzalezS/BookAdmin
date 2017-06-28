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
    public partial class ResultadoBusqueda : System.Web.UI.Page
    {
        int selection = 0;
        string searchvalue=" ";
        protected void Page_Load(object sender, EventArgs e)
        {            
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
                    result=queryForBookName();
                    if(result==null)
                    {
                        result = queryForOnlyLastNameAuthor();
                        if (result == null)
                        {
                            result = queryForOnlyNameAuthor();
                            if (result == null)
                            {                                
                                EntClsSearch onlyOneAnsw = new EntClsSearch();
                                onlyOneAnsw = queryForIsbnName();
                                if (onlyOneAnsw == null)
                                {                                    
                                    onlyOneAnsw = queryForCodeName();
                                    if (onlyOneAnsw == null)
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
                                        Response.Write(onlyOneAnsw.Book);
                                        Response.Write(onlyOneAnsw.State);
                                        Response.Write(onlyOneAnsw.Stock);
                                        Response.Write(onlyOneAnsw.Editorial);
                                        Response.Write(onlyOneAnsw.Author);
                                        Response.Write(onlyOneAnsw.LastNameAuthor);
                                    }

                                }
                                else
                                {
                                    Response.Write(onlyOneAnsw.Book);
                                    Response.Write(onlyOneAnsw.State);
                                    Response.Write(onlyOneAnsw.Stock);
                                    Response.Write(onlyOneAnsw.Editorial);
                                    Response.Write(onlyOneAnsw.Author);
                                    Response.Write(onlyOneAnsw.LastNameAuthor);                                    
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
            if(resultList.Count()==0)
            {                
                return null;
            }
            return resultList;
        }

        public List<EntClsSearch> queryForBookName()
        {
            char signo='%';
            List<EntClsSearch> resultList = new List<EntClsSearch>();            
            BsnClsSearch bsn_search = new BsnClsSearch();
            string searchN=signo+searchvalue+signo;
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

        public EntClsSearch queryForCodeName()
        {
            EntClsSearch resultQuery = new EntClsSearch();
            BsnClsSearch bsn_search = new BsnClsSearch();            
            resultQuery = bsn_search.ForCodeBook(searchvalue);
            if (resultQuery.Book==null)
            {
                return null;
            }
            return resultQuery;
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



        public EntClsSearch queryForIsbnName()
        {
            EntClsSearch resultQuery = new EntClsSearch();
            BsnClsSearch bsn_search = new BsnClsSearch();
            resultQuery = bsn_search.ForIsbnBook(searchvalue);
            if (resultQuery.Book == null)
            {
                return null;
            }
            return resultQuery;
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