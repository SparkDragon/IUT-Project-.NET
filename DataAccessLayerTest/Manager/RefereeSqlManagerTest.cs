using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest.Manager
{
    [TestClass]
    public class RefereeSqlManagerTest
    {
        [TestMethod]
        public void TestGetReferees()
        {
            RefereeSqlManager manager = new RefereeSqlManager();
            List<IReferee> referees = manager.GetReferees();
            Assert.IsTrue(referees.Count > 0);
        }

        [TestMethod]
        public void TestFindById()
        {
            RefereeSqlManager manager = new RefereeSqlManager();
            IReferee referee = manager.FindById(1);
            Assert.IsTrue(referee != null);
        }

        [TestMethod]
        public void TestFindByIdNotExists()
        {
            RefereeSqlManager manager = new RefereeSqlManager();
            IReferee referee = manager.FindById(0);
            Assert.IsTrue(referee == null);
        }
    }
}
