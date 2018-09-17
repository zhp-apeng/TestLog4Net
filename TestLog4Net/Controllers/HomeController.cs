using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestLog4Net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);//获取一个日志记录器
            //log4netHelper.Fatal(this.GetType(), "Fatal");                           //致命错误
            //log4netHelper.Error(this.GetType(), "Error", new Exception("error"));   //错误
            //log4netHelper.Warn(this.GetType(), "Warn");                             //禁告
            //log4netHelper.Info(this.GetType(), "Info");                             //信息
            //log4netHelper.Debug(this.GetType(), "Debug");                           //调试


            log.Fatal("info");
            log.Error("Error");
            log.Warn("Warn");
            log.Info("info");
            log.Debug("Debug");

            #region 添加测试2
            
            #endregion



            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
    }
}
