﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsEditorial
    {
        public int insertEditorial(string name, string country, string city)
        {
            CntClsEditorial cnt_edit = new CntClsEditorial();
            return cnt_edit.insertEditorial(name,country,city);
        }
        public EntClsEditorial checkEditorial(string name)
        {
            CntClsEditorial cnt_edit = new CntClsEditorial();
            return cnt_edit.CheckEditorial(name);
        }
    }
}