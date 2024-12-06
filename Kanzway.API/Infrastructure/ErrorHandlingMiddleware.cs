using System.Net;

namespace Kanzway.API.Infrastructure
{
    /// <summary>
    /// Middleware for error handling
    /// </summary>
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate next;
        /// <summary>
        /// constructor that use the request delegate
        /// </summary>
        /// <param name="next"></param>
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                HttpStatusCode code = HttpStatusCode.InternalServerError;
                if(ex is BusinessRuleException)
                {
                    code = HttpStatusCode.BadRequest;
                }
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)code;
                await context.Response.WriteAsync(ex.Message);
            }
        }

    }
}
