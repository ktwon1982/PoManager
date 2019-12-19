using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POManager
{
    public partial class OutputsForm : Form
    {
        public OutputsForm()
        {
            InitializeComponent();
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            OutputTable();
        }

        private void OutputTable()
        {
            string query = "SELECT " +
                        "[OutputID] " +
                        ",[OutputIsUse] " +
                        ",[VendorName] [공급업체] " +
                        ",[PartManufacture] [제조업체] " +
                        ",[PartDrawingNumber] [도면번호] " +
                        ",[PartUnit] [단위] " +
                        ",[PartUnitPrice] [단가] " +
                        ",[OutputCurrQuantity] [재고수량] " +
                        ",[OutputCurrTotalAmount] [총재고금액] " +
                        ",[OutputQuantity] [출고수량] " +
                        ",[OutputTotalAmount] [출고금액] " +
                        ",[OutputRestQuantity] [잔여수량] " +
                        ",[OutputRestTotalAmount] [잔여금액] " +
                        ",[OutputRequestor] [요청자] " +
                        ",[OutputDate] [요청날짜] " +
                        ",[OutputComment] [기타] " +
                    "FROM ([Outputs] LEFT JOIN [Parts] ON [OutputPartID] = [PartID]) LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID]";

            if (!ckBoxAll.Checked) query = query + " WHERE [OutputIsUse] = 1";
            query = query + " ORDER BY [OutputID] ";

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridOutputs, 2);
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            OutputTable();
        }
    }
}
