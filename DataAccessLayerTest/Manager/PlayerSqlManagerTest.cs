using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest.Manager
{
    [TestClass]
    public class PlayerSqlManagerTest
    {
        [TestMethod]
        public void TestGetPlayers()
        {
            PlayerSqlManager manager = new PlayerSqlManager();
            List<IPlayer> players = manager.GetPlayers();
            Assert.IsTrue(players.Count > 0);
        }

        [TestMethod]
        public void TestFindById()
        {
            PlayerSqlManager manager = new PlayerSqlManager();
            IPlayer player = manager.FindById(1);
            Assert.IsTrue(player != null);
        }

        [TestMethod]
        public void TestFindByIdNotExists()
        {
            PlayerSqlManager manager = new PlayerSqlManager();
            IPlayer player = manager.FindById(0);
            Assert.IsTrue(player == null);
        }
    }
}
