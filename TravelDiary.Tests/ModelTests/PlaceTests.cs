using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TravelDiary.Models;
using System;

namespace TravelDiary.TestTools
{
    [TestClass]
    public class PlaceTest : IDisposable
    {
        public void Dispose()
        {
            Place.ClearAll();
        }

        [TestMethod]
        public void PlaceConstructor_CreatesInstanceOfPlace_Place()
        {
            Place newPlace = new Place("Seattle", 12);
            Assert.AreEqual(typeof(Place), newPlace.GetType());
        }

        
    }
}