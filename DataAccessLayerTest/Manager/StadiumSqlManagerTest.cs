using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest.Manager
{
    [TestClass]
    public class StadiumSqlManagerTest
    {
        [TestMethod]
        public void TestGetStadiums()
        {
            StadiumSqlManager manager = new StadiumSqlManager();
            List<IStadium> stadiums = manager.GetStadiums();
            Assert.IsTrue(stadiums.Count > 0);
        }

        [TestMethod]
        public void TestFindById()
        {
            StadiumSqlManager manager = new StadiumSqlManager();
            IStadium stadium = manager.FindById(1);
            Assert.IsTrue(stadium != null);
        }

        [TestMethod]
        public void TestFindByIdNotExists()
        {
            StadiumSqlManager manager = new StadiumSqlManager();
            IStadium stadium = manager.FindById(0);
            Assert.IsTrue(stadium == null);
        }
    }
}
