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

    public class Auth: ActionFilterAttribute
    {

        private readonly CorporxDbContext _context;
        public Auth(CorporxDbContext context)
        {
            _context = context;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            bool hasToken = context.HttpContext.Request.Cookies.TryGetValue("token", out string token);



            if (!hasToken)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "account" }));
            }

            var user = _context.Users.FirstOrDefault(u => u.Token == token);

            if (user == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "login", controller = "account" }));
            }

            if (user.Position != Position.Admin)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "Error", controller = "Error", area = "" }));
            }

            context.RouteData.Values["User"] = user;

            base.OnActionExecuting(context);
        }
    }
}
