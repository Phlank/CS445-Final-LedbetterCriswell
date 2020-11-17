using BSU.StudentShowcase.Frontend.ViewModels.MultiProject;
using BSU.StudentShowcase.Frontend.ViewModels.ProjectSubmission;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BSU.StudentShowcase.Controllers
{
    public class ProjectSubmissionController : Controller
    {
        private readonly ILogger<ProjectSubmissionController> _logger;

        public ProjectSubmissionController(ILogger<ProjectSubmissionController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProjectSubmissionIndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(OnSubmit));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult OnSubmit()
        {
            return View();
        }
    }
}
