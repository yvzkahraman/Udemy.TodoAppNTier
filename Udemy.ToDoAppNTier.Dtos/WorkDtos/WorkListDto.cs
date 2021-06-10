using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkListDto
    {
        public int Id { get; set; }

        public string Definition { get; set; }

        public bool IsCompleted { get; set; }
    }
}
