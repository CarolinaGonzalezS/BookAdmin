using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsCategory
    {
        #region Attributes

        private int id;
        private string name;
        private string description;

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
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        public EntClsCategory(int id, string name, string description) 
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public EntClsCategory() { }




    }
}