using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Naytto1.Controllers
{
    public class ValikkoController : Controller
    {
        // GET: Valikko
        public ActionResult Päävalikko()
        {
            return View();
        }

        public ActionResult Tuotteet()
        {
            return View();
        }

        public ActionResult Tilaus()
        {
            return View();
        }

        public ActionResult Tilausrvi()
        {
            return View();
        }

        public ActionResult Asiakkaat()
        {
            return View();
        }

        public ActionResult Henkilöstö()
        {
            return View();
        }
    }

}