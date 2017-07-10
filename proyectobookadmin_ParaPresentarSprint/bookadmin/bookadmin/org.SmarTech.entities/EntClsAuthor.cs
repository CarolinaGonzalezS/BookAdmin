using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsAuthor
    {
        #region Attributes

        private int id;
        private string name;
        private string lastName;
        private string nationality;

        #endregion

        #region setter and getter
        public int Id
        {
            get { return id; }
            set { id = value; }
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

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        #endregion


        public EntClsAuthor(int id,string name, string lastName, string nationality)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.nationality = nationality;
        }
        public EntClsAuthor(string name, string lastName,string nationality)
        {
            this.name = name;
            this.lastName = lastName;
            this.nationality = nationality;
        }
        
        public EntClsAuthor() { }

    }
}