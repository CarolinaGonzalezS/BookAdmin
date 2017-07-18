using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsBook
    {
        #region Attributes

        private string code;
        private string isbn;
        private string name;
        private string datePublish;
        private int idEdit;
        private int idCateg;
        private int idAdmin;
        private string stateB;
        private int stock;
        private int idUser;
        
        #endregion

        #region setter and getter

        public int IdUser
        {
          get { return idUser; }
          set { idUser = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string DatePublish
        {
            get { return datePublish; }
            set { datePublish = value; }
        }
        public int IdEdit
        {
            get { return idEdit; }
            set { idEdit = value; }
        }
        public int IdCateg
        {
            get { return idCateg; }
            set { idCateg = value; }
        }
        public int IdAdmin
        {
            get { return idAdmin; }
            set { idAdmin = value; }
        }
        public string StateB
        {
            get { return stateB; }
            set { stateB = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        #endregion

        public EntClsBook(string code, string isbn, string name, string datePublish, int idEdit, int idCateg, int idAdmin, string stateB, int stock) 
        {
            this.code = code;
            this.isbn=isbn;
            this.name=name;
            this.datePublish = datePublish;
            this.idEdit = idEdit;
            this.idCateg = idCateg;
            this.idAdmin = idAdmin;
            this.stateB = stateB;
            this.stock = stock;
        }
        public EntClsBook() 
        {

        }

        public EntClsBook(string name)
        {
            this.name = name;
        }
        
        public EntClsBook(int idUser, string code, string isbn, string name, string datePublish, int idEdit, int idCateg, string stateB, int stock, int idAdmin)
        {
            this.idUser=idUser;
            this.code = code;
            this.isbn = isbn;
            this.name = name;
            this.datePublish = datePublish;
            this.idEdit = idEdit;
            this.idCateg = idCateg;
            this.idAdmin = idAdmin;
            this.stateB = stateB;
            this.stock = stock;
        }


        public EntClsBook(string name, string code, int stock, string stateB)
        {
            this.name = name;
            this.code = code;
            this.stock = stock;
            this.stateB = stateB;

        }

    }
}