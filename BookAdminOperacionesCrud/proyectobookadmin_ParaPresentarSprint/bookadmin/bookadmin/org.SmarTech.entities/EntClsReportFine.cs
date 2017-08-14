using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsReportFine
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string descriptionF;

        public string Descripcion
        {
            get { return descriptionF; }
            set { descriptionF = value; }
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
        private decimal value;

        public decimal Valor
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public EntClsReportFine(int id, string descriptionF, string identificationCard, string name, string lastName, decimal value) 
        {
            this.id = id;
            this.descriptionF = descriptionF;
            this.identificationCard = identificationCard;
            this.name = name;
            this.lastName = lastName;
            this.value = value;
        }

    }
}