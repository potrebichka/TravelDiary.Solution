using System;
using System.Collections.Generic;

namespace TravelDiary.Models
{
    public class Place
    {
        public string CityName { get; set; }
        public int LengthOfStay { get; set; }
        public int Id { get; set; }
        private static List<Place> places = new List<Place> { };

        public Place(string cityName, int lengthOfStay)
        {
            this.CityName = cityName;
            this.LengthOfStay = lengthOfStay;
            places.Add(this);
            this.Id = places.Count;
        }

        public static void ClearAll()
        {
            places.Clear();
        }

        public static List<Place> GetAll()
        {
            return places;
        }

        public static Place Find(int searchId)
        {
            return places[searchId -1];
        }

    }
}

