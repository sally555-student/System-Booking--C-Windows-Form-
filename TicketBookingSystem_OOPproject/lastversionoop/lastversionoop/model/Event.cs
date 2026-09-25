using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lastversionoop.model;

namespace lastversionoop.model
{
    public class Event
    {
        public int EventID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }

        //Constructor

        public Event(int EventID, string Name, string Category, DateTime Date, int Price, int seats)
        {
            this.EventID = EventID;
            this.Title = Name;
            this.Category = Category;
            this.Date = Date;
            this.Price = Price;
            TotalSeats = seats;
            AvailableSeats = seats;
        }
        public Event()
        {

        }
        public bool ReserveSeats(int seatnumber)
        {
            if (AvailableSeats < seatnumber)
            {
                return false;
            }
            AvailableSeats -= seatnumber;
            return true;
        }
        public void CancelSeats(int seatnb)
        {
           
            AvailableSeats += seatnb;

            if (AvailableSeats > TotalSeats)
            {
                AvailableSeats = TotalSeats;
            }
        }

        /*public override string ToString()
        {
            return $"{Title} | Category: {Category}";
        }*/
        public override string ToString()
        {  
            return $"Event{EventID}: \t {Title} \t Category: {Category} \t Date: {Date.ToShortDateString()} \t  Seats available: {AvailableSeats} \t Price:{Price}$"; ;
        }
       
    }
}
