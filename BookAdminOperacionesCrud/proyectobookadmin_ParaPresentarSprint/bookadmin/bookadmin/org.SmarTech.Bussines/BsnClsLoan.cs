using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Common;
using System.Data;
using BookAdmin.org.SmarTech.entities;
using BookAdmin.org.SmarTech.controllers;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsLoan
    {
        public int insertLoan(int id, string dateLoan,string dateLimit,string identificationCard, string code) { 
        CntClsLoan cnt_loan= new CntClsLoan();
        return cnt_loan.insertLoan(id,dateLoan,dateLimit,identificationCard,code);
        }
    }
}