using BL.Business;
using BL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<Tuple<int, string>> categoryList = new List<Tuple<int, string>>();
            categoryList.Add(new Tuple<int, string>((int)Enums.ItemCategory.Lunch, Enums.ItemCategory.Lunch.ToString()));
            categoryList.Add(new Tuple<int, string>((int)Enums.ItemCategory.Dinner, Enums.ItemCategory.Dinner.ToString()));
            categoryList.Add(new Tuple<int, string>((int)Enums.ItemCategory.Breakfast, Enums.ItemCategory.Breakfast.ToString()));
            categoryList.Add(new Tuple<int, string>((int)Enums.ItemCategory.Snacks, Enums.ItemCategory.Snacks.ToString()));

            cboItemCategory.DataSource = categoryList;
            cboItemCategory.DisplayMember = "Item2";
            cboItemCategory.ValueMember = "Item1";

            List<Tuple<int, string>> typeList = new List<Tuple<int, string>>();
            typeList.Add(new Tuple<int, string>((int)Enums.ItemType.Veg, Enums.ItemType.Veg.ToString()));
            typeList.Add(new Tuple<int, string>((int)Enums.ItemType.NonVeg, Enums.ItemType.NonVeg.ToString()));

            cboItemType.DataSource = typeList;
            cboItemType.DisplayMember = "Item2";
            cboItemType.ValueMember = "Item1";

            List<Tuple<int, string>> statusList = new List<Tuple<int, string>>();
            statusList.Add(new Tuple<int, string>((int)Enums.ItemStatus.Active, Enums.ItemStatus.Active.ToString()));
            statusList.Add(new Tuple<int, string>((int)Enums.ItemStatus.Deleted, Enums.ItemStatus.Deleted.ToString()));

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
                    txtItemPrice.Text = blMenu.Price.ToString();
                    cboItemCategory.SelectedValue = (int)blMenu.Category;
                    cboItemType.SelectedValue = (int)blMenu.Type;
                    cboStatus.SelectedValue = (int)blMenu.Status;
                }
            }
            else
            {
                lblItemId.Text = "-1";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                BLMenu blMenu = new BLMenu();
                blMenu.ItemId = Convert.ToInt32(lblItemId.Text);
                blMenu.Name = txtItemName.Text;
                blMenu.Description = txtItemDescription.Text;
                blMenu.Price = Convert.ToDecimal(txtItemPrice.Text);
                blMenu.Category = (Enums.ItemCategory)cboItemCategory.SelectedValue;
                blMenu.Type = (Enums.ItemType)cboItemType.SelectedValue;
                blMenu.Status = (Enums.ItemStatus)cboStatus.SelectedValue;

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
            this.Hide();
            frm.ShowDialog();
        }
    }
}