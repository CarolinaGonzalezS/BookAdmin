using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;


namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsAdministrator
    {
        public EntClsAdministrator Login(string name, string passwordA)
        {
            CntClsAdministrator Cnt_admin = new CntClsAdministrator();
            return Cnt_admin.Login(name, passwordA);
        }
    }
}