using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class SessionAuthorizeAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var isLoggedIn = context.HttpContext.Session.GetString("IsLoggedIn");

        if (isLoggedIn != "true")
        {
            context.Result = new RedirectToActionResult("Login", "Home", null);
        }

        base.OnActionExecuting(context);
    }
}
