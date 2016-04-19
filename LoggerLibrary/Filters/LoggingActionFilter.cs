using System;
using System.Web.Mvc;

namespace LoggerLibrary.Filters
{
    public class LoggingActionFilter : ActionFilterAttribute
    {
        private ILogger _logger;

        public LoggingActionFilter()
        {
            _logger = LogManager.GetLogger();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var actionLog = GetActionLogInfo(filterContext);
            _logger.Info("On Action Executing..." + actionLog);
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionLog = GetActionLogInfo(filterContext);
            _logger.Info("On Action Executed.." + actionLog);
            base.OnActionExecuted(filterContext);
        }

        private ActionLog GetActionLogInfo(ControllerContext controllerContext)
        {
            string actionName = string.Empty;
            string controllerName = string.Empty;
            Exception exceptionAssociated = null;

            if (controllerContext is ActionExecutingContext)
            {
                var filterContext = controllerContext as ActionExecutingContext;

                actionName = filterContext.ActionDescriptor.ActionName;
                controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            }

            if (controllerContext is ActionExecutedContext)
            {
                var filterContext = controllerContext as ActionExecutedContext;

                actionName = filterContext.ActionDescriptor.ActionName;
                controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
                exceptionAssociated = filterContext.Exception;
            }

            ActionLog actionLog = new ActionLog
            {
                ActionName = actionName,
                ControllerName = controllerName,
                ExceptionAssociated = exceptionAssociated
            };
            return actionLog;
        }
    }
}
