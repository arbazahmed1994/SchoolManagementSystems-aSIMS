using aSIMS.Common;
using aSIMS.Constants;
using aSIMS.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aSIMS.Repository
{
    public class NavbarRepository : Controller
    {
        public IEnumerable<NavbarItem> Get()
        {
            Database db = Connection.GetDatabase();

            int RoleID = BasicContants.RoleID;

            DataSet ds = db.ExecuteDataSet("GetNavigationMenu", RoleID);

            return ds.Tables[0].ConvertToList<NavbarItem>();
        }
    }
}