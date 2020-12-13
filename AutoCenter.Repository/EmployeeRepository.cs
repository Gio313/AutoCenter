using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class EmployeeRepository : RepositoryBase<Employee>
    {
        public EmployeeRepository(AutoCenterDbContext db) : base(db)
        {
        }
    }
}
