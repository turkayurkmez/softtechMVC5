using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsingFilters.Infrastructure
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //Eğer, talep edilen sayfa; localden geldiyse bize 404 versin:
            if (filterContext.HttpContext.Request.IsLocal)
            {
                filterContext.Result = new HttpNotFoundResult();
            }

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
           
        }
    }
}