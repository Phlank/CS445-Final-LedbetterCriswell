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

        [HttpGet]
        public IActionResult Index(int id)
        {
            var model = GetProjectModel(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult JudgeIndex(int id)
        {
            var model = new JudgeSingleProjectIndexViewModel
            {
                ProjectModel = GetProjectModel(id),
                Judged = false
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult JudgeIndex(int id, JudgeSingleProjectIndexViewModel model)
        {
            if (model == null)
            {
                model = new JudgeSingleProjectIndexViewModel();
                model.Judged = true;
            }
            model.ProjectModel = GetProjectModel(id);
            return View(model);
        }

        private SingleProjectIndexViewModel GetProjectModel(int id)
        {
            switch (id)
            {
                case 0:
                    return new SingleProjectIndexViewModel
                    {
                        Category = "High Performance Computing",
                        ProjectName = "Parallel Processing inside of the Mersenne Prime Search",
                        ProjectType = "Text",
                        School = "Vincennes University",
                        StudentName = "Alexa Palacios",
                        Summary = "The math behind the Great Internet Mersenne Prime Search running on multiple GPUs.",
                        Content = "PRIMALITY TESTS FOR - 1 USING ELLIPTIC CURVES \n\nAlexa Palacios\n\n\tAbstract. We propose some primality tests for 2''n — 1, where k, \nn £ Z, k > 2 and n odd. There are several tests depending on how \nbig n is. These tests are proved using properties of eUiptic curves. \nEssentiaUy, the new primahty tests are the eUiptic curve version of \nthe Lucas-Lehnier-Ricsel primahty test. \n\n1. Note \n\n\tAn anonymous referee suggested that Benedict H. Gross already \nproved the same result about a primality test for Mersenne primes \nusing elliptic curve in [1]. \n\n2. Introduction. \n\n\tThere are mainly two types of primality tests. One of them applies to any integer and the other applies only to a special form of integer. Usually the latter is faster than the former because of its additional information. Among them, the Lucas-Lehmer primality test for Mersenne numbers Mk = 2*^ — 1 is very fast. The test uses a sequence Si defined by S'o = 4 and 5*,+! = 5*^ — 2 for i > 1. The primality test is that Mfc is prime if and only if divides Sk-2- For a proof, see for example [2]. Also see P and [8j for applications of the Lucas sequence for other primality tests. There is also a generalization of this test called the Lucas-Lehmer-Riesel test which applies to integers of the form 2^n — 1 with n <2^ (see [6j and [8]). This test also uses the sequence Si defined by the above recursion but with a different initial value S'o depending k and n."
                    };
                case 1:
                    return new SingleProjectIndexViewModel
                    {
                        Category = "Object Oriented Programming",
                        ProjectName = "Finding the Longest Compiler Error in C++",
                        ProjectType = "Video",
                        School = "Ball State University",
                        StudentName = "Zane Dennis",
                        Summary = "I didn't take enough class this semester, so this is what I did in my spare time.",
                        Content = "https://www.youtube.com/embed/QMYfkOtYYlg",
                    };
                case 2:
                    return new SingleProjectIndexViewModel
                    {
                        Category = "Algorithms",
                        ProjectName = "Bogosort Effectiveness on Various Pseudorandom Algorithms",
                        ProjectType = "Brochure",
                        School = "Northwestern University",
                        StudentName = "Alan Suchecki",
                        Summary = "My experiments may never finish, literally!",
                        Content = "https://www.shutterstock.com/blog/wp-content/uploads/sites/5/2018/07/Final-brochure.jpg",
                    };
                case 3:
                    return new SingleProjectIndexViewModel
                    {
                        Category = "Algorithms",
                        ProjectName = "Bogosort Effectiveness on Various Pseudorandom Algorithms",
                        ProjectType = "Brochure",
                        School = "Northwestern University",
                        StudentName = "Alan Suchecki",
                        Summary = "My experiments may never finish, literally!",
                        Content = "https://www.shutterstock.com/blog/wp-content/uploads/sites/5/2018/07/Final-brochure.jpg",
                    };
                default:
                    return new SingleProjectIndexViewModel
                    {
                        Category = "High Performance Computing",
                        ProjectName = "Parallel Processing inside of the Mersenne Prime Search",
                        ProjectType = "Text",
                        School = "Vincennes University",
                        StudentName = "Alexa Palacios",
                        Summary = "The math behind the Great Internet Mersenne Prime Search can be found <a href=\"https://www.mersenne.org/various/math.php\">here</a>.",
                        Content = "PRIMALITY TESTS FOR - 1 USING ELLIPTIC CURVES \n\nAlexa Palacios\n\n\tAbstract. We propose some primality tests for 2''n — 1, where k, \nn £ Z, k > 2 and n odd. There are several tests depending on how \nbig n is. These tests are proved using properties of eUiptic curves. \nEssentiaUy, the new primahty tests are the eUiptic curve version of \nthe Lucas-Lehnier-Ricsel primahty test. \n\n1. Note \n\n\tAn anonymous referee suggested that Benedict H. Gross already \nproved the same result about a primality test for Mersenne primes \nusing elliptic curve in [1]. \n\n2. Introduction. \n\n\tThere are mainly two types of primality tests. One of them applies to any integer and the other applies only to a special form of integer. Usually the latter is faster than the former because of its additional information. Among them, the Lucas-Lehmer primality test for Mersenne numbers Mk = 2*^ — 1 is very fast. The test uses a sequence Si defined by S'o = 4 and 5*,+! = 5*^ — 2 for i > 1. The primality test is that Mfc is prime if and only if divides Sk-2- For a proof, see for example [2]. Also see P and [8j for applications of the Lucas sequence for other primality tests. There is also a generalization of this test called the Lucas-Lehmer-Riesel test which applies to integers of the form 2^n — 1 with n <2^ (see [6j and [8]). This test also uses the sequence Si defined by the above recursion but with a different initial value S'o depending k and n."
                    };
            }
        }
    }
}
