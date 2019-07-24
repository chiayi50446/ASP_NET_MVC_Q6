using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_NET_MVC_Q6.ActionFilter
{
    public class ActionDetailAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var areaName = filterContext.RouteData.DataTokens["area"];
            string showString = (areaName == null) ? "" : ("area = " + areaName + ", ");
            var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            var actionName = filterContext.ActionDescriptor.ActionName;
            showString = showString + "controller = " + controllerName + ", action = " + actionName;
            var arrParameter = filterContext.ActionDescriptor.GetParameters();
            if (arrParameter.Length > 0)
            {
                var paramName = arrParameter[0].ParameterName;
                var parameterValue = filterContext.Controller.ValueProvider.GetValue(paramName).RawValue;
                showString = showString + ", " + paramName + " = " + parameterValue;
            }
            filterContext.HttpContext.Response.Write($"<span>{showString}</span>");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }
    }
}