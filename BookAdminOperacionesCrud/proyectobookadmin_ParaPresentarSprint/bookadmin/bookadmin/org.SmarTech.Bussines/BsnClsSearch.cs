using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsSearch
    {
        public List<EntClsSearch> ForAuthorCompleteName(string name, string lastName)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.forNameAutorComplete(name,lastName);
        }

        public List<EntClsSearch> ForCodeBook(string code)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.forCodeBook(code);
        }

        public List<EntClsSearch> ForIsbnBook(string isbn)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.forIsbnBook(isbn);
        }
        public List<EntClsSearch> ForNameInPartBook(string name)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.forNameInPartBook(name);
        }

        public List<EntClsSearch> ForOnlyNameAuthor(string name)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.forOnlyNameAutor(name);
        }

        public List<EntClsSearch> ForNameEditorial(string name)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.forNameEditorial(name);
        }

        public List<EntClsSearch> ForCategoryBook(string name)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.ForCategoryBook(name);
        }

        public List<EntClsSearch> ForOnlyLastnameAuthor(string lastName)
        {
            CntClsSearch cnt_search = new CntClsSearch();
            return cnt_search.forOnlyLastNameAutor(lastName);
        }

        public string returnName(string completeText)
        {
            string name;
            char limit = ' ';
            string[] separation = completeText.Split(limit);
            char sign = '%';
            name = sign + separation[0] + sign;
            return name;

        }
        public string returnLastName(string completeText)
        {
            string lastName;
            char limit = ' ';
            string[] separation = completeText.Split(limit);
            if (separation.Count() == 1)
            {
                lastName = "no existe";
            }
            else 
            {
                char sign = '%';
                lastName = sign + separation[1] + sign;
                return lastName;
            }

            return lastName;
        }

    }
}