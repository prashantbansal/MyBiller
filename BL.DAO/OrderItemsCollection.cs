using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Data;

namespace BL.Entity
{
    public class OrderItemsCollection : List<OrderItem>, IEnumerable<SqlDataRecord>
    {
        private readonly List<OrderItem> orderItemList;
        public OrderItemsCollection(List<OrderItem> list)
        {
            this.orderItemList = list;
        }
        public new IEnumerator<SqlDataRecord> GetEnumerator()
        {
            SqlDataRecord returnValue = new SqlDataRecord(
                 new SqlMetaData("ItemId", SqlDbType.Int),
                    new SqlMetaData("Quantity", SqlDbType.Int),
                    new SqlMetaData("PricePerItem", SqlDbType.Decimal),
                    new SqlMetaData("TotalPrice", SqlDbType.Decimal)
                );

            foreach (var item in orderItemList)
            {
                returnValue.SetInt32(0, item.ItemId);
                returnValue.SetInt32(1, item.Quantity);
                returnValue.SetDecimal(2, item.PricePerItem);
                returnValue.SetDecimal(3, item.TotalPrice);
                yield return returnValue;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
