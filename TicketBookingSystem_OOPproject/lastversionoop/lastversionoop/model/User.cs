using lastversionoop.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace lastversionoop.model
{
    public class User
    {
        public string Name { get; set; }
        public int userID { get; set; }
        public string contact { get; set; } // via email

        [JsonIgnore]
        public  List<Booking> BookedEvents { get; set; }= new List<Booking>();

       
        
        public User() { }
        
        public User(string name, string Contact)
        {
            Name = name;
            contact = Contact;
            BookedEvents = new List<Booking>();
        }
    }
}
