using CorporX.Data;
using CorporX.Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorporX.Filters
{
    public class Profile: ActionFilterAttribute
    {

        private readonly CorporxDbContext _context;
        public Profile(CorporxDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            context.HttpContext.Request.Cookies.TryGetValue("token", out string token);

            var user = _context.Users.FirstOrDefault(u => u.Token == token);

            context.RouteData.Values["User"] = user;

            base.OnActionExecuting(context);
        }
    }
}
