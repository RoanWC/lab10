using Lab10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab10.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using(var db = new Entities())
            {
                var contactQuery = (from Address in db.Addresses orderby Address.LastName, Address.FirstName select Address).ToList<Address>();
                return View(contactQuery);

            }
        }
    }
}