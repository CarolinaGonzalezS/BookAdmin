using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsFine
    {
        public EntClsLoan fineLoan(int id)
        {
            CntClsLoan cnt_loan = new CntClsLoan();
            return cnt_loan.searchLoan(id);
        }

        public int insertFine(double value, string descriptionF)
        {
            CntClsFine cnt_fine = new CntClsFine();
            return cnt_fine.insertFine(value, descriptionF);
        }

        public int insertFineCustomer(string identificationCard, int id, string dateF)
        {
            CntClsFine cnt_fine = new CntClsFine();
            return cnt_fine.insertFineCustomer(identificationCard, id, dateF);
        }

    }
}