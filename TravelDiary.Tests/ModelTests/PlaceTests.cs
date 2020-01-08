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

        [TestMethod]
        public void GetAll_ReturnsAllItems_PlaceList()
        {
            Place instance1 = new Place("Denver", 13);
            Place instance2 = new Place("Seattle", 12);

            List<Place> newList = new List<Place> { instance1, instance2 };
            List<Place> result = Place.GetAll();
            Console.WriteLine(result);
            CollectionAssert.AreEqual(newList, result);
        }
       
    }
}