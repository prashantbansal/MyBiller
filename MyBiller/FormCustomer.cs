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
                Customer customer = new Customer();
                customer.FirstName = this.txtFirstName.Text;
                customer.LastName = this.txtLastName.Text;
                customer.PhoneNumber1 = this.txtPhoneNumber1.Text;
                customer.Email = this.txtEmail.Text;

                List<Customer> customerList = BalObj.GetCustomerList(customer).ToList();

                this.BindCustomerGrid(customerList);
                
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
                    CustomerView customerView = null;
                    foreach (var row in customerList)
                    {
                        customerView = new CustomerView();
                        customerView.CustomerId = row.CustomerId;
                        customerView.FirstName = row.FirstName;
                        customerView.LastName = row.LastName;
                        customerView.PhoneNumber1 = row.PhoneNumber1;
                        customerView.PhoneNumber2 = row.PhoneNumber2;
                        customerView.Email = row.Email;

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

                    this.dgCustomerView.AutoGenerateColumns = false;
                    this.dgCustomerView.DataSource = customerViewList;
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

                    if (checkboxCell.Value !=null && Convert.ToBoolean(checkboxCell.Value) == true)
                    {
                        if (customerId > -1)
                        {
                            MessageBox.Show("You can not select more than 1 customer");
                            break;
                        }
                        else
                        {
                            customerId = Convert.ToInt32((row.Cells["dcCustomerId"].Value));
                            addressId = Convert.ToInt32((row.Cells["dcAddressId"].Value));
                        }
                    }
                }

                this.SelectItems(customerId, addressId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectItems(int customerId, int addressId)
        {
            this.Hide();
            FormMenu frm = new FormMenu(customerId, addressId, -1);
            frm.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu frmMenu = new FormMenu(-1, -1, -1);
            frmMenu.ShowDialog();
        }
    }
}
