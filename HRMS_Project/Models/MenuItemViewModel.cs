using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_Project.Models.MenuItem
{

    public class Detail_SideMenu_Node
    {
        public string Name { get; set; }
        public string ControlName { get; set; }
        public string ActionName { get; set; }

    }

    public class Detail_SideMenu
    {
        public string Name { get; set; }
        public List<Detail_SideMenu_Node> detail_sideMenu_node { get; set; }

    }

    public class MenuItemViewModel
    {

        public string name_side_menu { get; set; }
        public List<Detail_SideMenu> detail_sideMenu { get; set; }
    }


}
