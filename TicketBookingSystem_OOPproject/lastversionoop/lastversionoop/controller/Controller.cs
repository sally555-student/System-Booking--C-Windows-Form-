using lastversionoop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace lastversionoop.controller
{
    public class Controller
    {
        private const string FIle = "data.json";

        public delegate void BookingEventHandler(Booking booking);
        public delegate void EventAddedHandler(Event ev);

        public List<Event> Events { get; set; } = new List<Event>();
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public List<User> Users { get; set; }=new List<User>();

        public int PriceEvent = 0;

        public event BookingEventHandler OnCreatedBooking;
        public event BookingEventHandler OnCancelledBooking;
        public event BookingEventHandler OnUpdatebooking;
        

        public Controller()
        {
            loaddata();
        }

        //save data
        public void SaveData()
        {
            DatabaseModel data =  new DatabaseModel
            {
                Events = Events,
                Users = Users,
                Bookings = Bookings
            };
            string json=JsonSerializer.Serialize(data,new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FIle, json);
        }

        public void loaddata()
        {
            if (!File.Exists(FIle))
            {
                SaveData();
                return;
            }
            string json = File.ReadAllText(FIle);
            var data = JsonSerializer.Deserialize<DatabaseModel>(json);
            Events = data.Events ?? new List<Event>();
            Users = data.Users ?? new List<User>();
            Bookings = data.Bookings ?? new List<Booking>();
            foreach (var b in Bookings)
            {
                if (b.user == null) continue;

                var user = Users.FirstOrDefault(u => u.userID == b.user.userID);
                var ev = Events.FirstOrDefault(e => e.EventID == b.Event.EventID);
                if (user != null)
                {
                    b.user= user;
                    user.BookedEvents.Add(b);
                }
                if(ev!=null)
                    b.Event= ev;
            }
        }

        public class DatabaseModel
        {
            public List<Event> Events {  get; set; }
            public List<User> Users{ get; set; }
            public List<Booking> Bookings { get; set; }
        }

        //add event
        public void ADDEVENT (Event e)
        {
            Events.Add(e);
            SaveData();
        }

        // remove event
        public bool REMOVEEVENT(Event e)
        {
            if(e==null) return false;   
           
            foreach(Booking b in  Bookings)
            {
                if(b.Event==e)
                {
                    b.status = "Removed";
                }
            } 
            Events.Remove(e );
            SaveData() ;
            return true;
        }

        //update seats
        public void UpdateSeats(Event ev , int seats)
        {
            if (ev != null)
            {
                ev.TotalSeats = seats;
                ev.AvailableSeats = seats;
                SaveData();
            }
        }

        //booking
        public Booking ConfirmBooking(User user,Event e,int seatnumber)
        {
            if (seatnumber <= 0) return null;
            if (!e.ReserveSeats(seatnumber)) return null;
            Booking b = new Booking(user, e, seatnumber, "Confirmed");
            user.BookedEvents.Add(b);
            Bookings.Add(b);

            OnCreatedBooking ?. Invoke(b);
           

            return b;
        }

        //cancel
        public void CancelBooking(User user, Booking b)
        {
            if (b.status != "Cancelled")
            {
               
                b.Event.CancelSeats(b.seatnumber);

                 b.status = "Cancelled";
               OnCancelledBooking?.Invoke(b);    
               
            }
        }
           public void updatebooking(Booking b,int seatnumber)
        {
            if (b.status != "Confirmed") return;
            if (seatnumber < 0) return;
            int d =  seatnumber- b.seatnumber;
            if (d > 0)
            {
                if (d > b.Event.AvailableSeats) return;
                b.Event.AvailableSeats -= d;
            }
            if(d<0)
            b.Event.AvailableSeats +=(- d);
            b.seatnumber = seatnumber; ;
            b.TotalPrice = b.Event.Price * b.seatnumber;
            b.status = (b.seatnumber == 0) ? "Cancelled" : "Confirmed";
            OnUpdatebooking?.Invoke(b);
        }
       

        // returns events on that date (date only comparison)
        public List<Event> SearchByDate(DateTime date)
        {
            return Events.Where(e => e.Date.Date == date.Date).ToList();
        }

        // returns events whose category matches (case-insensitive)
        public List<Event> SearchByCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category)) 
                return new List<Event>();

            return Events.Where(e => e.Category != null && e.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // returns events with price between min and max (inclusive)
        public List<Event> SearchByPriceRange(int minPrice, int maxPrice)
        {
            if (minPrice > maxPrice) 
                return new List<Event>();

            return Events.Where(e => e.Price >= minPrice && e.Price <= maxPrice).ToList();
        }

        public void SaveListBoxToFile(ListBox listBox)
        {
            string path = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "summary.txt" );

            using (StreamWriter sw = new StreamWriter(path))
            {

                foreach (var item in listBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
        
            }
       
        System.Diagnostics.Process.Start( new System.Diagnostics.ProcessStartInfo { FileName = path, UseShellExecute = true } );
      
        }
    }

}

