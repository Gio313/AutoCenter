using AutoCenter.Domain.Interfaces.Repositories;
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
    public class TechnicianRepositoryUnitTest : RepositoryTestBase<Technician>
    {  
        public TechnicianRepositoryUnitTest() : base(new TechnicianRepository())
        {
           
        }

        protected override ICollection<Technician> GetInsertParameters()
        {
            return new List<Technician>
            {
                new Technician() { FirstName = "Gio", LastName = "Zviadauri", PersonalNumber = "0205050303"}
            };
        }
    }
}
