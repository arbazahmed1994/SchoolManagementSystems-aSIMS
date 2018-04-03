using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Common
{
    public class Connection
    {
        public static Database GetDatabase()
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            Database db = factory.Create("DefaultConnection");
            return db;
        }
    }
}