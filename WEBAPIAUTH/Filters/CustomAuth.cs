using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace WEBAPIAUTH.Filters
{
    public class CustomAuthorization :System.Web.Http.Filters.AuthorizationFilterAttribute
    //System.Web.Http.Filters.IAuthorizationFilter
    {

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            string action = actionContext.ControllerContext.RouteData.Values["action"].ToString();
            string controller = actionContext.ControllerContext.RouteData.Values["controller"].ToString();
            Type t = actionContext.ControllerContext.Controller.GetType();
            //Type t = actionContext.ControllerContext.Controller.
            base.OnAuthorization(actionContext);
        }
    }
}