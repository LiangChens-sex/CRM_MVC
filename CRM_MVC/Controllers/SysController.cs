using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_MVC.Common;
using CRM_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CRM_MVC.Controllers
{
    public class SysController : Controller
    {
        #region 销售机会
        public IActionResult SaleChance()
        {
            //控制器项视图弹窗方式
            Response.WriteAsync("<script>alert('dd');location.href='/Employee/login'</script>");
            return View();
        }
        #endregion

        #region 菜单信息
        public IActionResult MenuInfo()
        {
            //APIClient apiClient = new APIClient();
            //string json = Encoding.UTF8.GetString(HttpContext.Session.Get("user"));
            //EmployeeInfo em = JsonConvert.DeserializeObject<EmployeeInfo>(json);
            //string result = APIClient.GetApiResult("get", "api/baseinfo/getmenu/" + em.EId);
            //List<MenuInfo> list = JsonConvert.DeserializeObject<List<MenuInfo>>(result);
            //ViewBag.menu = list;
            return View();
        }
        #endregion

        public IActionResult VueShow()
        {
            return View();

        }
        public IActionResult VueTest()
        {
            return View();

        }

        public IActionResult VueAdd()
        {
            return View();

        }
        public IActionResult AddMenu()
        {
            return View();

        }
        public IActionResult Employee()
        {
            return View();

        }

    }
}