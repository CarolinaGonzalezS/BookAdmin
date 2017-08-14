using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsCustomer
    {
        #region Attributes
        private string identificationCard;
        private string name;
        private string lastname;
        private string phone;
        private string celphone;
        private string addres;        
        private string mail;

        #endregion

        #region setter and getter

        public string Cedula
        {
            get { return identificationCard; }
            set { identificationCard = value; }
        }
        public string Nombre
        {
            get { return name; }
            set { name = value; }
        }
        public string Apellido
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Telefono
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Celular
        {
            get { return celphone; }
            set { celphone = value; }
        }
        public string Direccion
        {
            get { return addres; }
            set { addres = value; }
        }
        public string Email
        {
            get { return mail; }
            set { mail = value; }
        }

        #endregion
        public EntClsCustomer() 
        {
        }
        public EntClsCustomer(string identificationCard, string name, string lastname, string phone, string celphone, string addres, string mail)
        {
            this.identificationCard = identificationCard;
            this.name = name;
            this.lastname = lastname;
            this.phone = phone;
            this.celphone = celphone;
            this.addres = addres;
            this.mail = mail;
        }
    }
}