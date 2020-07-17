using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeService.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }

        [Required]
        public string Ename { get; set; }

        public DateTime DOJ { get; set; }
    }
}
