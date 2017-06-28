using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookAdmin.org.SmarTech.controllers;
using BookAdmin.org.SmarTech.entities;

namespace BookAdmin.org.SmarTech.Bussines
{
    public class BsnClsCategory
    {
        public List<EntClsCategory> listCategory()
        {
            CntClsCategory cnt_category = new CntClsCategory();
            return cnt_category.listCategory();
        }
        public EntClsCategory listCategoryForid(int id)
        {
            CntClsCategory cnt_category = new CntClsCategory();
            return cnt_category.listCategoryForid(id);
        }
    }
}