using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    public class OrderStatusRepositoryUnitTest : RepositoryTestBase<OrderStatus>
    {
        public OrderStatusRepositoryUnitTest() : base(new OrderStatusRepository())
        {

        }
    }
}
