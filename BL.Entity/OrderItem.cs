namespace BL.Entity
{
    public class OrderItem
    {
        public int OrderId { get; set; }

        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public int Quantity { get; set; }

        public decimal PricePerItem { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
