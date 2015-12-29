using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.OrderItems = new List<OrderItem>();
            this.CustomerDetails = new Customer();
            this.AddressDetails = new Address();
        }
    }
}
