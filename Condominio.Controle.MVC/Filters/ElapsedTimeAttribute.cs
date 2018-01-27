using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Controle.MVC.Filters
{
    /// <summary>
    /// Observação para utilizar basta decorar a Action com * [ ElapsedTime ]
    /// </summary>
    public class ElapsedTimeAttribute : ActionFilterAttribute
    {
        private Stopwatch duration;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            duration = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            duration.Stop();
            string info = string.Format(" Duração total : {0} ms", duration.ElapsedMilliseconds);
            filterContext.HttpContext.Response.Write(info);
        }

    }
}