using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(AutoCenterDbContext db) : base(db)
        {
        }

        public override bool Update(Order entity) => throw new NotSupportedException("OrderRepository has not update method!");

        public override bool Delete(int id) => throw new NotImplementedException("OrderRepository has not delete method!");
    }
}
