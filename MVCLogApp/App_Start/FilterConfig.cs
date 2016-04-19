using System.Web;
using System.Web.Mvc;
using LoggerLibrary;
using LoggerLibrary.Filters;

namespace MVCLogApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new LoggingActionFilter());
            filters.Add(new LogExceptionFilter());
        }
    }
}
