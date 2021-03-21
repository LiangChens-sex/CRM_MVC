using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_MVC.Common;
using CRM_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CRM_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private  IConfiguration _configuration;

        public EmployeeController(IConfiguration configuration) 
        {
            this._configuration = configuration;
        }

      
        private static string token;
        #region 员工登录
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string pwd)
        {
            APIClient apiClient = new APIClient(_configuration);


            string url = _configuration["apiUrl"];
            ViewBag.url = url;


            string json = apiClient.GetApiResult("get", $"api/baseinfo/login?name={username}&pwd={pwd}");

            if (!string.IsNullOrEmpty(json))
            {
                JObject obj = JObject.Parse(json);
                string user = obj["emp"].ToString();
                token = obj["token"].ToString();

                HttpContext.Session.SetString("user", user);
                //HttpContext.Session.SetString("token", token);
                return RedirectToAction("Index");
            }

            return View();
        }
        #endregion

        #region 系统主界面
        public IActionResult Index()
        {
            APIClient apiClient = new APIClient(_configuration);

            string json = Encoding.UTF8.GetString(HttpContext.Session.Get("user"));
            EmployeeInfo em = JsonConvert.DeserializeObject<EmployeeInfo>(json);
            ViewBag.em = em;
            string result = apiClient.GetApiResult("get", "api/baseinfo/getmenu/" + em.EId,null, token);
            List<MenuInfo> list = JsonConvert.DeserializeObject<List<MenuInfo>>(result);
            ViewBag.menu = list;
            ViewBag.pmenu = list.Where(m => m.PId == 0).ToList();

            em.EName += "888";
            string upt = apiClient.GetApiResult("put", "api/baseinfo/UptEmp", em, token);
            ////string add = APIClient.GetApiResult("post", "/api/baseinfo/AddEMp/", em);
            //if (string.IsNullOrEmpty(upt))
            //{

            //}
            return View();
        }
        #endregion
    }


}