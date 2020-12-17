using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    public class CustomerRepositoryUnitTest : RepositoryTestBase<Customer>
    {
        public CustomerRepositoryUnitTest() : base(new CustomerRepository())
        {

        }

        protected override ICollection<Customer> GetInsertParameters()
        {
            return new List<Customer>
            {
                new Customer() { },
            };
        }
    }
}
