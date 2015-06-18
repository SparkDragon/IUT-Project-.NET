using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest.Manager
{
    [TestClass]
    public class MatchSqlManagerTest
    {
        [TestMethod]
        public void TestGetMatches()
        {
            MatchSqlManager manager = new MatchSqlManager();
            List<IMatch> matches = manager.GetMatches();
            Assert.IsTrue(matches.Count > 0);
        }

        [TestMethod]
        public void TestGetMatchSpectators()
        {
            MatchSqlManager manager = new MatchSqlManager();
            List<ISpectator> spectators = manager.GetMatchSpectators(1);
            Assert.IsTrue(spectators.Count > 0);
        }

        [TestMethod]
        public void TestFindById()
        {
            MatchSqlManager manager = new MatchSqlManager();
            IMatch macth = manager.FindById(1);
            Assert.IsTrue(macth != null);
        }

        [TestMethod]
        public void TestFindByIdNotExists()
        {
            MatchSqlManager manager = new MatchSqlManager();
            IMatch macth = manager.FindById(0);
            Assert.IsTrue(macth == null);
        }
    }
}
