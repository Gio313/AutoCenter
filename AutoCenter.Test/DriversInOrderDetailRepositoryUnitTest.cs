using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    class DriversInOrderDetailRepositoryUnitTest : RepositoryTestBase<DriversInOrderDetail>
    {
        public DriversInOrderDetailRepositoryUnitTest() : base(new DriversInOrderDetailRepository())
        {

        }
    }
}
