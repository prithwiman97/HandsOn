using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Stripe.Issuing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HandsOn27.Filter
{
    public class CustomAuthFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(filterContext.HttpContext.Request.Headers.ContainsKey("Authorization"))
            {
                filterContext.Result = new OkResult();
            }
            else
            {
                filterContext.Result = new UnauthorizedResult();
            }
        }
    }
}
