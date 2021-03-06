﻿using BL.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BL.DAO
{
    public class DAOAll
    {
        public IList<Customer> GetCustomerList(Customer searchCriteria)
        {
            IList<Customer> customerList = new List<Customer>();
            using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                StoredProcedures.GetCustomerList,
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pFirstName",
                                              Value = searchCriteria.FirstName,
                                              DbType = DbType.String
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pLastName",
                                              Value = searchCriteria.LastName,
                                              DbType = DbType.String
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pPhoneNumber1",
                                              Value = searchCriteria.PhoneNumber1,
                                              DbType = DbType.String
                                          }))
            {
                while (reader.Read())
                {
                    var customer = new Customer
                    {
                        CustomerId = reader.TryGetValue<int>("CustomerId"),
                        FirstName = reader.TryGetValue<string>("FirstName"),
                        LastName = reader.TryGetValue<string>("LastName"),
                        PhoneNumber1 = reader.TryGetValue<string>("PhoneNumber1"),
                        Email = reader.TryGetValue<string>("Email"),
                        AddressDetails =
                        {
                            AddressId = reader.TryGetValue<int>("AddressId"),
                            AddressLine1 = reader.TryGetValue<string>("AddressLine1"),
                            AddressLine2 = reader.TryGetValue<string>("AddressLine2"),
                            City = reader.TryGetValue<string>("City"),
                            PinCode = reader.TryGetValue<string>("PinCode")
                        }
                    };


                    customerList.Add(customer);
                }
            }
            return customerList;
        }

        public IList<BLMenu> GetMenuList(Enums.ItemStatus itemStatus)
        {
            IList<BLMenu> menuList = new List<BLMenu>();
            using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                StoredProcedures.GetMenuList,
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pItemStatus",
                                              Value = (int)itemStatus,
                                              DbType = DbType.Int32
                                          }))
            {
                while (reader.Read())
                {
                    var menu = new BLMenu
                    {
                        ItemId = reader.TryGetValue<int>("ItemId"),
                        Name = reader.TryGetValue<string>("Name"),
                        Description = reader.TryGetValue<string>("Description"),
                        Category = reader.TryGetValue<Enums.ItemCategory>("Category"),
                        Type = reader.TryGetValue<Enums.ItemType>("Type"),
                        Price = reader.TryGetValue<decimal>("Price")
                    };

                    menuList.Add(menu);
                }
            }
            return menuList;
        }

        public IList<Order> GetOrderList(Enums.OrderStatus orderStatus)
        {
            IList<Order> orderList = new List<Order>();
            using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                StoredProcedures.GetOrderList,
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pOrderStatus",
                                              Value = (int)orderStatus,
                                              DbType = DbType.Int32
                                          }))
            {
                while (reader.Read())
                {
                    var order = new Order
                    {
                        OrderId = reader.TryGetValue<int>("OrderId"),
                        Status = reader.TryGetValue<Enums.OrderStatus>("Status"),
                        Total = reader.TryGetValue<decimal>("Total"),
                        CustomerName = reader.TryGetValue<string>("CustomerName"),
                        PlacedOn = reader.TryGetValue<DateTime>("PlacedOn")
                    };
                    orderList.Add(order);
                }
            }
            return orderList;
        }

        public Customer GetCustomerInformation(int customerId, int addressId)
        {
            Customer customer = null;          
            using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                StoredProcedures.GetCustomerInformation,
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pCustomerId",
                                              Value = customerId,
                                              DbType = DbType.Int32
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pAddressId",
                                              Value = addressId,
                                              DbType = DbType.Int32
                                          }))
            {
                while (reader.Read())
                {
                    customer = new Customer
                    {
                        CustomerId = reader.TryGetValue<int>("CustomerId"),
                        FirstName = reader.TryGetValue<string>("FirstName"),
                        LastName = reader.TryGetValue<string>("LastName"),
                        PhoneNumber1 = reader.TryGetValue<string>("PhoneNumber1"),
                        Email = reader.TryGetValue<string>("Email")
                    };

                    if (addressId > -1)
                    {
                        customer.AddressDetails = new Address
                        {
                            AddressId = addressId,
                            AddressLine1 = reader.TryGetValue<string>("AddressLine1"),
                            AddressLine2 = reader.TryGetValue<string>("AddressLine2"),
                            City = reader.TryGetValue<string>("City"),
                            PinCode = reader.TryGetValue<string>("PinCode")
                        };

                    }
                }
            }
            return customer;
        }

        public Order GetOrder(int orderId)
        {
            Order order = new Order();
            using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                StoredProcedures.GetOrder,
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pOrderId",
                                              Value = orderId,
                                              DbType = DbType.Int32
                                          }))
            {
                while (reader.Read())
                {
                    order.OrderId = reader.TryGetValue<int>("OrderID");
                    order.TotalWithoutTax = reader.TryGetValue<decimal>("TotalWithoutTax");
                    order.Tax = reader.TryGetValue<decimal>("Tax");
                    order.Discount = reader.TryGetValue<decimal>("Discount");
                    order.Total = reader.TryGetValue<decimal>("Total");
                    order.Status = reader.TryGetValue<Enums.OrderStatus>("Status");
                    order.PlacedOn = reader.TryGetValue<DateTime>("PlacedOn");
                    order.CustomerDetails.CustomerId = reader.TryGetValue<int>("CustomerId");
                    order.CustomerDetails.FirstName = reader.TryGetValue<string>("FirstName");
                    order.CustomerDetails.LastName = reader.TryGetValue<string>("LastName");
                    order.CustomerDetails.PhoneNumber1 = reader.TryGetValue<string>("PhoneNumber1");
                    order.CustomerDetails.Email = reader.TryGetValue<string>("Email");
                    order.AddressDetails.AddressId = reader.TryGetValue<int>("AddressId");
                    order.AddressDetails.AddressLine1 = reader.TryGetValue<string>("AddressLine1");
                    order.AddressDetails.AddressLine2 = reader.TryGetValue<string>("AddressLine2");
                    order.AddressDetails.City = reader.TryGetValue<string>("City");
                    order.AddressDetails.PinCode = reader.TryGetValue<string>("Pincode");
                }

                if (reader.NextResult())
                {
                    while (reader.Read())
                    {
                        var orderItem = new OrderItem
                        {
                            ItemId = reader.TryGetValue<int>("ItemID"),
                            ItemName = reader.TryGetValue<string>("ItemName"),
                            Quantity = reader.TryGetValue<int>("Quantity"),
                            PricePerItem = reader.TryGetValue<decimal>("PricePerItem"),
                            TotalPrice = reader.TryGetValue<decimal>("TotalPrice")
                        };
                        order.OrderItems.Add(orderItem);
                    }
                }
            }
            return order;
        }

        public OrderResponse SaveOrder(Customer customer, Order order)
        {
            try
            {
                OrderResponse orderResponse = new OrderResponse();
                using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                    StoredProcedures.SaveOrder,
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pCustomerId",
                                                  Value = customer.CustomerId,
                                                  DbType = DbType.Int32
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pFirstName",
                                                  Value = customer.FirstName,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pLastName",
                                                  Value = customer.LastName,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pEmail",
                                                  Value = customer.Email,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pPhoneNumber",
                                                  Value = customer.PhoneNumber1,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pAddressId",
                                                  Value = customer.AddressDetails.AddressId,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pAddressLine1",
                                                  Value = customer.AddressDetails.AddressLine1,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pAddressLine2",
                                                  Value = customer.AddressDetails.AddressLine2,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pCity",
                                                  Value = customer.AddressDetails.City,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pPinCode",
                                                  Value = customer.AddressDetails.PinCode,
                                                  DbType = DbType.String
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pOrderId",
                                                  Value = order.OrderId,
                                                  DbType = DbType.Int32
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pTotalWithoutTax",
                                                  Value = order.TotalWithoutTax,
                                                  DbType = DbType.Decimal
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pStatus",
                                                  Value = (int)order.Status,
                                                  DbType = DbType.Int32
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pTax",
                                                  Value = order.Tax,
                                                  DbType = DbType.Decimal
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pDiscount",
                                                  Value = order.Discount,
                                                  DbType = DbType.Decimal
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pTotal",
                                                  Value = order.Total,
                                                  DbType = DbType.Decimal
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pOrderList",
                                                  Value = new OrderItemsCollection(order.OrderItems),
                                                  SqlDbType = SqlDbType.Structured
                                              }))
                {
                    while (reader.Read())
                    {
                        orderResponse.CustomerId = reader.TryGetValue<int>("CustomerId");
                        orderResponse.AddressId = reader.TryGetValue<int>("AddressId");
                        orderResponse.OrderId = reader.TryGetValue<int>("OrderId");
                    }
                }
                return orderResponse;
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        public int UpdateOrderStatus(int orderId, Enums.OrderStatus orderStatus)
        {
            try
            {
                int response = -1;
                using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                    StoredProcedures.UpdateOrderStatus,
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pOrderId",
                                                  Value = orderId,
                                                  DbType = DbType.Int32
                                              },
                                              new SqlParameter()
                                              {
                                                  ParameterName = "@pOrderStatus",
                                                  Value = (int)orderStatus,
                                                  DbType = DbType.Int32
                                              }))
                {
                    while (reader.Read())
                    {
                        response = reader.TryGetValue<int>("Response");
                        
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public BLMenu GetMenuItem(int itemId)
        {
            BLMenu blMenu=null;
            using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                StoredProcedures.GetMenuItem,
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pItemId",
                                              Value = itemId,
                                              DbType = DbType.Int32
                                          }))
            {
                while (reader.Read())
                {
                    blMenu = new BLMenu
                    {
                        ItemId = reader.TryGetValue<int>("ItemId"),
                        Name = reader.TryGetValue<string>("Name"),
                        Description = reader.TryGetValue<string>("Description"),
                        Category = reader.TryGetValue<Enums.ItemCategory>("Category"),
                        Type = reader.TryGetValue<Enums.ItemType>("Type"),
                        Price = reader.TryGetValue<decimal>("Price"),
                        Status = reader.TryGetValue<Enums.ItemStatus>("Status")
                    };
                }
            }
            return blMenu;
        }

        public int SaveMenuItem(BLMenu blMenu)
        {
            int response = -1;
            using (IDataReader reader = DAOBase.GetDataReader(Connection.BillerDBConnection, CommandType.StoredProcedure,
                StoredProcedures.SaveMenuItem,
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pItemId",
                                              Value = blMenu.ItemId,
                                              DbType = DbType.Int32
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pName",
                                              Value = blMenu.Name,
                                              DbType = DbType.String
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pDescription",
                                              Value = blMenu.Description,
                                              DbType = DbType.String
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pCategory",
                                              Value = (int)blMenu.Category,
                                              DbType = DbType.Int32
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pType",
                                              Value = (int)blMenu.Type,
                                              DbType = DbType.Int32
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pPrice",
                                              Value = blMenu.Price,
                                              DbType = DbType.Decimal
                                          },
                                          new SqlParameter()
                                          {
                                              ParameterName = "@pStatus",
                                              Value = (int)blMenu.Status,
                                              DbType = DbType.Int32
                                          }))
            {
                while (reader.Read())
                {
                    response = reader.TryGetValue<int>("response");
                }
            }
            return response;
        }
    }
}
