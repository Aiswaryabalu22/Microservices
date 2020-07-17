using EmployeeService.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace EmployeeService.Repositories
{
    //Employee and project have a one-to-many relationship.
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeAppDbContext _db;
        public EmployeeRepository(EmployeeAppDbContext db)
        {
            _db = db;
        }

        public void AddEmployee(Employee e)
        {
            int pid = e.Project.Pid;
            var project = _db.CompanyProjects.Find(pid);
            var newEmployee = new Employee()
            {
                Eid = e.Eid,
                Ename = e.Ename,
                DOJ = e.DOJ,
                Project = project
            };
            _db.Employees.Add(newEmployee);
            _db.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            Employee e = _db.Employees.Find(id);
            _db.Employees.Remove(e);
            _db.SaveChanges();
        }

        public Employee GetEmployeeById(int id)
        {
            IEnumerable<Employee> emps = _db.Employees.Include(p => p.Project);
            return (from e in emps where e.Eid == id select e).FirstOrDefault();
            //return _db.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return _db.Employees.Include(p => p.Project).ToList();
        }

        public void UpdateEmployee(Employee e)
        {
            //Employee e = _db.Employees.Find(id);
            _db.Employees.Update(e);
            _db.SaveChanges();
        }
    }
}
