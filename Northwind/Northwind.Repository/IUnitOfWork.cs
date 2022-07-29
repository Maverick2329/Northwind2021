using Northwind.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Employee> Employees { get; }
        public void Save();
    }
}
