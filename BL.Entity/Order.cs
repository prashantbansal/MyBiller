using System;
using System.Collections.Generic;

namespace BL.Entity
{
    public class Order
    {
        public int OrderId { get; set; }

        public decimal TotalWithoutTax { get; set; }

        public Enums.OrderStatus Status { get; set; }

        public decimal Tax { get; set; }

        public decimal Discount { get; set; }

        public decimal Total { get; set; }

        public DateTime PlacedOn { get; set; }

        public string CustomerName { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public Customer CustomerDetails { get; set; }

        public Address AddressDetails { get; set; }

        public Order()
        {
            OrderItems = new List<OrderItem>();
            CustomerDetails = new Customer();
            AddressDetails = new Address();
        }
    }
}
