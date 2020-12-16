﻿using AutoCenter.Domain.Models;
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
    public class CategoryRepositoryUnitTest : RepositoryBase<Category>
    {
        public CategoryRepositoryUnitTest() : base(new CategoryRepository())
        {

        }
    }
}
