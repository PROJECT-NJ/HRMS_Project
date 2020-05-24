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
using Microsoft.Extensions.Caching.Memory;
using HRMS_Project.Function;
using System.Reflection;
using System.Collections;
using HRMS_Project.Models.Cache;

namespace HRMS_Project.Controllers
{

    public class LoginController : Controller
    {
        private readonly AppSettingsViewModel _appSettings;
        private readonly IMemoryCache _cache;
        public LoginController(IOptions<AppSettingsViewModel> appSettings, IMemoryCache cache)
        {
            _appSettings = appSettings.Value;
            _cache = cache;
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
            try
            {
                Cache.CreateCache(_appSettings,  _cache,  "test", "test_user");

                var collection = typeof(MemoryCache).GetProperty("EntriesCollection", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(_cache) as ICollection;
                foreach (var item in collection)
                {

                        string test =  item.GetType().GetProperty("Key").GetValue(item).ToString();

                }

                    var dataInCache = _cache.Get<List<CacheModel>>("test");

                _cache.Remove("test");

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
    }
}