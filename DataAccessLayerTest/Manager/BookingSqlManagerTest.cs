using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAcessLayer.Manager;
using DataAccessLayer;
using System.Collections.Generic;

namespace DataAccessLayerTest
{
    [TestClass]
    public class BookingSqlManagerTest
    {
        [TestMethod]
        public void TestGetBookings()
        {
            BookingSqlManager manager = new BookingSqlManager();
            List<IBooking> bookings = manager.GetBookings();
            Assert.IsTrue(bookings.Count > 0);
        }
    }
}
