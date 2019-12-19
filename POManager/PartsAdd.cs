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
    public partial class PartsAdd : Form
    {
        public PartsAdd(SqlConnection sql)
        {
            InitializeComponent();
            conn = sql;
        }

        private SqlConnection conn;
        public int VendorID;
 
        private void btnSelectVendor_Click(object sender, EventArgs e)
        {
            VendorID = 0;

            SelectItem selectItem = new SelectItem();

            string query = "SELECT " +
                    "[VendorID] " +
                    ",[VendorName] [업체명] " +
                    ",[VendorAddr1] [본사 주소] " +
                    ",[VendorAddr2] [공장 주소] " +
                    ",[VendorAddr3] [지사/사무소 주소] " +
                    ",CASE [VendorCategory] " +
                                "WHEN 0 THEN '공급업체' " +
                                "WHEN 1 THEN '제조업체' " +
                                "END [거래처구분] " +
                    ",[VendorHomepage] [홈페이지] " +
                    ",[VendorTel] [연락처] " +
                "FROM [Vendors] " +
                "WHERE [VendorIsUse] = 1 " +
                "ORDER BY [VendorID] ";

            selectItem.LoadSelectItem(query, conn);

            if (selectItem.ShowDialog() == DialogResult.OK)
            {
                int selectRow = selectItem.dataGridSelect.CurrentRow.Index;
                VendorID = Convert.ToInt16(selectItem.dataGridSelect[0, selectRow].Value);
                txtBoxVendor.Text = selectItem.dataGridSelect[1, selectRow].Value.ToString();
            }
        }

        private void ckBoxNewAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxNewAdd.Checked) {
                ckBoxIsUse.Checked = true;
                ckBoxIsUse.Enabled = false;
            } else {
                ckBoxIsUse.Enabled = true;
            }
        }
    }
}
