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
    public partial class OutputHistoryForm : Form
    {
        public OutputHistoryForm()
        {
            InitializeComponent();
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            Radio_enable();
            OutputHistoryTable();
        }

        private void OutputHistoryTable()
        {
            var DateFrom = dateTimePickerDateFrom.Value.ToString("yyyy-MM-dd");
            var DateTo = dateTimePickerDateTo.Value.AddDays(1).ToString("yyyy-MM-dd"); 

            ((MainForm)MdiParent).dbCtrl.ConditionQuery = "";

            string query = "SELECT " +
                        "[OutputID] " +
                        ",[OutputIsUse] " +
                        ",[PartsCode] [코드] " +
                        ",[VendorName] [공급업체] " +
                        ",[PartManufacture] [제조업체] " +                        
                        ",[PartDrawingNumber] [도면번호] " +
                         ",[PartMakerPNRV] [도면Revision] " +
                        ",[PartUnit] [단위] " +               
                        ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1) [단가] " +
                        ",[OutputCurrQuantity] [재고수량] " +
                        ",convert(VARCHAR, convert(MONEY,OutputCurrTotalAmount),1) [총재고금액] " +
                        ",[OutputQuantity] [출고수량] " +
                        ",convert(VARCHAR, convert(MONEY,OutputTotalAmount),1) [출고금액] " +
                        ",[OutputRestQuantity] [잔여수량] " +
                        ",convert(VARCHAR, convert(MONEY,OutputRestTotalAmount),1) [잔여금액] " +
                        ",[OutputRequestor] [요청자] " +
                        //",[OutputDate] [요청날짜] " +
                        ",CONVERT(VARCHAR(10), [OutputDate], 120) [요청날짜] " + 
                        ",[OutputComment] [기타] " +
                    "FROM ([Outputs] LEFT JOIN [Parts] ON [OutputPartID] = [PartID]) LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID]";

            if (!ckBoxAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[OutputIsUse] = 1", false);
            if (!rdBtnAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("([OutputDate] >= '" + DateFrom + "') AND ([OutputDate] < '" + DateTo + "')", false);
            ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[OutputID]", true);
            query += ((MainForm)MdiParent).dbCtrl.ConditionQuery;

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridOutputs, 2);

            string sum = ((MainForm)MdiParent).dbCtrl.AmountSum("SELECT SUM([OutputTotalAmount]) AS [Sum] FROM [Outputs]");           
            //lab_sum.Text = "출고 총액 : " + MoneyString(sum)+" 원";
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            Radio_enable();
            OutputHistoryTable();
        }

        private void Radio_enable()
        {

            if (rdBtnAll.Checked)
            {
                gb_from.Enabled = false;
                gb_to.Enabled = false;
            }
            else
            {
                gb_from.Enabled = true;
                gb_to.Enabled = true;
            }
        }

        private string MoneyString(string str)
        {
            string result = str;
            for (int i = str.Length - 3; i > 0; i = i - 3)
            {
                result = result.Insert(i, ",");

            }

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("출고기록", dataGridOutputs);
        }
    }
}
