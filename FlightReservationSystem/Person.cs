using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservationSystem
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Person(string name, string id)
        {
            Name = name;
            Id = id;
        }

    }

     public class Passenger : Person
    {
        public string Passport { get; set; }
        public string Email { get; set; }

        public Passenger(string name, string id, string passport, string email) : base(name, id)
        {
            Email = email;
            Passport = passport;
        }

    
    }



}
