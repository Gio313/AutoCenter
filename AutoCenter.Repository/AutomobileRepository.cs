using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class AutomobileRepository : RepositoryBase<Automobile>
    {
        public AutomobileRepository(AutoCenterDbContext db) : base(db)
        {
        }
    }
}
