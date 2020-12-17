using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    public class EmployeeRepositoryUnitTest : RepositoryTestBase<Employee>
    {
        public EmployeeRepositoryUnitTest() : base(new EmployeeRepository())
        {

        }

        protected override ICollection<Employee> GetInsertParameters()
        {
            return new List<Employee>
            {
                new Employee() { },
            };
        }

    }
}
