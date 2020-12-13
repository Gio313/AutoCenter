using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class OrderStatusRepository : RepositoryBase<OrderStatus>
    {
        public OrderStatusRepository(AutoCenterDbContext db) : base(db)
        {
        }
    }
}
