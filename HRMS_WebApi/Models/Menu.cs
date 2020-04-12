using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_WebApi.Models
{
    public class Menu
    {
        public string MenuID { get; set; }
        public string MenuGroup { get; set; }
        public string MenuNameEng { get; set; }
        public string MenuNameTh { get; set; }
        public string ControllerID { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public IList<RoleMenu> RoleMenu { get; set; }
    }
}
