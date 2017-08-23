using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterExample3
{
    public class TestExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {

            if (!filterContext.ExceptionHandled && filterContext.Exception is NullReferenceException)
            {
                filterContext.Result = new RedirectResult("~/HtmlPage1.html");
                filterContext.ExceptionHandled = true;
            }
            //throw new NotImplementedException();
        }
    }
}