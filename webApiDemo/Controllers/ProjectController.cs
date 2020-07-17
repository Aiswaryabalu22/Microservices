using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiDemo.models;
using webApiDemo.Repositories;

namespace webApiDemo.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _repo;
        public ProjectController(IProjectRepository repo)
        {
            _repo = repo;
        }


        // GET: api/Project
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetAllProjects());
            }
            catch(Exception e){
                return NotFound(e.Message);
            }            
        }

        // GET: api/Project/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_repo.GetProjectById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }            
        }

        // POST: api/Project
        [HttpPost]
        public IActionResult Post(Project p)
        {
            try
            {
                _repo.AddProject(p);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // PUT: api/Project/Update
        [HttpPut]
        [Route("Update")]
        public IActionResult Put(Project p)
        {
            try
            {
                _repo.UpdateProject(p);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // DELETE: api/Project/Delete/5
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.DeleteProject(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
