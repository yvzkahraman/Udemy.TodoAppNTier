using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.ToDoAppNTier.Entities.Domains
{
    public class Work : BaseEntity
    {

        public string Definition { get; set; }

        public bool IsCompleted { get; set; }
    }
}
