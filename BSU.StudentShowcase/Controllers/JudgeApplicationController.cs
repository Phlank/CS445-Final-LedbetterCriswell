using BSU.StudentShowcase.Frontend.ViewModels.JudgeApplication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU.StudentShowcase.Frontend.Controllers
{
    public class JudgeApplicationController : Controller
    {
        public IActionResult Index()
        {
            var model = new JudgeApplicationIndexViewModel
            {

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Submit(JudgeApplicationIndexViewModel result)
        {
            return View();
        }
    }
}
