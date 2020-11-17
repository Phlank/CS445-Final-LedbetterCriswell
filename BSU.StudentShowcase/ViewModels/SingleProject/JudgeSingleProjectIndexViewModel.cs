using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BSU.StudentShowcase.Frontend.ViewModels.SingleProject
{
    public class JudgeSingleProjectIndexViewModel
    {
        public SingleProjectIndexViewModel ProjectModel { get; set; }
        public int JudgeId { get; set; }
        public int ProjectId { get; set; }
        [Required(ErrorMessage = "You must select a score for this item")]
        public int ClearGoals { get; set; }
        [Required(ErrorMessage = "You must select a score for this item")]
        public int AdequatePreparation { get; set; }
        [Required(ErrorMessage = "You must select a score for this item")]
        public int AppropriateMethods { get; set; }
        [Required(ErrorMessage = "You must select a score for this item")]
        public int SignificantResults { get; set; }
        [Required(ErrorMessage = "You must select a score for this item")]
        public int EffectivePresentation { get; set; }
        [Required(ErrorMessage = "You must select a score for this item")]
        public int ReflectiveCritique { get; set; }
        public string AdditionalFeedback { get; set; }
        public bool Judged { get; set; }
    }
}
