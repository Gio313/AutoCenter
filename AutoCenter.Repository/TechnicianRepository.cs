using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class TechnicianRepository : RepositoryBase<Technician>
    {
        public TechnicianRepository(AutoCenterDbContext db) : base(db)
        {
        }
    }
}
