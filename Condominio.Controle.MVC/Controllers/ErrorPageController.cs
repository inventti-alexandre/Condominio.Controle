using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Controle.MVC.Controllers
{
    /// <summary>
    /// Pagina Padrão do Error http 404. configurado no web.config sessão System.web
    /// </summary>
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult NotFound()
        {
            return View();
        }
    }
}