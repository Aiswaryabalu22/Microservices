using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Models
{
    public class CompanyProject
    {
        [Key]
        public int Pid { get; set; }

        [Required]
        public string Pname { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}
