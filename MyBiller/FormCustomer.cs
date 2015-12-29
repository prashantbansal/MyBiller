using BL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyBiller
{
    public partial class FormCustomer : MasterForm
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    PhoneNumber1 = txtPhoneNumber1.Text,
                    Email = txtEmail.Text
                };

                List<Customer> customerList = BalObj.GetCustomerList(customer).ToList();

                BindCustomerGrid(customerList);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindCustomerGrid(List<Customer> customerList)
        {
            try
            {
                if (customerList != null && customerList.Count > 0)
                {
                    List<CustomerView> customerViewList = new List<CustomerView>();
                    foreach (var row in customerList)
                    {
                        var customerView = new CustomerView
                        {
                            CustomerId = row.CustomerId,
                            FirstName = row.FirstName,
                            LastName = row.LastName,
                            PhoneNumber1 = row.PhoneNumber1,
                            PhoneNumber2 = row.PhoneNumber2,
                            Email = row.Email
                        };

                        if (row.AddressDetails != null && row.AddressDetails.AddressId > 0)
                        {
                            customerView.AddressId = row.AddressDetails.AddressId;
                            customerView.AddressLine1 = row.AddressDetails.AddressLine1;
                            customerView.AddressLine2 = row.AddressDetails.AddressLine2;
                            customerView.City = row.AddressDetails.City;
                            customerView.PinCode = row.AddressDetails.PinCode;
                        }
                        else
                        {
                            customerView.AddressId = -1;
                        }

                        customerViewList.Add(customerView);
                    }

                    dgCustomerView.AutoGenerateColumns = false;
                    dgCustomerView.DataSource = customerViewList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectItems_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = -1;
                int addressId = -1;
                foreach (DataGridViewRow row in dgCustomerView.Rows)
                {
                    DataGridViewCheckBoxCell checkboxCell=(DataGridViewCheckBoxCell)row.Cells["dcSelect"];

                    if (checkboxCell.Value !=null && Convert.ToBoolean(checkboxCell.Value))
                    {
                        if (customerId > -1)
                        {
                            MessageBox.Show(@"You can not select more than 1 customer");
                            break;
                        }
                        else
                        {
                            customerId = Convert.ToInt32(row.Cells["dcCustomerId"].Value);
                            addressId = Convert.ToInt32(row.Cells["dcAddressId"].Value);
                        }
                    }
                }

                SelectItems(customerId, addressId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectItems(int customerId, int addressId)
        {
            Hide();
            FormMenu frm = new FormMenu(customerId, addressId, -1);
            frm.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Hide();
            FormMenu frmMenu = new FormMenu(-1, -1, -1);
            frmMenu.ShowDialog();
        }
    }
}
