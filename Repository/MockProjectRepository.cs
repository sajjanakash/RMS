using MinProjMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinProjMVC.Repository
{
    public class MockProjectRepository : IMockProjectRepository
    {
        private List<Project> _project;
        

        public MockProjectRepository()
        {
            _project = new List<Project>()
            {
                new Project() { ProjectName = "CS", ProjectCode = 12, Location = "Bangalore", ProjectType = ProjType.Development, LastDate = Convert.ToDateTime("12-Jan-2021"), resource = new Resource{ SNo=1,Designation="SE",SkillSet="Jva",ExperienceInMonths=12,NoOfCandidates=12} },
                new Project(){ProjectName="EC",ProjectCode=112,Location="Pune",ProjectType=ProjType.Testing,LastDate=Convert.ToDateTime("12-Jan-2021"),resource = new Resource{ SNo=2,Designation="SSE",SkillSet="Jva",ExperienceInMonths=12,NoOfCandidates=12}},
                new Project(){ProjectName="Civil",ProjectCode=122,Location="Hyd",ProjectType=ProjType.Support,LastDate=Convert.ToDateTime("12-Jan-2021"),resource = new Resource{ SNo=3,Designation="JE",SkillSet="Jva",ExperienceInMonths=12,NoOfCandidates=12} }
              
            };

            
        }

        public Project Add(Project project)
        {
            //throw new NotImplementedException();
            _project.Add(project);
            return project;
        }

        public IEnumerable<Project> GetAll()
        {
            //throw new NotImplementedException();

            return _project;
        }

        
    }
}
