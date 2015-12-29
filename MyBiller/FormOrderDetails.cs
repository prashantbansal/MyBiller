using BL.Entity;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace MyBiller
{
    public partial class FormOrderDetails : MasterForm
    {
        public FormOrderDetails(int orderId)
        {
            try
            {
                InitializeComponent();

                DisplayData(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayData(int orderId)
        {
            Order order = BalObj.GetOrder(orderId);

            if (order !=null && order.CustomerDetails != null)
            {
                lblCustomerId.Text = order.CustomerDetails.CustomerId.ToString();
                lblName.Text = string.Format("{0} {1}", order.CustomerDetails.FirstName, order.CustomerDetails.LastName);
                lblPhone.Text = order.CustomerDetails.PhoneNumber1;
            }

            if (order != null && order.AddressDetails != null)
            {
                lblAddressId.Text = order.AddressDetails.AddressId.ToString();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(order.AddressDetails.AddressLine1);
                sb.AppendLine(order.AddressDetails.AddressLine2);
                sb.AppendLine(order.AddressDetails.City);
                sb.AppendLine(order.AddressDetails.PinCode);
                lblAddress.Text = sb.ToString();
            }

            if (order != null)
            {
                lblOrderID.Text = order.OrderId.ToString();
                lblOrderStatus.Text = order.Status.ToString();
                lblTotalWithoutTax.Text = order.TotalWithoutTax.ToString(CultureInfo.InvariantCulture);
                lblTotal.Text = order.Total.ToString();
                lblDiscount.Text = order.Discount.ToString();
                lblPlacedOn.Text = order.PlacedOn.ToString();
            }

            if (order != null && order.OrderItems != null && order.OrderItems.Count > 0)
            {
                dgOrderItems.AutoGenerateColumns = false;
                dgOrderItems.DataSource = order.OrderItems;
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                FormCustomer frm = new FormCustomer();
                Hide();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModifyOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                FormMenu frm = new FormMenu(Convert.ToInt32(lblCustomerId.Text), Convert.ToInt32(lblAddressId.Text), Convert.ToInt32(lblOrderID.Text));
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOrderStatus(Enums.OrderStatus.Cancelled);
                NavigateBackToOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NavigateBackToOrderList()
        {
            FormOrderList frm = new FormOrderList();
            Hide();
            frm.ShowDialog();
        }

        private void btnOrderDelivered_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateOrderStatus(Enums.OrderStatus.Delivered);
                NavigateBackToOrderList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateOrderStatus(Enums.OrderStatus orderStatus)
        {
            BalObj.UpdateOrderStatus(Convert.ToInt32(lblOrderID.Text), orderStatus);
        }
    }
}
