using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinProjMVC.Models
{
    public class Project
    {
        public string ProjectName { get; set; }
        public int ProjectCode { get; set; }
        public string Location { get; set; }
        public ProjType ProjectType { get; set; }
        public DateTime LastDate { get; set; }
        
        public Resource resource { get; set; }
    }
}
