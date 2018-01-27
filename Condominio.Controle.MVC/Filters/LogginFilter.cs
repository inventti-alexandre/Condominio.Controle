using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Controle.MVC.Filters
{
    public class LogginFilter : IActionFilter
    {
        /// <summary>
        /// Nome do Arquivo de Log
        /// </summary>
        private static string fileName = "RequisicoesInfo.log";
        /// <summary>
        /// Caminho do arquivo de log
        /// </summary>
        private static string logFilePath;

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            SavaInfo(filterContext);
        }

        private void SavaInfo(ControllerContext Context)
        {
            string info = string.Format("Usuario : {0}, Ip : {1}, Data/Hora : {2}, Url : {3}",
                Context.HttpContext.User.Identity.Name,
                Context.HttpContext.Request.UserHostAddress,
                DateTime.Now,
                Context.HttpContext.Request.RawUrl
                );
            string path = GetLogPath(Context);
            using (var logWriter = new StreamWriter(path, true))
            {
                logWriter.WriteLine(info);
            }
        }

        private static string GetLogPath(ControllerContext context)
        {
            if (logFilePath == null)
            {
                var logPath = context.HttpContext.Server.MapPath("~/Logs");
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
                var path = Path.Combine(logPath, fileName);
            }

            return logFilePath;
        }
    }
}