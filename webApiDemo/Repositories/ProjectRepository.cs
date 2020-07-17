using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiDemo.models;

namespace webApiDemo.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        //dependency inject AppDbContext
        private readonly ProjectAppDbContext _db;
        public ProjectRepository(ProjectAppDbContext db)
        {
            _db = db;
        }

        public void AddProject(Project p)
        {
            _db.Projects.Add(p);
            _db.SaveChanges();
        }

        public void DeleteProject(int id)
        {
            Project p = _db.Projects.Find(id);
            _db.Projects.Remove(p);
            _db.SaveChanges();
        }

        public List<Project> GetAllProjects()
        {
            return _db.Projects.ToList();
        }

        public Project GetProjectById(int id)
        {
            Project p = _db.Projects.Find(id);
            return p;
        }

        public void UpdateProject(Project p)
        {
            _db.Projects.Update(p);
            _db.SaveChanges();
        }
    }
}
