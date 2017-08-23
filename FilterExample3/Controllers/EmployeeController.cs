using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterExample3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [TestExceptionFilter]
        public ActionResult Index()
        {
            throw new NullReferenceException();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

    }
}