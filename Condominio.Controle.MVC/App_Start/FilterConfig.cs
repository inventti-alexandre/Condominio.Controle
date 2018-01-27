using Condominio.Controle.MVC.Filters;
using System.Web;
using System.Web.Mvc;

namespace Condominio.Controle.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogginFilter());
        }
    }
}
