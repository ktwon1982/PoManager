using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POManager
{
    public partial class POPartsAdd : Form
    {        
        public POPartsAdd(SqlConnection sql)
        {
            InitializeComponent();
            conn = sql;
        }        

        private SqlConnection conn;
        public int PartID;

        private void btnSelectVendor_Click(object sender, EventArgs e)
        {
            PartID = 0;

            SelectItem selectItem = new SelectItem();

            string query = "SELECT " +
                "[PartID] " +
                ",[PartName] [자제명] " +
                ",[VendorName] [공급업체] " +
                ",[PartManufacture] [제조업체] " +
                ",[PartDrawingNumber] [도면번호] " +
                ",[PartMakerPN] [Maker P/N] " +
                ",[PartUnit] [단위] " +
                ",[PartUnitPrice] [단가] " +
            "FROM [Parts] LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID] " +
            "WHERE [PartIsUse] = 1 " +
            "ORDER BY [PartID] ";

            selectItem.LoadSelectItem(query, conn);

            if (selectItem.ShowDialog() == DialogResult.OK)
            {
                int selectRow = selectItem.dataGridSelect.CurrentRow.Index;
                PartID = Convert.ToInt16(selectItem.dataGridSelect[0, selectRow].Value);
                txtBoxPartName.Text = selectItem.dataGridSelect[1, selectRow].Value.ToString();
                txtBoxVendor.Text = selectItem.dataGridSelect[2, selectRow].Value.ToString();
                txtBoxManufacture.Text = selectItem.dataGridSelect[3, selectRow].Value.ToString();
                txtBoxDrawingNumber.Text = selectItem.dataGridSelect[4, selectRow].Value.ToString();
                txtBoxMakerPN.Text = selectItem.dataGridSelect[5, selectRow].Value.ToString();
                txtBoxUnit.Text = selectItem.dataGridSelect[6, selectRow].Value.ToString();
                txtBoxUnitPrice.Text = selectItem.dataGridSelect[7, selectRow].Value.ToString();
            }
        }

        private void txtBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            this.ActiveControl.BackColor = Color.Yellow;
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl.BackColor = Color.White;

                int quantity = Convert.ToInt32(txtBoxQuantity.Text);
                int unitPrice = Convert.ToInt32(txtBoxUnitPrice.Text);

                txtBoxTotalAmount.Text = (quantity * unitPrice).ToString();
            }
        }       

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            POAdd poadd = new POAdd();
            poadd.Activate(); 
        }        
    }
}
