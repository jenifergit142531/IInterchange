using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace webapi3.Models
{
    public class SecretKeyAttibute : Attribute, IAsyncActionFilter
    {
        private const string APIKEYNAME = "SecretKey";
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(!context.HttpContext.Request.Headers.TryGetValue(APIKEYNAME,out var extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Secret key is not provided"
                };
                return;
            }

            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var apikey = appSettings.GetValue<string>(APIKEYNAME);

            if(!apikey.Equals(extractedApiKey))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Secret key is not valid"
                };
                return;
            }
            await next();
        }
    }
}
