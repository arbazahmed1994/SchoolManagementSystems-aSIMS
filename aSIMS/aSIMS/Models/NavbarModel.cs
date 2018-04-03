using aSIMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Models
{
    public class Navbar
    {
        public IEnumerable<NavbarItem> NavbarTop()
        {
            var navRepos = new NavbarRepository();
            return navRepos.Get();
        }
    }

    public class NavbarItem : BaseModel<NavbarItem>
    {
        public int MenuID { get; set; }
        public string LinkText { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Icon { get; set; }
        public int ParentID { get; set; }
        public int IsParent { get; set; }
        public int ShowInMenu { get; set; }
        public int SequenceNumber { get; set; }
    }
}