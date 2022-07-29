using Northwind.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private NorthwindContext _context;
        private IRepository<Employee> _employees;
        public IRepository<Employee> Employees {
            get 
            {
                return _employees == null ?
                    _employees = new Repository<Employee>(_context) :
                    _employees;
            }
        }

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
