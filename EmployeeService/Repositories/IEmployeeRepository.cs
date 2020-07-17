using EmployeeService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Repositories
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployees();

        public Employee GetEmployeeById(int id);

        public void AddEmployee(Employee e);

        public void UpdateEmployee(Employee e);

        public void DeleteEmployee(int id);
    }
}
