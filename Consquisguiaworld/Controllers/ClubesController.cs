using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consquisguiaworld.Controllers
{
    public class ClubesController : Controller
    {
        // GET: Clubes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Especialidades()
        {
            return View();
        }
    }
}