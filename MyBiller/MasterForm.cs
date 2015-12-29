using BL.Business;
using System;
using System.Windows.Forms;

namespace MyBiller
{
    public partial class MasterForm : Form
    {
        private BalAll _bal;
        public BalAll BalObj
        {
            get
            {
                if (_bal != null)
                {
                    return _bal;
                }
                else
                {
                    _bal = new BalAll();
                    return _bal;
                }
            }
        }

        public MasterForm()
        {
            try
            {
                InitializeComponent();
                FormClosing += MasterForm_FormClosing;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrderList frm = new FormOrderList();
            Hide();
            frm.ShowDialog();
        }

        private void CustomerSearchMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer frm = new FormCustomer();
            Hide();
            frm.ShowDialog();
        }

        private void MenuAddEditMenuItem_Click(object sender, EventArgs e)
        {
            FormMenuList frm = new FormMenuList();
            Hide();
            frm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditMenuItem frm = new FormEditMenuItem(-1);
            Hide();
            frm.ShowDialog();

        }
    }
}
