using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest.Manager
{
    [TestClass]
    public class TeamSqlManagerTest
    {
        [TestMethod]
        public void TestGetTeams()
        {
            TeamSqlManager manager = new TeamSqlManager();
            List<ITeam> teams = manager.GetTeams();
            Assert.IsTrue(teams.Count > 0);
        }

        [TestMethod]
        public void TestFindById()
        {
            TeamSqlManager manager = new TeamSqlManager();
            ITeam team = manager.FindById(1);
            Assert.IsTrue(team != null);
        }

        [TestMethod]
        public void TestFindByIdNotExists()
        {
            TeamSqlManager manager = new TeamSqlManager();
            ITeam team = manager.FindById(0);
            Assert.IsTrue(team == null);
        }
    }
}
