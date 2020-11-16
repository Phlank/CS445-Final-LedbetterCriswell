using BSU.StudentShowcase.Frontend.ViewModels.JudgeApplication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU.StudentShowcase.Frontend.Controllers
{
    public class JudgeApplicationController : Controller
    {
        private readonly ILogger<JudgeApplicationController> _logger;

        public JudgeApplicationController(ILogger<JudgeApplicationController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JudgeApplicationIndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(OnSubmit));
            }
            return View(model);
        }
        
        [HttpGet]
        public IActionResult OnSubmit(JudgeApplicationIndexViewModel result)
        {
            return View();
        }
    }
}
