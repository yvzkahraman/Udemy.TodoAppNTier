using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.DataAccess.Interfaces;
using Udemy.ToDoAppNTier.Entities.Domains;

namespace Udemy.TodoAppNTier.DataAccess.UnitofWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;

        Task SaveChanges();
    }
}
