using BL.Business;
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
    public partial class MasterForm : Form
    {
        private BalAll _bal = null;
        public BalAll BalObj
        {
            get
            {
                if (this._bal != null)
                {
                    return this._bal;
                }
                else
                {
                    this._bal = new BalAll();
                    return this._bal;
                }
            }
        }

        public MasterForm()
        {
            try
            {
                InitializeComponent();
                this.FormClosing += MasterForm_FormClosing;
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
            this.Hide();
            frm.ShowDialog();
        }

        private void CustomerSearchMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer frm = new FormCustomer();
            this.Hide();
            frm.ShowDialog();
        }

        private void MenuAddEditMenuItem_Click(object sender, EventArgs e)
        {
            FormMenuList frm = new FormMenuList();
            this.Hide();
            frm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditMenuItem frm = new FormEditMenuItem(-1);
            this.Hide();
            frm.ShowDialog();

        }
    }
}
