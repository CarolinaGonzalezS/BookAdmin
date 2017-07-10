using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsEditorial
    {
        #region Attributes

        private int id;
        private string name;
        private string country;
        private string city;

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

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        #endregion

        public EntClsEditorial(int id, string name, string country, string city) 
        {
            this.id = id;
            this.name = name;
            this.country = country;
            this.city = city;
        }
        public EntClsEditorial(string name, string country, string city)
        {
            this.name = name;
            this.country = country;
            this.city = city;
        }
        public EntClsEditorial(string name)
        {
            this.name = name;
        }

        public EntClsEditorial()
        {
        }

    }
}