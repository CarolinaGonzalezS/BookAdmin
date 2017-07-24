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
            return cnt_author.insertAuthor(name, lastName, nationality);
        }
        public EntClsAuthor checkAuthor(string name, string lastName)
        {
            CntClsAuthor cnt_author = new CntClsAuthor();
            return cnt_author.CheckAuthor(name, lastName);
        }
        public List<EntClsAuthor> AuthorList()
        {
            CntClsAuthor cnt_author = new CntClsAuthor();
            return cnt_author.AuthorList();
        }

        public EntClsAuthor checkAuthorForId(int id)
        {
            CntClsAuthor cnt_author = new CntClsAuthor();
            return cnt_author.CheckAuthorForId(id);
        }
        public int updateAuthor(int id, string name, string lastName, string nationality)
        {
            CntClsAuthor cnt_author = new CntClsAuthor();
            return cnt_author.updateAuthor(id, name, lastName, nationality);
        }

        public int deleteAuthor(int id)
        {
            CntClsAuthor cnt_author = new CntClsAuthor();
            return cnt_author.deleteAuthor(id);
        }

    }
}