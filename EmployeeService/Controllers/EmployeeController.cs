using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeService.Models;
using EmployeeService.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        // GET: api/GetEmployees
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.GetEmployees());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // GET: api/GetEmployees/5
        [Route("GetEmployee/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_repo.GetEmployeeById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // POST: api/AddEmployee
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Post(Employee e)
        {
            try
            {
                _repo.AddEmployee(e);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // PUT: api/Employee/UpdateEmp
        [HttpPut]
        [Route("UpdateEmp")]
        public IActionResult Put(Employee e)
        {
            try
            {
                _repo.UpdateEmployee(e);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // DELETE: api/Employee/DeleteEmp/5
        [HttpDelete]
        [Route("DeleteEmp/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.DeleteEmployee(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}

    