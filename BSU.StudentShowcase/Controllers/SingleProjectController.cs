using BSU.StudentShowcase.Frontend.ViewModels.SingleProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU.StudentShowcase.Frontend.Controllers
{
    public class SingleProjectController : Controller
    {
        private readonly ILogger<SingleProjectController> _logger;

        public SingleProjectController(ILogger<SingleProjectController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new SingleProjectViewModel
            {
                Catagory = "America",
                Description = "America is Great",
                ProjectName = "Why America is Great",
                ProjectType = "Text",
                School = "Trump University",
                StudentName = "Cheato King",
                DateUploaded = "May 5",
                Content = "	This is in a certain format. This is in a certain format This is in a certain format. This is in a certain format. This is in a certain format This is in a certain format This is in a certain format This is in a certain format. This is in a certain format. This is in a certain format This is in a certain format. This is in a certain format. This is in a certain format This is in a certain format This is in a certain format This is in a certain format. This is in a certain format. This is in a certain format This is in a certain format. This is in a certain format. This is in a certain format This is in a certain format This is in a certain format This is in a certain format. This is in a certain format.This is in a certain format This is in a certain format.This is in a certain format.This is in a certain format This is in a certain format This is in a certain format This is in a certain format.This is in a certain format.This is in a certain format This is in a certain format.This is in a certain format.This is in a certain format This is in a certain format This is in a certain format This is in a certain format.This is in a certain format.This is in a certain format This is in a certain format.This is in a certain format.This is in a certain format This is in a certain format This is in a certain format This is in a certain format. "

            };
            return View(model);
        }
    }
}
