﻿using System;


namespace Order.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        override public string ToString()
        {
            return Name 
                + " (" 
                + BirthDate.ToString("dd/MM/yyyy") 
                + ") - " 
                + Email;
        }
    }
}
