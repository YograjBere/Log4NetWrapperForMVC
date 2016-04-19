using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LoggerLibrary.Filters
{
   public class LogExceptionFilter : HandleErrorAttribute
    {
        private ILogger _logger;

        public LogExceptionFilter()
        {
            _logger = LogManager.GetLogger();
        }

        public override void OnException(ExceptionContext filterContext)
        {
            _logger.Error("On Exception from exception filter " + filterContext.Exception);
            base.OnException(filterContext);
        }
    }
}
