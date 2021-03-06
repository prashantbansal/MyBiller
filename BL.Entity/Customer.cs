﻿namespace BL.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber1 { get; set; }

        public string PhoneNumber2 { get; set; }

        public Address AddressDetails { get; set; }

        public Customer()
        {
            AddressDetails = new Address();
        }
    }
}
