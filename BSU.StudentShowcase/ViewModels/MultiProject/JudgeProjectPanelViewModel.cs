using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSU.StudentShowcase.Frontend.ViewModels.MultiProject
{
    public class JudgeProjectPanelViewModel
    {
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public string StudentName { get; set; }
        public string Category { get; set; }
        public string School { get; set; }
        public string ImagePreviewUrl { get; set; }
        public bool Judged { get; set; }
    }
}
