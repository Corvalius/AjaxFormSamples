using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxFormSample.Models;

namespace AjaxFormSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult AddPerson()
        {
            var model = new PersonModel
            {
                Id = 1,
                Name = "Hernán"
            };

            return PartialView("_AddPerson", model);
        }

        [HttpPost]
        public ActionResult AddPerson(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                //Add Person.
            }

            return JsonView(ModelState.IsValid, "_AddPerson", model);
        }

        [HttpPost]
        public ActionResult AddPersonThrowsException(PersonModel model)
        {
            throw new NotImplementedException();
        }

        private string RenderPartialView(string partialViewName, object model)
        {
            if (ControllerContext == null)
                return string.Empty;

            if (model == null)
                throw new ArgumentNullException("model");

            if (string.IsNullOrEmpty(partialViewName))
                throw new ArgumentNullException("partialViewName");

            ViewData.Model = model;

            using (var sw = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, partialViewName);
                var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);
                return sw.GetStringBuilder().ToString();
            }
        }

        private JsonResult JsonView(bool success, string viewName, object model)
        {
            return Json(new { Success = success, View = RenderPartialView(viewName, model) });
        }
    }
}
