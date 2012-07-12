using GwoDb.Web.Context;

namespace System.Web.Mvc
{
    public class AccessOnlyLoggedIn : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var userSession = new SessionUser();
            if (!userSession.IsLoggedIn)
                filterContext.HttpContext.Response.Redirect("/");

            base.OnActionExecuting(filterContext);
        }
    }
}
