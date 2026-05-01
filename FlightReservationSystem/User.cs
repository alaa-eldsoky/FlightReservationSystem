using System;

namespace FlightReservationSystem
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string u, string p)
        {
            Username = u;
            Password = p;
        }
    }

}