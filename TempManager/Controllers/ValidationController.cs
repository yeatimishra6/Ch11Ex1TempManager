using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TempManager.Models
{

    //Yeati Mishra
    public class ValidationController : Controller
{
        private TempManagerContext context { get; set; }
        public ValidationController(TempManagerContext ctx) => context = ctx;
        public JsonResult CheckDate(string date)
        {
            DateTime dt = DateTime.Parse(date);
            Temp temp = context.Temps.FirstOrDefault(t => t.Date == dt);
            if (temp == null)
            {
                return Json(true);
            }
            else 
            {
                return Json($"This data {date} is a duplicate");
            }
        }
    public IActionResult Index()
    {
        return View();
    }
}
}
