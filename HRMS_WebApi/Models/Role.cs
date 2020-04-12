using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_WebApi.Models
{
    public class Role
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public IList<RoleMenu> RoleMenu { get; set; }
    }
}
