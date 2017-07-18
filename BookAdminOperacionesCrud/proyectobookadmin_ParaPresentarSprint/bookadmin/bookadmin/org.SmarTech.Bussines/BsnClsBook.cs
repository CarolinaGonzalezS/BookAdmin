using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsBook
    {
        public int insertBook(string name, string code, string isbn, string datePublish, int stock, int idCateg, int idEdit, string state, int idAdmin)
        {
            CntClsBook cnt_book = new CntClsBook();
            return cnt_book.insertBook(name, code, isbn, datePublish, stock, idCateg, idEdit, state, idAdmin);
        }

        public EntClsBook checkBook(string name)
        {
            CntClsBook dtLibro = new CntClsBook();
            return dtLibro.CheckBook(name);
        }

        public int updateBook(string code, string isbn, string name, string datePublish, int idEdit, int idCateg, string stateB, int stock)
        {
            CntClsBook cnt_book = new CntClsBook();
            return cnt_book.updateBook(code, isbn, name, datePublish, idEdit, idCateg, stateB, stock);
        }

        public int deleteBook(string code)
        {
            CntClsBook cnt_book = new CntClsBook();
            return cnt_book.deleteBook(code);
        }
        public List<EntClsBook> listBook() 
        {
            CntClsBook cnt_book = new CntClsBook();
            return cnt_book.listBook();
        }
        public EntClsBook SearchBookForCode(string code)
        {
            CntClsBook cnt_book = new CntClsBook();
            return cnt_book.SearchBookForCode(code);
        }

        public EntClsBook checkBook2(string name)
        {
            CntClsBook dtLibro = new CntClsBook();
            return dtLibro.CheckBook2(name);
        }


    }
}