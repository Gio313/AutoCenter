using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    [TestClass]
    public class OrderStatusRepositoryUnitTest : RepositoryTestBase<OrderStatus>
    {
        public OrderStatusRepositoryUnitTest() : base(new OrderStatusRepository())
        {

        }

        protected override ICollection<OrderStatus> GetInsertParameters()
        {
            return new List<OrderStatus>
            {
                new OrderStatus() {StatusName = "gadazidulia" }
            };
        }
    }
}
