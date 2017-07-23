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
        private string identificationCard;
        private string name;
        private string lastName;
        private string nameBook;
        private string code;

        #endregion

        #region Setters and Getters
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string IdentificationCard
        {
            get { return identificationCard; }
            set { identificationCard = value; }
        }
       
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        
        public string NameBook
        {
            get { return nameBook; }
            set { nameBook = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        #endregion

        #region Builders
        
        public EntClsReturnBook()
        { 
        }

        public EntClsReturnBook(int id, string identificationCard, string name, string lastName, string nameBook, string code) 
        {
            this.id = id;
            this.identificationCard = identificationCard;
            this.name = name;
            this.lastName = lastName;
            this.nameBook = nameBook;
            this.code = code;
        }

        #endregion
    }
}