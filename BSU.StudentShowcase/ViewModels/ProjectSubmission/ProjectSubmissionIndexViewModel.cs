using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSU.StudentShowcase.Frontend.ViewModels.ProjectSubmission
{
    public class ProjectSubmissionIndexViewModel
    {
        public int SubmissionId { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string StudentName { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string SchoolName { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string AdvisorName { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string Category { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string ProjectType { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This is a required field.")]
        public string Content { get; set; }
        public string AdditionalNotes { get; set; }
        public DateTime SubmittedOn { get; set; }
    }
}
