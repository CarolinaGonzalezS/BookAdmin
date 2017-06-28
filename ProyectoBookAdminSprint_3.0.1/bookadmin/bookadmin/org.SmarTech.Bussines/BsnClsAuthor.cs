using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;


namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsAuthor
    {
        public int insertAuthor(string name, string lastName, string nationality)
        {
            CntClsAuthor cnt_author = new CntClsAuthor();
            return cnt_author.insertAuthor(name,lastName,nationality);
        }
        public EntClsAuthor checkAuthor(string name, string lastName)
        {
            CntClsAuthor cnt_author = new CntClsAuthor();
            return cnt_author.CheckAuthor(name, lastName);
        }
    }
}