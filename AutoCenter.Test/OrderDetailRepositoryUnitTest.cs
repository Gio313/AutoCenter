using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    class OrderDetailRepositoryUnitTest : RepositoryTestBase<OrderDetail>
    {
        public OrderDetailRepositoryUnitTest() : base(new OrderDetailRepository())
        {

        }
    }
}
