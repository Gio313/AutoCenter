using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class OrderDetailRepository : RepositoryBase<OrderDetail>
    {
        public override void Update(OrderDetail entity) => throw new NotSupportedException("OrderDetailRepository has not update method!");

        public override void Delete(int id) => throw new NotImplementedException("OrderDetailRepository has not delete method!");
    }
}
