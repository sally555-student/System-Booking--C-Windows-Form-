using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lastversionoop.model;

namespace lastversionoop.model
{
    public class Booking
    {
        private static int counter = 1;

        public int bookingId { get; set; }
        public User user { get; set; }
        public Event Event { get; set; }
        public int seatnumber { get; set; }
        public string status { get; set; }//confirmed or cancelled
        public int TotalPrice { get; set; }

        public Booking ()
        {

        }
        public Booking(User user, Event Event, int seatnumber, string status)

        {
            bookingId = counter++;
            this.user = user;
            this.Event = Event;
            this.seatnumber = seatnumber;
            this.TotalPrice = Event.Price * seatnumber;
            this.status = status;

        }
        public override string ToString()
        {
            return string.Format("{0,-10}{1,-15}{2,-20}{3,-25}{4,-10}{5,-15} {6,-20}",$"User nb:{user.userID}", $" Booking:{bookingId}", user.Name, Event.Title,  $"Seats:{seatnumber}",$"Total:{TotalPrice} ",$"Status:{status}");
        }


    }
}
