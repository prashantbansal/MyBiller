namespace BL.Entity
{
    public class Enums
    {
        public enum ItemCategory
        {
            Lunch = 1,
            Dinner = 2,
            Breakfast = 3,
            Snacks = 4
        }

        public enum ItemType
        {
            Veg = 1,
            NonVeg = 2
        }

        public enum OrderStatus
        {
            Pending = 1,
            Delivered = 2,
            Cancelled = 3
        }

        public enum ItemStatus
        {
            Active = 1,
            Deleted = 2,
        }

    }
}
