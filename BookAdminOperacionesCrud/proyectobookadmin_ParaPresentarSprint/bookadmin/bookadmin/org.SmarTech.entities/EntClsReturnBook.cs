using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsReturnBook
    {
        #region Attributes
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private string identificationCard;

        public string IdentificationCard
        {
            get { return identificationCard; }
            set { identificationCard = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string nameBook;

        public string NameBook
        {
            get { return nameBook; }
            set { nameBook = value; }
        }
        private string isbn;

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        #endregion

        #region contructores
        public EntClsReturnBook() { }

        public EntClsReturnBook(int id, string identificationCard, string name, string lastName, string nameBook, string isbn) 
        {
            this.id = id;
            this.identificationCard = identificationCard;
            this.name = name;
            this.lastName = lastName;
            this.nameBook = nameBook;
            this.isbn = isbn;
        }

        #endregion
    }
}