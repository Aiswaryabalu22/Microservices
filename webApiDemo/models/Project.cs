using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webApiDemo.models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Maximum length can be only 15 characters")]
        public string ProjectName { get; set; }
    }
}
