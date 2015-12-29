namespace BL.Entity
{
    public class BLMenu
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Enums.ItemCategory Category { get; set; }

        public Enums.ItemType Type { get; set; }

        public decimal Price { get; set; }

        public Enums.ItemStatus Status { get; set; }

        public int Quantity { get; set; }

        public decimal ItemTotal { get; set; }

        public BLMenu()
        {
            Quantity = 0;
        }
    }
}
