using System.Web;
using System.Web.Mvc;
using AjaxFormSample.Filters;

namespace AjaxForm
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomHandleErrorAttribute());
        }
    }
}