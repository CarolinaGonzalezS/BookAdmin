using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Common;
using System.Data;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsLoan
    {
        #region Attributes

        private int id;
        private string dateLoan;
        private string dateLimit;
        private string identificationCard;
        private string code;
        private string stateL;

        #endregion

        #region Setters and Getters

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string DateLoan
        {
            get { return dateLoan; }
            set { dateLoan = value; }
        }

        public string DateLimit
        {
            get { return dateLimit; }
            set { dateLimit = value; }
        }

        public string IdentificationCard
        {
            get { return identificationCard; }
            set { identificationCard = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string StateL
        {
            get { return stateL; }
            set { stateL = value; }
        }

        #endregion

        #region Builders

        public EntClsLoan() 
        { 
        }

        public EntClsLoan(int id, string dateLoan, string dateLimit, string identificationCard, string code, string stateL) {
            this.id = id;
            this.dateLoan = dateLoan;
            this.dateLimit = dateLimit;
            this.identificationCard = identificationCard;
            this.code = code;
            this.stateL = stateL;
        }

        public EntClsLoan(int id, string stateL) {
            this.id = id;
            this.stateL = stateL;
        }
        #endregion 
    }
}