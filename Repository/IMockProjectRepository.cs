using MinProjMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinProjMVC.Repository
{
    public interface IMockProjectRepository
    {
        IEnumerable<Project> GetAll();
        Project Add(Project project);
        
    }
}
