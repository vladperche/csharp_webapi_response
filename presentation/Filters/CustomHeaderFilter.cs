using Microsoft.AspNetCore.Mvc.Filters;

namespace presentation.Filters
{
    public class CustomHeaderFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            context.HttpContext.Response.Headers.Append("x-my-custom-header", new[] { "my custom value for all responses" });
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Do Nothing
        }

        public void OnActionFilter(ActionExecutedContext actionExecutedContext)
        {
            //Do Nothing
        }
    }
}
