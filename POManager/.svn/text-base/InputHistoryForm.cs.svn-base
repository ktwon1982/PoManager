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
    public partial class InputHistoryForm : Form
    {
        public InputHistoryForm()
        {
            InitializeComponent();
        }

        private void InputHistoryForm_Load(object sender, EventArgs e)
        {
            Radio_enable();
            InputHistoryTable();           
        }

        private void InputHistoryTable()
        {
            var DateFrom = dateTimePickerDateFrom.Value.ToString("yyyy-MM-dd");
            var DateTo = dateTimePickerDateTo.Value.AddDays(1).ToString("yyyy-MM-dd");

            ((MainForm)MdiParent).dbCtrl.ConditionQuery = "";

            string query = "SELECT " +
                        "[InputID] " +
                        ",[InputIsUse] " +
                        ",[PartsCode] [코드] " +
                        ",[PartNumber] [자재NO.] " +
                        ",[PartName] [자재명] " +
                        ",[VendorName] [공급업체] " +
                        ",[PartManufacture] [제조업체] " +
                        ",[PartDrawingNumber] [도면번호] " +
                         ",[PartMakerPNRV] [도면Revision] " +
                        ",[PartUnit] [단위] " +
                        ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1)  [단가] " +
                        ",[InputQuantity] [입고수량] " +
                        ",convert(VARCHAR, convert(MONEY,InputTotalAmount),1) [입고금액] " +
                        ",[InputMinusQuantity] [미입고수량] " +
                        ",convert(VARCHAR, convert(MONEY,InputMinusTotalAmount),1) [미입고금액] " +
                        ",[InputResolver] [확인자] " +
                        //",[InputDate] [확인날짜] " +
                        ",CONVERT(VARCHAR(10), [InputDate], 120) [확인날짜] " + 
                        ",[InputComment] [기타] " +
                    "FROM ([Inputs] LEFT JOIN [Parts] ON [InputPartID] = [PartID]) LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID]";

            //if (!ckBoxAll.Checked) query = query + " WHERE [InputIsUse] = 1";
            //query = query + " ORDER BY [InputID] ";

            if (!ckBoxAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[InputIsUse] = 1", false);
            if (!rdBtnAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("([InputDate] >= '" + DateFrom + "') AND ([InputDate] < '" + DateTo + "')", false);
            ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[InputID]", true);
            query += ((MainForm)MdiParent).dbCtrl.ConditionQuery;

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridInputs, 2);

            string sum = ((MainForm)MdiParent).dbCtrl.AmountSum("SELECT SUM([InputTotalAmount]) AS [Sum] FROM [Inputs]");
            //lab_sum.Text = "입고 총액 : " + sum.ToString() +" 원";
            //lab_sum.Text = "입고 총액 : " + MoneyString(sum)+" 원";
           
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            Radio_enable();
            InputHistoryTable();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("입고기록", dataGridInputs);
        }
    }
}
