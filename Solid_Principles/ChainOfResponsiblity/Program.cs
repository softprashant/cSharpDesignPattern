using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblity
{
    class Program
    {
        static void Main(string[] args)
        {
            var requirement = new Requirement();

            ProjectManager manager = new ProjectManager();
            SoftwareEngineer engineer = new SoftwareEngineer();
            Architect architect = new Architect();

            manager.GiveToNext(architect);
            architect.GiveToNext(engineer);

            manager.Handle(requirement);

            foreach (var task in requirement.WorkDoneBy)
            {
                Console.WriteLine(task);
            }

            Console.ReadKey();
        }
    }

    // Sequential way of delegating work

    public class Requirement
    {
        public List<string> WorkDoneBy;

        public Requirement()
        {
            WorkDoneBy = new List<string>();
        }
    }

    public interface IProjectDevelopment
    {
        void Handle(Requirement requirement);
        void GiveToNext(IProjectDevelopment work);
    }

    public class ProjectManager : IProjectDevelopment
    {
        private IProjectDevelopment _projectDevelopment;
        public void Handle(Requirement requirement)
        {
            requirement.WorkDoneBy.Add("Work done by project manager");
            _projectDevelopment.Handle(requirement);
        }

        public void GiveToNext(IProjectDevelopment work)
        {
            this._projectDevelopment = work;
        }
    }

    public class Architect : IProjectDevelopment
    {
        private IProjectDevelopment _projectDevelopment;
        public void Handle(Requirement requirement)
        {
            requirement.WorkDoneBy.Add("Work done by Architect");
            _projectDevelopment.Handle(requirement);
        }

        public void GiveToNext(IProjectDevelopment work)
        {
            this._projectDevelopment = work;
        }
    }

    public class SoftwareEngineer : IProjectDevelopment
    {
        public void Handle(Requirement requirement)
        {
            requirement.WorkDoneBy.Add("Work done by Software Engineer");
        }

        public void GiveToNext(IProjectDevelopment work)
        {
            throw new NotImplementedException();
        }
    }
}
