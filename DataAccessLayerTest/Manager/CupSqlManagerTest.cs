using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest.Manager
{
    [TestClass]
    public class CupSqlManagerTest
    {
        [TestMethod]
        public void TestGetCups()
        {
            CupSqlManager manager = new CupSqlManager();
            List<ICup> cups = manager.GetCups();
            Assert.IsTrue(cups.Count > 0);
        }

        [TestMethod]
        public void TestFindById()
        {
            CupSqlManager manager = new CupSqlManager();
            ICup cup = manager.FindById(1);
            Assert.IsTrue(cup != null);
        }

        [TestMethod]
        public void TestFindByIdNotExists()
        {
            CupSqlManager manager = new CupSqlManager();
            ICup cup = manager.FindById(0);
            Assert.IsTrue(cup == null);
        }
    }
}
