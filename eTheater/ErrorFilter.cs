using eTheater.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace eTheater
{
    public class ErrorFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {

            if (context.Exception is UserException)
            {
                context.ModelState.AddModelError(((UserException)context.Exception).Title, context.Exception.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else if (context.Exception is ShowScheduleException)
            {
                context.ModelState.AddModelError(((ShowScheduleException)context.Exception).Title, context.Exception.Message);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
            else
            {
                context.ModelState.AddModelError("Server", "Something went wrong on the server");
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            var errorsDictionary = context.ModelState.Where(m => m.Value.Errors.Count > 0).ToDictionary(m => m.Key, m => m.Value.Errors.Select(e => e.ErrorMessage).ToList());
            context.Result = new ObjectResult(new { Errors = errorsDictionary });
        }
    }
}
