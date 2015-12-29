using BL.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace MyBiller
{
    public partial class FormEditMenuItem : MasterForm
    {
        public FormEditMenuItem(int itemId)
        {
            try
            {
                InitializeComponent();

                LoadDropdowns();
                LoadData(itemId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadDropdowns()
        {
            List<Tuple<int, string>> categoryList = new List<Tuple<int, string>>
            {
                new Tuple<int, string>((int) Enums.ItemCategory.Lunch, Enums.ItemCategory.Lunch.ToString()),
                new Tuple<int, string>((int) Enums.ItemCategory.Dinner, Enums.ItemCategory.Dinner.ToString()),
                new Tuple<int, string>((int) Enums.ItemCategory.Breakfast, Enums.ItemCategory.Breakfast.ToString()),
                new Tuple<int, string>((int) Enums.ItemCategory.Snacks, Enums.ItemCategory.Snacks.ToString())
            };

            cboItemCategory.DataSource = categoryList;
            cboItemCategory.DisplayMember = "Item2";
            cboItemCategory.ValueMember = "Item1";

            List<Tuple<int, string>> typeList = new List<Tuple<int, string>>
            {
                new Tuple<int, string>((int) Enums.ItemType.Veg, Enums.ItemType.Veg.ToString()),
                new Tuple<int, string>((int) Enums.ItemType.NonVeg, Enums.ItemType.NonVeg.ToString())
            };

            cboItemType.DataSource = typeList;
            cboItemType.DisplayMember = "Item2";
            cboItemType.ValueMember = "Item1";

            List<Tuple<int, string>> statusList = new List<Tuple<int, string>>
            {
                new Tuple<int, string>((int) Enums.ItemStatus.Active, Enums.ItemStatus.Active.ToString()),
                new Tuple<int, string>((int) Enums.ItemStatus.Deleted, Enums.ItemStatus.Deleted.ToString())
            };

            cboStatus.DataSource = statusList;
            cboStatus.DisplayMember = "Item2";
            cboStatus.ValueMember = "Item1";
        }

        private void LoadData(int itemId)
        {
            if (itemId > 0)
            {
                BLMenu blMenu = BalObj.GetMenuItem(itemId);

                if (blMenu != null)
                {
                    lblItemId.Text = blMenu.ItemId.ToString();
                    txtItemName.Text = blMenu.Name;
                    txtItemDescription.Text = blMenu.Description;
                    txtItemPrice.Text = blMenu.Price.ToString(CultureInfo.InvariantCulture);
                    cboItemCategory.SelectedValue = (int)blMenu.Category;
                    cboItemType.SelectedValue = (int)blMenu.Type;
                    cboStatus.SelectedValue = (int)blMenu.Status;
                }
            }
            else
            {
                lblItemId.Text = @"-1";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BLMenu blMenu = new BLMenu
                {
                    ItemId = Convert.ToInt32(lblItemId.Text),
                    Name = txtItemName.Text,
                    Description = txtItemDescription.Text,
                    Price = Convert.ToDecimal(txtItemPrice.Text),
                    Category = (Enums.ItemCategory) cboItemCategory.SelectedValue,
                    Type = (Enums.ItemType) cboItemType.SelectedValue,
                    Status = (Enums.ItemStatus) cboStatus.SelectedValue
                };

                BalObj.SaveMenuItem(blMenu);

                RedirectToMenuList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RedirectToMenuList()
        {
            FormMenuList frm = new FormMenuList();
            Hide();
            frm.ShowDialog();
        }
    }
}