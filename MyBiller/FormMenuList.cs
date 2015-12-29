using BL.Business;
using BL.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyBiller
{
    public partial class FormMenuList : MasterForm
    {
        public FormMenuList()
        {
            try
            {
                InitializeComponent();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData()
        {
            BindMenuItemStatus();
            BindGrid(Enums.ItemStatus.Active);
        }

        private void BindGrid(Enums.ItemStatus itemStatus)
        {
            var menuList = BalObj.GetMenuList(itemStatus);
            dgMenuList.AutoGenerateColumns = false;
            dgMenuList.DataSource = menuList;
            dgMenuList.CellContentClick += dgMenuList_CellContentClick;
        }

        private void dgMenuList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgMenuList.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
                {
                    int itemId = Convert.ToInt32(dgMenuList.Rows[e.RowIndex].Cells["dcItemId"].Value);

                    FormEditMenuItem frm = new FormEditMenuItem(itemId);
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindMenuItemStatus()
        {
            List<Tuple<int, string>> statusList = new List<Tuple<int, string>>();
            statusList.Add(new Tuple<int, string>((int)Enums.ItemStatus.Active, Enums.ItemStatus.Active.ToString()));
            statusList.Add(new Tuple<int, string>((int)Enums.ItemStatus.Deleted, Enums.ItemStatus.Deleted.ToString()));

            cboItemStatus.DataSource = statusList;
            cboItemStatus.DisplayMember = "Item2";
            cboItemStatus.ValueMember = "Item1";
        }

        private void btnGetItems_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindGrid((Enums.ItemStatus)((System.Tuple<int, string>)(cboItemStatus.SelectedItem)).Item1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
