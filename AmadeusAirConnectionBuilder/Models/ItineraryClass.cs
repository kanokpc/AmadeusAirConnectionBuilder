using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AmadeusAirConnectionBuilder.Models
{
    public class AirConnection
    {
        public string fromdata { get; set; }
        public string todata { get; set; }
        public decimal costdata { get; set; }

        public AirConnection()
        {
        }

        public AirConnection(string from, string to, decimal cost)
        {
            this.fromdata = from;
            this.todata = to;
            this.costdata = cost;
        }

        public List<AirConnection> GetAllData()
        {
            List<AirConnection> ItineraryList = new List<AirConnection>();
            ItineraryList.Add(new AirConnection("A", "B", 60));
            ItineraryList.Add(new AirConnection("A", "C", 150));
            ItineraryList.Add(new AirConnection("B", "C", 50));
            ItineraryList.Add(new AirConnection("B", "E", 80));
            ItineraryList.Add(new AirConnection("C", "B", 220));
            ItineraryList.Add(new AirConnection("C", "G", 350));
            ItineraryList.Add(new AirConnection("D", "I", 120));
            ItineraryList.Add(new AirConnection("E", "A", 70));
            ItineraryList.Add(new AirConnection("E", "C", 85));
            ItineraryList.Add(new AirConnection("F", "A", 230));
            ItineraryList.Add(new AirConnection("F", "G", 110));
            ItineraryList.Add(new AirConnection("G", "F", 90));
            ItineraryList.Add(new AirConnection("G", "H", 75));
            ItineraryList.Add(new AirConnection("H", "I", 35));
            ItineraryList.Add(new AirConnection("I", "C", 90));
            ItineraryList.Add(new AirConnection("I", "D", 30));

            return ItineraryList;
        }
    }
}