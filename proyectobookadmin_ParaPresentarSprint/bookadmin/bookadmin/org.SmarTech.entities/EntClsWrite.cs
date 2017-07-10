using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsWrite
    {
        #region Attributes

        private int idAuthor;
        private string bookCode;

        #endregion

        #region setter and getter

        public int IdAuthor
        {
            get { return idAuthor; }
            set { idAuthor = value; }
        }

        public string BookCode
        {
            get { return bookCode; }
            set { bookCode = value; }
        }
        #endregion
        
        public EntClsWrite() 
        {
        }
        public EntClsWrite(int idAuthor,string bookCode)
        {
            this.idAuthor = idAuthor;
            this.bookCode = bookCode;
        }
        public EntClsWrite(int idAuthor)
        {
            this.idAuthor = idAuthor;
        }
    }
}