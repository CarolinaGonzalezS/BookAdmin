using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsWrite
    {
        public int insertWrite(int id, string code)
        {
            CntClsWrite Cnt_write = new CntClsWrite();
            return Cnt_write.insertWrite(id, code);
        }
        public int deleteWrite(int id, string code)
        {
            CntClsWrite Cnt_write = new CntClsWrite();
            return Cnt_write.deleteWrite(id, code);
        }

        public EntClsWrite listWriteForCode(string code)
        {
            CntClsWrite cnt_write = new CntClsWrite();
            return cnt_write.listWriteForCode(code);
        }

        public List<EntClsWrite> SearchBookForIdAuthor(int id)
        {
            CntClsWrite cnt_write = new CntClsWrite();
            return cnt_write.SearchBookForIdAuthor(id);
        }

        public EntClsWrite SearchAuthorOfBook(string code)
        {
            CntClsWrite cnt_write = new CntClsWrite();
            return cnt_write.SearchAuthorOfBook(code);
        }
    }
}