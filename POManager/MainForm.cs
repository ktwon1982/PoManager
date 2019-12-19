using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace POManager
{
    public partial class MainForm : Form
    {
        public DBCtrl dbCtrl;        

        public MainForm()
        {
            InitializeComponent();            
        }

        private void VendorMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) {
                this.ActiveMdiChild.Close();
            }
            VendorsForm vendorForm = new VendorsForm();
            vendorForm.MdiParent = this;
            vendorForm.Show();
            vendorForm.WindowState = FormWindowState.Maximized;
        }

        private void PartsMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) {
                this.ActiveMdiChild.Close();
            }
            PartsForm partsForm = new PartsForm();
            partsForm.MdiParent = this;
            partsForm.Show();
            partsForm.WindowState = FormWindowState.Maximized;
        }

        private void PurchaseOrderMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) {
                this.ActiveMdiChild.Close();
            }
            PurchaseOrdersForm purchaseOrderForm = new PurchaseOrdersForm();
            purchaseOrderForm.MdiParent = this;
            purchaseOrderForm.Show();
            purchaseOrderForm.WindowState = FormWindowState.Maximized;
        }

        private void InputMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) {
                this.ActiveMdiChild.Close();
            }
            InputsForm inputForm = new InputsForm();
            inputForm.MdiParent = this;
            inputForm.Show();
            inputForm.WindowState = FormWindowState.Maximized;
        }

        private void StockMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            StocksForm stockForm = new StocksForm();
            stockForm.MdiParent = this;
            stockForm.Show();
            stockForm.WindowState = FormWindowState.Maximized;
        }

        private void InputHistoryMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            InputHistoryForm inputHistoryForm = new InputHistoryForm();
            inputHistoryForm.MdiParent = this;
            inputHistoryForm.Show();
            inputHistoryForm.WindowState = FormWindowState.Maximized;
        }

        private void OutputHistoryMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            OutputHistoryForm outputHistoryForm = new OutputHistoryForm();
            outputHistoryForm.MdiParent = this;
            outputHistoryForm.Show();
            outputHistoryForm.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            dbCtrl = new DBCtrl();
            Login login = new Login(dbCtrl);

            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Text = login.GetCompanyName();
                PurchaseOrdersForm purchaseOrderForm = new PurchaseOrdersForm();
                purchaseOrderForm.MdiParent = this;
                purchaseOrderForm.Show();
                purchaseOrderForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbCtrl.CloseConnect();
        }

    }
}
