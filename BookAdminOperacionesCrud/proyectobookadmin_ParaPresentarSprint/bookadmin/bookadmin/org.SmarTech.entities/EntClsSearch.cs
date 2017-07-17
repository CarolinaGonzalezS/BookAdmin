using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsSearch
    {
        #region Attributes
        private string code;
        private string author;
        private string lastNameAuthor;
        private string editorial;
        private string state;
        private int stock;
        private string book;        
        #endregion

        #region setter and getter

        public string Code
        {
            get { return code; }
            set { code = value; }
        }        
        public string Book
        {
            get { return book; }
            set { book = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }        
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string LastNameAuthor
        {
            get { return lastNameAuthor; }
            set { lastNameAuthor = value; }
        }
        
        #endregion

        public EntClsSearch() 
        {

        }

        public EntClsSearch(string code,string book, string state, int stock, string editorial, string author, string lastNameAuthor)
        {      
            this.code=code;     
            this.book = book;
            this.state = state;
            this.stock = stock;
            this.editorial = editorial;
            this.author = author;
            this.lastNameAuthor = lastNameAuthor;            
        }
        
    }
}