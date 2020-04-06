using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRMS_Project.Models.Login;
using HRMS_Project.Models.Settings;
using Microsoft.Extensions.Options;
using HRMS_Project.Function.WebApi;
using HRMS_Project.Models.MenuItem;

namespace HRMS_Project.Controllers
{

    public class LoginController : Controller
    {
        private readonly AppSettingsViewModel _appSettings;

        public LoginController(IOptions<AppSettingsViewModel> appSettings)
        {
            _appSettings = appSettings.Value;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        public IActionResult ProcessLogin([FromBody]Dataforlogin data)
        {          
            string message = "";
            try {

                string DataPost = Newtonsoft.Json.JsonConvert.SerializeObject(data);

                WebApi webapi = new WebApi();


                if (bool.Parse(webapi.PostWebApi(_appSettings.ServerWebApi, DataPost)))
                {
                  
                    message = "success";
                }
                else
                {
                    message = "fail";

                }
            }

            catch (Exception ex)
            {
                message = ex.Message;

            }       

            return Json(message);
         //   return Json(new { success = false, message = ex });
        }

        public ActionResult _Layout()
        {
            List<MenuItemViewModel> miVM = new List<MenuItemViewModel>();

            miVM.Add(new MenuItemViewModel { Link = "test1", LinkName = "test2" });

            return PartialView("SideMenu", miVM);
        }


        }
}