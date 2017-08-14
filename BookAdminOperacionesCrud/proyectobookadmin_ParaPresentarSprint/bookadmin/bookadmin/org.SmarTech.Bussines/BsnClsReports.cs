using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsReports
    {
        public List<EntClsReports> BookReport()
        {
            CntClsReports cnt_bookreport = new CntClsReports();
            return cnt_bookreport.BookReport();
        }

        public List<EntClsCustomer> CustomerReport()
        {
            CntClsReports cnt_customerreport = new CntClsReports();
            return cnt_customerreport.CustomerReport();
        }

        public List<EntClsReportLoan> LoanReport()
        {
            CntClsReports cnt_customerreport = new CntClsReports();
            return cnt_customerreport.LoanReport();
        }

        public List<EntClsReportFine> FineReport()
        {
            CntClsReports cnt_customerreport = new CntClsReports();
            return cnt_customerreport.FineReport();
        }
    }
}