using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS_ClassLib.DomainModels
{
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MenuID { get; set; }
        public string MenuGroup { get; set; }
        public string MenuNameEng { get; set; }
        public string MenuNameTh { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public IList<RoleMenu> RoleMenu { get; set; }
    }
}
