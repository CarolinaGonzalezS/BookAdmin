using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsReportLoan
    {
        #region Attributes
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private string identificationCard;

        public string Cedula
        {
            get { return identificationCard; }
            set { identificationCard = value; }
        }
        
        private string name;

        public string Nombre
        {
            get { return name; }
            set { name = value; }
        }
        private string lastName;

        public string Apellido
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string dateLoan;

        public string Fecha_Inicio
        {
            get { return dateLoan; }
            set { dateLoan = value; }
        }
        private string dateLimit;

        public string Fecha_Limite
        {
            get { return dateLimit; }
            set { dateLimit = value; }
        }
        private string code;

        public string Codigo
        {
            get { return code; }
            set { code = value; }
        }
        private string nameBook;

        public string Libro
        {
            get { return nameBook; }
            set { nameBook = value; }
        }


        #endregion
        public EntClsReportLoan(string name, string lastName, string identificationCard, int id, string dateLoan, string dateLimit, string code, string nameBook)
        {
            this.name = name;
            this.lastName = lastName;
            this.identificationCard = identificationCard;
            this.id = id;
            this.dateLimit = dateLimit;
            this.dateLoan = dateLoan;
            this.code = code;
            this.nameBook = nameBook;
        }

        public EntClsReportLoan() 
        {

        }

    }
}