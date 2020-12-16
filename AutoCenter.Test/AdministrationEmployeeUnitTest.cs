using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Test
{
    public class AdministrationEmployeeUnitTest : RepositoryTestBase<AdministrationEmployee>  
    {
        public AdministrationEmployeeUnitTest() : base(new AdministrationEmployeeRepository())
        {
                
        }
    }
}
