using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMS_WebApi.Models
{
    public class Site
    {
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public int BillDay { get; set; }
        public string CustomerCode { get; set; }
        public string WelcomeMessage { get; set; }
        public string WarningMessage { get; set; }
        public string WarningTimes { get; set; }
        public int ExtendTime { get; set; }
        public int LoginLockTimes { get; set; }
    }
}
