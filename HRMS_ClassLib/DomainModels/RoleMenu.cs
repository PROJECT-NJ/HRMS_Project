using System;

namespace HRMS_ClassLib.DomainModels
{
    public class RoleMenu
    {
        public Role Role { get; set; }
        public string RoleId { get; set; }
        public Menu Menu { get; set; }
        public string MenuId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
