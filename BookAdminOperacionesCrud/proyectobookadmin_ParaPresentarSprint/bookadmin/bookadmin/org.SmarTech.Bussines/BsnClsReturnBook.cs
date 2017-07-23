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
        public EntClsReturnBook ReturnBook(int id)
        { 
            CntClsReturnBook cnt_returnbook=new CntClsReturnBook();
            return cnt_returnbook.ReturnBook(id);

        }

        public int UpdateStock(int stockPresent)
        {
            int newStock = stockPresent + 1;
            return newStock;
        }

        public int UpdateStockBook(string code, int stock){     
            CntClsReturnBook cnt_returnBook= new CntClsReturnBook();
            return cnt_returnBook.UpdateStockBook(code,stock);
        }

        public int UpdateStateLoan(int id){     
            CntClsReturnBook cnt_returnBook= new CntClsReturnBook();
            return cnt_returnBook.UpdateStateLoan(id);
        }

        public EntClsSearch searchBook(string name) 
        {
            CntClsReturnBook cnt_returnBook= new CntClsReturnBook();
            return cnt_returnBook.searchBook(name);
        }
    }
}