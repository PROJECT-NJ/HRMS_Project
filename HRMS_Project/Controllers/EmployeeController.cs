using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HRMS_Project.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Home()
        {
            return View("Home2");
        }

        public IActionResult Leave()
        {
            return View();
        }

        public IActionResult OT()
        {
            return View();
        }

        public IActionResult TimeSheet()
        {
            return View();
        }

        public IActionResult TimeVerification()
        {
            return View();
        }
    }
}