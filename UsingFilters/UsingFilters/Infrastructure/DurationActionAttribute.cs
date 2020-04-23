using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using UsingFilters.Models;

namespace UsingFilters.Infrastructure
{
    public class DurationActionAttribute : FilterAttribute, IActionFilter, IResultFilter
    {
        private Stopwatch stopwatch;
        private Stopwatch resultStopWatch;
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            stopwatch.Stop();
            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.Response.Write($"<div>Action çalışma süresi: { stopwatch.Elapsed.TotalMilliseconds } milisaniyedir </div>");
            }

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //kronometreyi BAŞLAT
            stopwatch = Stopwatch.StartNew();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write($"<p>Çıktı tamamlandı: </p>");
            resultStopWatch.Stop();

            filterContext.HttpContext.Response.Write($"<div>Çıktının toplam oluşma süresi: { resultStopWatch.Elapsed.TotalMilliseconds } milisaniyedir </div>");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            resultStopWatch = Stopwatch.StartNew();
            filterContext.Controller.ViewBag.Bilgi = "Result Oluşturuluyor!";
            CustomModel model = (CustomModel)filterContext.Controller.ViewData.Model;
            model.Info = "Result Oluşturuluyor!";
            //filterContext.HttpContext.Response.Write($"<p>Result oluşturulyor....</p>");

        }
    }
}