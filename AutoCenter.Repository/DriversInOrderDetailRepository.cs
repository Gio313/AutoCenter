using AutoCenter.Domain.Interfaces.Repositories;
using AutoCenter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoCenter.Repository
{
    public class DriversInOrderDetailRepository : RepositoryBase<DriversInOrderDetail>
    {
        public override void Update(DriversInOrderDetail entity) => throw new NotSupportedException("DriversInOrderDetailRepository has not update method!");

        public override void Delete(int id) => throw new NotImplementedException("DriversInOrderDetailRepository has not delete method!");
    }
}
