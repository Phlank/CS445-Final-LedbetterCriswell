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
                        Summary = "The math behind the Great Internet Mersenne Prime Search can be found <a href=\"https://www.mersenne.org/various/math.php\">here</a>.",
                        Content = "Mersenne's primes, where M_p=2^p-1 is prime (if p is an odd number not prime 2^p-1 is a composite number), are one of the forms of the primes that has received attention by mathematicians and amateurs, because of their enormous difficulty in finding them, due to their exponential composition that makes calculation more difficult by normal means, but at the same time allows finding prime numbers of millions of digits. The GIMPS (Great Internet Mersenne Prime Search) is a project that was created for its calculation. GIMPS is one of the first large-scale distributed computing projects on the Internet for research purposes and offers a free computer program to all volunteers looking for Mersenne prime numbers. This document demonstrates the form or composition that must be fulfilled by both p and M_p within the prime numbers, which facilitates the calculation of M_p taking into account that not every p produces a prime M_p. Likewise, a derivation of Fermat's little theorem was proved, establishing that for all natural numbers n>0 and a≥2, a^n-1≡( mod [a-1]), that is (a-1)|(a^n-1) and when a is coprime with a prime p=n+1 then p|(∑_(k=1),n a^(n-k) ), it was also found that the new conjecture of Mersenne or Conjecture of Bateman, Selfridge and Wagstaff (Bateman et al., 1989) is false."
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
                        Content = "Mersenne's primes, where M_p=2^p-1 is prime (if p is an odd number not prime 2^p-1 is a composite number), are one of the forms of the primes that has received attention by mathematicians and amateurs, because of their enormous difficulty in finding them, due to their exponential composition that makes calculation more difficult by normal means, but at the same time allows finding prime numbers of millions of digits. The GIMPS (Great Internet Mersenne Prime Search) is a project that was created for its calculation. GIMPS is one of the first large-scale distributed computing projects on the Internet for research purposes and offers a free computer program to all volunteers looking for Mersenne prime numbers. This document demonstrates the form or composition that must be fulfilled by both p and M_p within the prime numbers, which facilitates the calculation of M_p taking into account that not every p produces a prime M_p. Likewise, a derivation of Fermat's little theorem was proved, establishing that for all natural numbers n>0 and a≥2, a^n-1≡( mod [a-1]), that is (a-1)|(a^n-1) and when a is coprime with a prime p=n+1 then p|(∑_(k=1),n a^(n-k) ), it was also found that the new conjecture of Mersenne or Conjecture of Bateman, Selfridge and Wagstaff (Bateman et al., 1989) is false."
                    };
            }
        }
    }
}
