using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_DZ4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SelectListItem[] array = {
                new SelectListItem { Text = "Понедельник", Selected = false },
                new SelectListItem {Text = "Вторник", Selected = false },
                new SelectListItem {Text = "Среда", Selected = false },
                new SelectListItem {Text = "Четверг", Selected = false },
                new SelectListItem {Text = "Пятница", Selected = false },
                new SelectListItem {Text = "Суббота", Selected = true },
                new SelectListItem {Text = "Воскресенье", Selected = true },

            };

            //MultiSelectList items = new MultiSelectList(array);
            return View(array);
        }
    }
}