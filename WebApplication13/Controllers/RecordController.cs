using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication13.Controllers
{
    public class RecordController : Controller
    {
        // GET: Record
        public string GetImage()
        {
            return "<a href='Dwnload'><img src='../Images/R.jpg'></a>";
        }
        public void Dwnload()
        {
            var imgPath = Server.MapPath("../Images/R.jpg");
            Response.AddHeader("Content-Disposition", "attachment;filename=R.png");
            Response.WriteFile(imgPath);
            Response.End();
        }
        public string AboutUs()
        {
            return "Our company is very great";
        }
        public string ContactUs()
        {
            return "0778093323";
        }
    }
}