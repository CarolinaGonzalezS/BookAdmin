﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsWrite
    {
        public int insertWrite(int id, string code)
        {
            CntClsWrite Cnt_write = new CntClsWrite();
            return Cnt_write.insertWrite(id, code);
        }
    }
}