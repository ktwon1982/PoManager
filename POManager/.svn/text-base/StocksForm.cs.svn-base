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
    public partial class StocksForm : Form
    {
        public StocksForm()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (dataGridStocks.CurrentRow == null) return;

            OutputRegist outputRegist = new OutputRegist();
          
            int curRow = dataGridStocks.CurrentRow.Index;
            outputRegist.textBox_code.Text = dataGridStocks["코드", curRow].Value.ToString();
            outputRegist.txtBoxPartNumber.Text = dataGridStocks["자재NO.", curRow].Value.ToString();
            outputRegist.txtBoxPartName.Text = dataGridStocks["자재명", curRow].Value.ToString();
            outputRegist.txtBoxVendor.Text = dataGridStocks["공급업체", curRow].Value.ToString();
            outputRegist.txtBoxManufacture.Text = dataGridStocks["제조업체", curRow].Value.ToString();
            outputRegist.txtBoxMakerPN.Text = dataGridStocks["Maker P/N", curRow].Value.ToString();
            outputRegist.txtBoxUnit.Text = dataGridStocks["단위", curRow].Value.ToString();
            outputRegist.txtBoxUnitPrice.Text = dataGridStocks["단가", curRow].Value.ToString();
            outputRegist.txtBoxStockQuantity.Text = dataGridStocks["재고수량", curRow].Value.ToString();
            outputRegist.txtBoxStockTotalAmount.Text = dataGridStocks["재고금액", curRow].Value.ToString();
            outputRegist.cbBoxRequestDept.SelectedIndex = 0;

            if (outputRegist.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [Parts] SET " +
                    "[PartCurrentQuantity] = " +
                        "((SELECT PartCurrentQuantity FROM Parts WHERE [PartID] = " + dataGridStocks[0, curRow].Value.ToString() + ") - " +
                            outputRegist.txtBoxOutputQuantity.Text + ") " +
                    " WHERE [PartID] = " + dataGridStocks[0, curRow].Value.ToString());//재고수량 변경

                ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [Outputs] ( " +
                    "[OutputPartID] " +
                    ",[OutputCurrQuantity] " +
                    ",[OutputCurrTotalAmount] " +
                    ",[OutputQuantity] " +
                    ",[OutputTotalAmount] " +
                    ",[OutputRestQuantity] " +
                    ",[OutputRestTotalAmount] " +
                    ",[OutputComment] " +
                    ",[OutputRequestDept] " +
                    ",[OutputRequestor] " +
                    ",[OutputDate] ) VALUES ( " +
                    dataGridStocks[0, curRow].Value.ToString() + ", " +
                    dataGridStocks["재고수량", curRow].Value.ToString() + ", " +
                    dataGridStocks["재고금액", curRow].Value.ToString() + ", " +
                    outputRegist.txtBoxOutputQuantity.Text + ", " +
                    outputRegist.txtBoxOutputAmount.Text + ", " +
                    outputRegist.txtBoxRestQuantity.Text + ", " +
                    outputRegist.txtBoxRestAmount.Text + ", " +
                    "'" + outputRegist.txtBoxComment.Text + "', " +
                    outputRegist.cbBoxRequestDept.SelectedIndex + ", " +
                    "'" + outputRegist.txtBoxRequestor.Text + "', " +
                    "'" + outputRegist.dateTimeOutputDate.Value.ToShortDateString() + "') ");

                StocksTable();
            }
        }

        private void StocksTable()
        {
            string query = "SELECT " +
                    "[PartID] " +
                    ",CASE [PartCategory1] " +
                          "WHEN 0 THEN '상용품' " +
                          "WHEN 1 THEN '가공품' " +
                          "WHEN 2 THEN '소모품' " +
                          "WHEN 3 THEN '원재료' " +
                          "END [구분1] " +
                  ",CASE [PartCategory2] " +
                                "WHEN 0 THEN 'Fram and Utility' " +
                                "WHEN 1 THEN 'Chamber and Hotzone' " +
                                "WHEN 2 THEN 'Control Pack' " +
                                "WHEN 3 THEN 'Driving Module' " +
                                "END [구분2] " +
                    ",[PartsCode] [코드] " +
                    ",[PartNumber] [자재NO.] " +
                    ",[PartName] [자재명] " +
                    ",[VendorName] [공급업체] " +
                    ",[PartManufacture] [제조업체] " +
                    ",[PartDrawingNumber] [도면번호] " +
                    ",[PartMakerPNRV] [도면Revision] " +
                    ",[PartMakerPN] [Maker P/N] " +
                    ",[PartUnit] [단위] " +
                    ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1) [단가] " +
                    ",[PartCurrentQuantity] [재고수량]" +
                //convert(VARCHAR, convert(MONEY,str(Round([PartUnitPrice]*[PartCurrentQuantity],2),5,2)),1)                 
                  //  ",str(Round([PartUnitPrice]*[PartCurrentQuantity],2),5,2) [재고금액]" +
                 ", convert(VARCHAR, convert(MONEY,[PartUnitPrice]*[PartCurrentQuantity]),1) [재고금액] "+	
                "FROM [Parts] LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID]";

                if (!ckBoxAll.Checked) query = query + " WHERE [PartIsUse] = 1";
                query = query + " ORDER BY [PartID] ";

                ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridStocks, 3);

                int stockCnt = dataGridStocks.RowCount;
                label3.Text = "출고대기 갯수 : " + stockCnt.ToString();     
        }

        private void StocksForm_Load(object sender, EventArgs e)
        {
            button_condition.Enabled = false;
            StocksTable();   
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            StocksTable();   
        }

        private void dataGridStocks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegist_Click(sender, e);
        }

        private void button_condition_Click(object sender, EventArgs e)
        {
            String searchgubun = "";
            int searchingGubun = cbBoxSearch.SelectedIndex;
            if (searchingGubun == 0)
            {
                searchgubun = "[PartsCode]";
            }
            else if (searchingGubun == 1)
            {
                searchgubun = "[PartNumber]";
            }
            else if (searchingGubun == 2)
            {
                searchgubun = "[VendorName]";
            }
            else
            {

            }
            String searchingWord = textBox_condition.Text;

            string query = "SELECT " +
                    "[PartID] " +
                    ",CASE [PartCategory1] " +
                          "WHEN 0 THEN '상용품' " +
                          "WHEN 1 THEN '가공품' " +
                          "WHEN 2 THEN '소모품' " +
                          "WHEN 3 THEN '원재료' " +
                          "END [구분1] " +
                  ",CASE [PartCategory2] " +
                                "WHEN 0 THEN 'Fram and Utility' " +
                                "WHEN 1 THEN 'Chamber and Hotzone' " +
                                "WHEN 2 THEN 'Control Pack' " +
                                "WHEN 3 THEN 'Driving Module' " +
                                "END [구분2] " +
                    ",[PartsCode] [코드] " +
                    ",[PartNumber] [자재NO.] " +
                    ",[PartName] [자재명] " +
                    ",[VendorName] [공급업체] " +
                    ",[PartManufacture] [제조업체] " +
                    ",[PartDrawingNumber] [도면번호] " +
                    ",[PartMakerPNRV] [도면Revision] " +
                    ",[PartMakerPN] [Maker P/N] " +
                    ",[PartUnit] [단위] " +
                    ",[PartUnitPrice] [단가] " +
                    ",[PartCurrentQuantity] [재고수량]" +
                    ",([PartUnitPrice]*[PartCurrentQuantity]) [재고금액]" +
                "FROM [Parts] LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID]";

            if (!ckBoxAll.Checked)
            {
                query = query + " WHERE [PartIsUse] = 1 AND " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [PartID] DESC"; 
            }
            else
            {
                query = query + " WHERE " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [PartID] DESC"; 
            }          

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridStocks, 3);

            int stockCnt = dataGridStocks.RowCount;
            label3.Text = "출고대기 갯수 : " + stockCnt.ToString(); 
        }

        private void textBox_condition_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_condition.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("재고", dataGridStocks);
        }    

    }
}
