using AutoCenter.Domain.Models;
using AutoCenter.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutoCenter.Test
{
    public class CategoryRepositoryUnitTest : RepositoryTestBase<Category>
    {
        public CategoryRepositoryUnitTest() : base(new CategoryRepository())
        {

        }
        protected override ICollection<Category> GetInsertParameters()
        {
            return new List<Category>
            {
                new Category() { },
            };
        }
    }
}
