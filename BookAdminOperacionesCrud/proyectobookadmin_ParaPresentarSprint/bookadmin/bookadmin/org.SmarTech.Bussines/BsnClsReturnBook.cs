using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsReturnBook
    {
        public List<EntClsReturnBook> ReturnBook(int id)
        { 
            CntClsReturnBook cnt_returnbook=new CntClsReturnBook();
            return cnt_returnbook.ReturnBook(id);

        }
    }
}