using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DN4._0_Week4_WebAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string logPath = Path.Combine(Directory.GetCurrentDirectory(), "error_log.txt");
            File.WriteAllText(logPath, context.Exception.ToString());

            context.Result = new ObjectResult("Internal server error")
            {
                StatusCode = 500
            };
        }
    }
}
