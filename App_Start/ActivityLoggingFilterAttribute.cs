using NatterbaseProject.Models;
using NatterbaseProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace NatterbaseProject.App_Start
{
    public class ActivityLoggingFilterAttribute : ActionFilterAttribute
    {
        public override Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            var username = actionContext.RequestContext.Principal.Identity.Name;

            using (var db = new ActivityRepository())
            {
                var activity = new Activity
                {
                    Name = username,
                    DatePerformed = DateTime.Now,
                    Action = actionContext.ActionDescriptor.ActionName,
                    Controller = actionContext.ControllerContext.ControllerDescriptor.ControllerName
                };

                db.CreateActivity(activity);
            }

            return base.OnActionExecutingAsync(actionContext, cancellationToken);
        }
    }
}