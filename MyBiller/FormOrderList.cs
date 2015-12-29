using BL.Business;
using BL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyBiller
{
    public partial class FormOrderList : MasterForm
    {
        public FormOrderList()
        {
            try
            {
                InitializeComponent();

                this.LoadOrderStatusList();
                this.BindGrid(Enums.OrderStatus.Pending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadOrderStatusList()
        {
            List<Tuple<int, string>> orderStatusList = new List<Tuple<int,string>>();
            orderStatusList.Add(new Tuple<int,string>((int)Enums.OrderStatus.Pending, "Pending"));
            orderStatusList.Add(new Tuple<int,string>((int)Enums.OrderStatus.Delivered, "Delivered"));
            orderStatusList.Add(new Tuple<int,string>((int)Enums.OrderStatus.Cancelled, "Cancelled"));
            cboOrderStatus.DataSource = orderStatusList;
            cboOrderStatus.DisplayMember = "Item2";
       }

        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            try
            {
               this.BindGrid((Enums.OrderStatus)((System.Tuple<int, string>)(cboOrderStatus.SelectedItem)).Item1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGrid(Enums.OrderStatus orderStatus)
        {
            List<Order> orderList = BalObj.GetOrderList(orderStatus).ToList();
            dgOrderList.AutoGenerateColumns = false;
            dgOrderList.DataSource = orderList;
            dgOrderList.CellContentClick += dgOrderList_CellContentClick;
        }

        void dgOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgOrderList.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
                {
                    int orderId = Convert.ToInt32(dgOrderList.Rows[e.RowIndex].Cells["dcOrderId"].Value);

                    FormOrderDetails frm = new FormOrderDetails(orderId);
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
