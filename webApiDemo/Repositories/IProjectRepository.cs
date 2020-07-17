using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiDemo.models;

namespace webApiDemo.Repositories
{
    public interface IProjectRepository
    {
        //all CRUD Operations

        //GET
        public List<Project> GetAllProjects();

        //GET by ID
        public Project GetProjectById(int id);

        //POST
        public void AddProject(Project p);

        //PUT
        public void UpdateProject(Project p);

        //DELETE
        public void DeleteProject(int id);
    }
}
