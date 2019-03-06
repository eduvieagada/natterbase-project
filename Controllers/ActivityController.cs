using NatterbaseProject.Models;
using NatterbaseProject.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NatterbaseProject.Controllers
{
    [Authorize]
    public class ActivityController : ApiController
    {
        // GET: api/Activity
        public async Task<IHttpActionResult> Get()
        {
            var name = Request.GetRequestContext().Principal.Identity.Name;
            using(var db = new ActivityRepository())
            {
                var activities = await db.GetActivities(name);
                return Ok(activities);
            }
        }
    }
}
