using AutoCenter.Repository;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoCenter.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace AutoCenter.Test
{
    [TestClass]
    public abstract class RepositoryTestBase<TEntity> : TestBase 
    where TEntity : class
    {
        protected IRepositoryBase<TEntity> _repository;

        public RepositoryTestBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;    
        }

        protected abstract ICollection<TEntity> GetInsertParameters();


        [TestMethod]
        public virtual void Create_CallMethod()
        {
            foreach (var item in GetInsertParameters())
            {
                int expected = 1;
                _repository.Create(item);
                int ex = _repository.Save();
                Assert.AreEqual(expected, ex, "Is not working!");
            }
        }
        /*
        [TestMethod]
        public virtual void Update_CallMethod()
        {
            foreach (var item in GetInsertParameters())
            {
                bool expected = true;
                _repository.Update(item);
                Assert.AreEqual(expected, _repository.Save(), "Is not working!");
            }
        }
        */
    }
}
