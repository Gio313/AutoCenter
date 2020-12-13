using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(AutoCenterDbContext db) : base(db)
        {
        }
    }
}
