using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    public class OrderRepositoryUnitTest : RepositoryTestBase<Order>
    {
        public OrderRepositoryUnitTest() : base(new OrderRepository())
        {

        }

        protected override ICollection<Order> GetInsertParameters()
        {
            return new List<Order>
            {
                new Order() { },
            };
        }
    }
}
