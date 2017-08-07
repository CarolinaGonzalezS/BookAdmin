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
        public List<EntClsAuthor> createListOfAuthor()
        {
            List<EntClsAuthor> authors = AuthorList();
            List<EntClsAuthor> authorForSelec = new List<EntClsAuthor>();
            foreach (EntClsAuthor author in authors)
            {
                author.Name = author.Name + ' ' + author.LastName;
                authorForSelec.Add(author);
            }
            return authorForSelec;
        }
        public string returnName(string completeName)
        {
            string name;
            char limit = ' ';
            string[] separation = completeName.Split(limit);
            name = separation[0];
            return name;
        }
    }
}