using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsAdministrator
    {
#region Attributes
        private int id;
        private string name;
        private string passwordA;
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
        
        public string PasswordA
        {
          get { return passwordA; }
          set { passwordA = value; }
        }
#endregion

        public EntClsAdministrator(string name, string passwordA) 
        {            
            this.name=name;
            this.passwordA=passwordA;
        }
        public EntClsAdministrator() { }

    }    
}