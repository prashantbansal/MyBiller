﻿using BL.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MyBiller
{
    public partial class FormMenu : MasterForm
    {
        public FormMenu(int customerId, int addressId, int orderId)
        {
            try
            {
                InitializeComponent();

                LoadMenu();
                LoadCustomerInformation(customerId, addressId, orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCustomerInformation(int customerId, int addressId, int orderId)
        {
            lblCustomerId.Text = customerId.ToString();
            lblAddressId.Text = addressId.ToString();
            lblOrderId.Text = orderId.ToString();

            if (customerId > -1)
            {
                Customer customer = BalObj.GetCustomerInformation(customerId, addressId);

                if (customer != null)
                {
                    rdoUpdateCustomer.Checked = true;
                    txtFirstName.Text = customer.FirstName;
                    txtLastName.Text = customer.LastName;
                    txtPhoneNumber.Text = customer.PhoneNumber1;

                    if (customer.AddressDetails != null && addressId > -1)
                    {
                        rdoUpdateAddress.Checked = true;
                        txtAddressLine1.Text = customer.AddressDetails.AddressLine1;
                        txtAddressLine2.Text = customer.AddressDetails.AddressLine2;
                        txtCity.Text = customer.AddressDetails.City;
                        txtPinCode.Text = customer.AddressDetails.PinCode;
                    }
                    else
                    {
                        rdoCreateAddress.Checked = true;
                    }
                }
            }
            else
            {
                rdoCreateAddress.Checked = true;
                rdoCreateCustomer.Checked = true;
            }

            if (orderId > 0)
            {
                Order order = BalObj.GetOrder(orderId);

                if (order != null && order.OrderItems.Count > 0)
                {
                    foreach (DataGridViewRow row in dgMenuView.Rows)
                    {
                        int itemId = Convert.ToInt32(row.Cells["dcItemId"].Value);

                        OrderItem orderItem = order.OrderItems.FirstOrDefault(x => x.ItemId == itemId);
                        if (orderItem != null)
                        {
                            row.Cells["dcItemTotal"].Value = orderItem.TotalPrice.ToString(CultureInfo.InvariantCulture);
                            row.Cells["dcItemQuantity"].Value = orderItem.Quantity.ToString();
                        }
                    }

                    txtDiscount.Text = order.Discount.ToString();
                    lblTotalPrice.Text = order.Total.ToString();
                }
            }
        }

        public void LoadMenu()
        {
            try
            {
                var menuList = GetMenu();
                dgMenuView.DataSource = menuList;

                List<Tuple<int, int>> countList = new List<Tuple<int, int>>
                {
                    new Tuple<int, int>(0, 0),
                    new Tuple<int, int>(1, 1),
                    new Tuple<int, int>(2, 2),
                    new Tuple<int, int>(3, 3),
                    new Tuple<int, int>(4, 4),
                    new Tuple<int, int>(5, 5),
                    new Tuple<int, int>(6, 6),
                    new Tuple<int, int>(7, 7),
                    new Tuple<int, int>(8, 8),
                    new Tuple<int, int>(9, 0),
                    new Tuple<int, int>(10, 10)
                };

                dcItemQuantity.DataPropertyName = "Quantity";
                dcItemQuantity.DataSource = countList;
                dcItemQuantity.DisplayMember = "Item1";
                dcItemQuantity.ValueMember = "Item2";
               
                dgMenuView.CellEndEdit += dgMenuView_CellEndEdit;
                txtDiscount.TextChanged += txtDiscount_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        private void dgMenuView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdatePrice();
        }

        private IList<BLMenu> GetMenu()
        {
            IList<BLMenu> menuList = BalObj.GetMenuList(Enums.ItemStatus.Active);

            return menuList.ToList();
        }

        private void UpdatePrice()
        {
            string discountValue = txtDiscount.Text;

            decimal discount = 0.0M;
            if (!string.IsNullOrEmpty(discountValue))
            {
                discount = Convert.ToDecimal(discountValue);
            }

            decimal totalPrice = 0.0M;
            foreach (DataGridViewRow row in dgMenuView.Rows)
            {
                var itemValue = row.Cells["dcItemQuantity"].Value;
                var itemPrice = row.Cells["dcItemPrice"].Value;

                if (itemValue != null)
                {
                    decimal itemTotalPrice = Convert.ToDecimal(itemPrice) * Convert.ToInt32(itemValue);
                    row.Cells["dcItemTotal"].Value = itemTotalPrice.ToString(CultureInfo.InvariantCulture);
                    totalPrice = totalPrice + itemTotalPrice;
                }

                lblTotalPrice.Text = (totalPrice - discount).ToString(CultureInfo.InvariantCulture);

            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            Hide();
            FormCustomer frmCustomer = new FormCustomer();
            frmCustomer.ShowDialog();
        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                if (rdoCreateCustomer.Checked)
                {
                    customer.CustomerId = -1;
                }
                else
                {
                    customer.CustomerId = Convert.ToInt32(lblCustomerId.Text);
                }

                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.PhoneNumber1 = txtPhoneNumber.Text;
                customer.Email = string.Empty;


                if (rdoCreateAddress.Checked)
                {
                    customer.AddressDetails.AddressId = -1;
                }
                else
                {
                    customer.AddressDetails.AddressId = Convert.ToInt32(lblAddressId.Text);
                }
                
                customer.AddressDetails.AddressLine1 = txtAddressLine1.Text;
                customer.AddressDetails.AddressLine2 = txtAddressLine2.Text;
                customer.AddressDetails.City = txtCity.Text;
                customer.AddressDetails.PinCode = txtPinCode.Text;

                Order order = new Order
                {
                    OrderId = Convert.ToInt32(lblOrderId.Text),
                    Discount = Convert.ToDecimal(txtDiscount.Text == string.Empty ? "0" : txtDiscount.Text),
                    TotalWithoutTax = Convert.ToDecimal(lblTotalPrice.Text),
                    Tax = 0.0M
                };
                order.Total = order.TotalWithoutTax + order.Tax;
                order.Status = Enums.OrderStatus.Pending;

                foreach (DataGridViewRow row in dgMenuView.Rows)
                {
                    if (row.Cells["dcItemQuantity"].Value != null &&
                        !string.IsNullOrEmpty(row.Cells["dcItemQuantity"].Value.ToString()) &&
                        Convert.ToInt32(row.Cells["dcItemQuantity"].Value) > 0)
                    {
                        var orderItem = new OrderItem
                        {
                            OrderId = -1,
                            ItemId = Convert.ToInt32(row.Cells["dcItemId"].Value),
                            Quantity = Convert.ToInt32(row.Cells["dcItemQuantity"].Value),
                            PricePerItem = Convert.ToDecimal(row.Cells["dcItemPrice"].Value),
                            TotalPrice = Convert.ToDecimal(row.Cells["dcItemTotal"].Value)
                        };
                        order.OrderItems.Add(orderItem);
                    }
                }
                OrderResponse orderResponse = BalObj.SaveOrder(customer, order);

                ViewOrderDetails(orderResponse.OrderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewOrderDetails(int orderId)
        {
            Hide();
            FormOrderDetails frm = new FormOrderDetails(orderId);
            frm.ShowDialog();
        }
    }
}
