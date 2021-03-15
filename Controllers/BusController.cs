using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace EyeDoctor.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        public string Index(string fristname,string lastname)
        {
            return fristname + lastname;
        }
    }
}