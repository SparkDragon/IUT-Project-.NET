using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest.Manager
{
    [TestClass]
    public class SpectatorSqlManagerTest
    {
        [TestMethod]
        public void TestGetSpectators()
        {
            SpectatorSqlManager manager = new SpectatorSqlManager();
            List<ISpectator> spectators = manager.GetSpectators();
            Assert.IsTrue(spectators.Count > 0);
        }

        [TestMethod]
        public void TestFindById()
        {
            SpectatorSqlManager manager = new SpectatorSqlManager();
            ISpectator spectator = manager.FindById(1);
            Assert.IsTrue(spectator != null);
        }

        [TestMethod]
        public void TestFindByIdNotExists()
        {
            SpectatorSqlManager manager = new SpectatorSqlManager();
            ISpectator spectator = manager.FindById(0);
            Assert.IsTrue(spectator == null);
        }
    }
}
