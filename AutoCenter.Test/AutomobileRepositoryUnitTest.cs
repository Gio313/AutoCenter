using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    public class AutomobileRepositoryUnitTest : RepositoryTestBase<Automobile>
    {
        public AutomobileRepositoryUnitTest() : base(new AutomobileRepository())
        {

        }
    }
}
