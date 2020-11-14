using BSU.StudentShowcase.Frontend.ViewModels.MultiProject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace BSU.StudentShowcase.Controllers
{
    public class MultiProjectController : Controller
    {
        private readonly ILogger<MultiProjectController> _logger;

        public MultiProjectController(ILogger<MultiProjectController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new MultiProjectIndexViewModel
            {
                ProjectPanelViewModels = new List<ProjectPanelViewModel>()
                {
                    new ProjectPanelViewModel
                    {
                        Category = "High Speed Computing",
                        ProjectName = "Parallel Processing inside of the Mersenne Prime Search FUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUCK YEAH",
                        School = "PragerU",
                        StudentName = "Dennis Prager",
                        ImagePreviewUrl = "https://i.ytimg.com/vi/Izn1ygP-gqM/maxresdefault.jpg",
                    },
                    new ProjectPanelViewModel
                    {
                        Category = "Object Oriented Programming",
                        ProjectName = "Finding the Longest Template Error in C++",
                        School = "Trump University",
                        StudentName = "Plumber Joe",
                        ImagePreviewUrl = "http://scp-wiki.wdfiles.com/local--files/scp-087/087stair.png",
                    },
                    //new ProjectPanelViewModel
                    //{

                    //},
                    //new ProjectPanelViewModel
                    //{

                    //},
                    //new ProjectPanelViewModel
                    //{

                    //},
                    //new ProjectPanelViewModel
                    //{

                    //},
                }
            };
            return View(model);
        }
    }
}
