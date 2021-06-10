using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto
    {
        [Required(ErrorMessage ="Definition is required")]
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
