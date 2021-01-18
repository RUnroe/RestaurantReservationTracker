using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservationTracker.Models
{
    public class Reservation
    {
        public int ID { get; set; }
        public string DateTime { get; set; } = "1970-1-1T00:00";
        public string Name { get; set; } = "[NO NAME]";
        public int Size { get; set; } = 0;
        public bool InSmokingSection { get; set; } = false;
        public string SpecialInstructions { get; set; } = "";
        public string ContactNumber { get; set; } = "[NO NUMBER]";
        public bool CanText { get; set; } = false;


        public Reservation() { }

        public Reservation(int id, string dateTime, string name, int size, bool inSmokingSection, string specialInstructions, string contactNumber, bool canText)
        {
            this.ID = id;
            this.DateTime = dateTime;
            this.Name = name;
            this.Size = size;
            this.InSmokingSection = inSmokingSection;
            this.SpecialInstructions = specialInstructions;
            this.ContactNumber = contactNumber;
            this.CanText = canText;

        }

        public string getDate()
        {
            return $"{this.DateTime.Split('-')[1]}/{this.DateTime.Split('-')[2].Split("T")[0]}";
        }

        public string getTime()
        {
            return this.DateTime.Split("T")[1];
        }
        public override string ToString()
        {
            string date = this.getDate();
            string time = this.getTime();
            return $"{time} {date} name"; 
        }
    }
}
