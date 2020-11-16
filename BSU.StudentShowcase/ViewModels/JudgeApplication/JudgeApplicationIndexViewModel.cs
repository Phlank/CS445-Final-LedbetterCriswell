using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSU.StudentShowcase.Frontend.ViewModels.JudgeApplication
{
    public class JudgeApplicationIndexViewModel
    {
        public int SubmissionId { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        public string Position { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string Username { get; set; }
    }
}
