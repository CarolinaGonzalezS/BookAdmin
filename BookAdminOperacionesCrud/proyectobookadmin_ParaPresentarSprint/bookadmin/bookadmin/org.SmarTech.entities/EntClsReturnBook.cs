using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsReturnBook
    {
        #region Attributes

        
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
        private string nameB;

        public string NameB
        {
            get { return nameB; }
            set { nameB = value; }
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

        public EntClsReturnBook(string identificationCard, string name,string lastName,string nameB,string isbn) 
        {
           
            this.identificationCard = identificationCard;
            this.name = name;
            this.lastName = lastName;
            this.nameB = nameB;
            this.isbn = isbn;
        }

        #endregion
    }
}