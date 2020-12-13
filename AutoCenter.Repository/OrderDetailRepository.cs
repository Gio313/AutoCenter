using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class OrderDetailRepository : RepositoryBase<OrderDetail>
    {
        public override bool Update(OrderDetail entity) => throw new NotSupportedException("OrderDetailRepository has not update method!");

        public override bool Delete(int id) => throw new NotImplementedException("OrderDetailRepository has not delete method!");
    }
}
