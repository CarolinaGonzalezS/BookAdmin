using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsCustomer
    {
        public BsnClsCustomer(){}
        public int RegisterCustomer(string identificationCard, string name, string lastname, string phone, string celphone, string addres, string mail) 
        {
            
            CntClsCustomer cnt_clscustomer = new CntClsCustomer();
            return cnt_clscustomer.registerCustomer(identificationCard, name, lastname, phone, celphone, addres, mail);
        }
        public EntClsCustomer checkCustomer(string identificationCard)
        {
            CntClsCustomer cnt_customer = new CntClsCustomer();
            return cnt_customer.CheckCustomer(identificationCard);
        }

        public EntClsCustomer CustomerSearch(string identificationCard)
        {
            CntClsCustomer cnt_customer = new CntClsCustomer();
            return cnt_customer.CustomerSearch(identificationCard);
        }
    }
}