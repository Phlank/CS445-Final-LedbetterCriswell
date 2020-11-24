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
                        Category = "High Performance Computing",
                        ProjectName = "Parallel Processing inside of the Mersenne Prime Search",
                        ProjectType = "Text",
                        School = "Vincennes University",
                        StudentName = "Alexa Palacios",
                        ImagePreviewUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Digits_in_largest_prime_found_as_a_function_of_time.svg/1280px-Digits_in_largest_prime_found_as_a_function_of_time.svg.png",
                    },
                    new ProjectPanelViewModel
                    {
                        Category = "Object Oriented Programming",
                        ProjectName = "Finding the Longest Compiler Error in C++",
                        ProjectType = "Video",
                        School = "Ball State University",
                        StudentName = "Zane Dennis",
                        ImagePreviewUrl = "http://scp-wiki.wdfiles.com/local--files/scp-087/087stair.png",
                    },
                    new ProjectPanelViewModel
                    {
                        Category = "Algorithms",
                        ProjectName = "Bogosort Effectiveness on Various Pseudorandom Algorithms",
                        ProjectType = "Brochure",
                        School = "Northwestern University",
                        StudentName = "Alan Suchecki",
                        ImagePreviewUrl = "https://i.ytimg.com/vi/DaPJkYo2quc/maxresdefault.jpg"
                    },
                    new ProjectPanelViewModel
                    {
                        Category = "Algorithms",
                        ProjectName = "Bogosort Effectiveness on Various Pseudorandom Algorithms",
                        ProjectType = "Brochure",
                        School = "Northwestern University",
                        StudentName = "Alan Suchecki",
                        ImagePreviewUrl = "https://i.ytimg.com/vi/DaPJkYo2quc/maxresdefault.jpg"
                    },
                }
            };
            return View(model);
        }

        public IActionResult Search(string search)
        {
            return View();
        }

        public IActionResult JudgeIndex()
        {
            var model = new JudgeMultiProjectIndexViewModel
            {
                JudgeProjectPanelViewModels = new List<JudgeProjectPanelViewModel>()
                {
                    new JudgeProjectPanelViewModel
                    {
                        Category = "High Performance Computing",
                        ProjectName = "Parallel Processing inside of the Mersenne Prime Search",
                        ProjectType = "Text",
                        School = "Vincennes University",
                        StudentName = "Alexa Palacios",
                        ImagePreviewUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Digits_in_largest_prime_found_as_a_function_of_time.svg/1280px-Digits_in_largest_prime_found_as_a_function_of_time.svg.png",
                        Judged = true,
                    },
                    new JudgeProjectPanelViewModel
                    {
                        Category = "Object Oriented Programming",
                        ProjectName = "Finding the Longest Compiler Error in C++",
                        ProjectType = "Video",
                        School = "Ball State University",
                        StudentName = "Zane Dennis",
                        ImagePreviewUrl = "http://scp-wiki.wdfiles.com/local--files/scp-087/087stair.png",
                        Judged = false,
                    },
                    new JudgeProjectPanelViewModel
                    {
                        Category = "Algorithms",
                        ProjectName = "Bogosort Effectiveness on Various Pseudorandom Algorithms",
                        ProjectType = "Brochure",
                        School = "Northwestern University",
                        StudentName = "Alan Suchecki",
                        ImagePreviewUrl = "https://i.ytimg.com/vi/DaPJkYo2quc/maxresdefault.jpg",
                        Judged = false
                    },
                    new JudgeProjectPanelViewModel
                    {
                        Category = "Algorithms",
                        ProjectName = "Bogosort Effectiveness on Various Pseudorandom Algorithms",
                        ProjectType = "Brochure",
                        School = "Northwestern University",
                        StudentName = "Alan Suchecki",
                        ImagePreviewUrl = "https://i.ytimg.com/vi/DaPJkYo2quc/maxresdefault.jpg",
                        Judged = true
                    }
                }
            };
            return View(model);
        }

    }
}
