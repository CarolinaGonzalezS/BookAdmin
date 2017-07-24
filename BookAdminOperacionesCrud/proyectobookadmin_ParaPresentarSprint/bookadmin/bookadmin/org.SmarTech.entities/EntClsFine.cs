using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookAdmin.org.SmarTech.entities
{
    public class EntClsFine
    {
        #region Attributes

        private int id;
        private double value;
        private string descriptionF;
        private string identificationCard;
        private string dateF;

        #endregion

        #region Setters and Getters
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public string DescriptionF
        {
            get { return descriptionF; }
            set { descriptionF = value; }
        }

        public string IdentificationCard
        {
            get { return identificationCard; }
            set { identificationCard = value; }
        }

        public string DateF
        {
            get { return dateF; }
            set { dateF = value; }
        }

        #endregion

        #region Builders

        public EntClsFine()
        {
        }

        public EntClsFine(int id, double value, string descriptionF)
        {
            this.id = id;
            this.value = value;
            this.descriptionF = descriptionF;
        }

        public EntClsFine(double value, string descriptionF)
        {
            this.value = value;
            this.descriptionF = descriptionF;
        }

        public EntClsFine(string identificationCard, int id, string dateF)
        {
            this.identificationCard = identificationCard;
            this.id = id;
            this.dateF = dateF;
        }

        #endregion
    }
}