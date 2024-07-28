using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Restful.Api.Services;

namespace Restful.Api.Attributes
{
    public class AuthorizeAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var userService = context.HttpContext.RequestServices.GetRequiredService<IUserService>();
            var isValidUser = userService.ValidateUser("zilan", "password");
            if (!isValidUser)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            await next();
        }
    }
}
