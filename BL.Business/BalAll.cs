using BL.DAO;
using BL.Entity;
using System.Collections.Generic;

namespace BL.Business
{
    public class BalAll
    {
        private DAOAll _dao;
        public DAOAll DaoObj 
        {
            get
            {
                if (_dao != null)
                {
                    return _dao;
                }
                else
                {
                    _dao = new DAOAll();
                    return _dao;
                }
            }
        }

        public IList<Customer> GetCustomerList(Customer searchCriteria)
        {
        
            return DaoObj.GetCustomerList(searchCriteria);
        }

        public IList<BLMenu> GetMenuList(Enums.ItemStatus itemStatus)
        {
            return DaoObj.GetMenuList(itemStatus);
        }

        public Customer GetCustomerInformation(int customerId, int addressId)
        {
            return DaoObj.GetCustomerInformation(customerId, addressId);
        }

        public OrderResponse SaveOrder(Customer customer, Order order)
        {
            return DaoObj.SaveOrder(customer, order);
        }

        public Order GetOrder(int orderId)
        {
            return DaoObj.GetOrder(orderId);
        }

        public IList<Order> GetOrderList(Enums.OrderStatus orderStatus)
        {
            return DaoObj.GetOrderList(orderStatus);
        }

        public int UpdateOrderStatus(int orderId, Enums.OrderStatus orderStatus)
        {
            return DaoObj.UpdateOrderStatus(orderId, orderStatus);
        }

        public BLMenu GetMenuItem(int itemId)
        {
            return DaoObj.GetMenuItem(itemId);
        }

        public int SaveMenuItem(BLMenu blMenu)
        {
            return DaoObj.SaveMenuItem(blMenu);
        }
    }
}
