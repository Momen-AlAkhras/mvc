using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication13.Controllers
{
    public class MomenController : Controller
    {
        // GET: Momen
        public string  Name()
        {
            return "Name";
        }
        public string Age()
        {
            return "18";

        }
        public string Hobbies()
        {
            return "gaming";
        }
        public string Position()
        {
            return "Software Devloper";
        }
    }
}