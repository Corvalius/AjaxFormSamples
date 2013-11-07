using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxForm.Filters
{
    public class SetResponseStatusAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            if (!filterContext.Controller.ViewData.ModelState.IsValid)
            {
                filterContext.HttpContext.Response.SetStatusCode(HttpStatusCodeExtended.UnprocessableEntity);
            }
        }
    }
}