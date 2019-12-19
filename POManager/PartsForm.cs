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
    public partial class PartsForm : Form
    {
        public PartsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PartsAdd frmPartsAdd = new PartsAdd(((MainForm)MdiParent).dbCtrl.sqlConn);

            frmPartsAdd.Text = btnAdd.Text;
            frmPartsAdd.btnSave.Text = "저 장";
            frmPartsAdd.ckBoxIsUse.Enabled = false;
            frmPartsAdd.ckBoxNewAdd.Enabled = false;

            frmPartsAdd.cbBoxCategory1.SelectedIndex = 0;
            frmPartsAdd.cbBoxCategory2.SelectedIndex = 0;

            if (frmPartsAdd.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [Parts] (" +
                    "[PartVendorID] " +
                    ",[PartCategory1] " +
                    ",[PartCategory2] " +
                    ",[PartsCode] " +
                    ",[PartNumber] " +
                    ",[PartName] " +
                    ",[PartManufacture] " +
                    ",[PartDrawingNumber] " +
                    ",[PartMakerPN] " +
                    ",[PartUnit] " +
                    ",[PartUnitPrice] " +
                    ",[PartUnitPriceType] " +
                    ",[PartNeedParts] " +
                    ",[PartMakerPNRV] " +
                    ",[PartDeliveryPeriod]) VALUES ( " +
                    frmPartsAdd.VendorID + "," +
                    frmPartsAdd.cbBoxCategory1.SelectedIndex + "," +
                    frmPartsAdd.cbBoxCategory2.SelectedIndex + "," +
                    "'" + frmPartsAdd.textBox_code.Text + "'," +
                    "'" + frmPartsAdd.txtBoxPartNumber.Text + "'," +
                    "'" + frmPartsAdd.txtBoxPartName.Text + "'," +
                    "'" + frmPartsAdd.txtBoxManufacture.Text + "'," +
                    "'" + frmPartsAdd.txtBoxDrawingNumber.Text + "'," +
                    "'" + frmPartsAdd.txtBoxMakerPN.Text + "'," +
                    "'" + frmPartsAdd.txtBoxUnit.Text + "'," +
                    "'" + frmPartsAdd.txtBoxUnitPrice.Text + "'," +
                    "'" + frmPartsAdd.comboBox_moneyType.SelectedIndex + "'," +
                     "'" + frmPartsAdd.textBox_partsForMechine.Text + "'," +
                      "'" + frmPartsAdd.textBox_Revision.Text + "'," +
                    "'" + frmPartsAdd.txtBoxDeliveryDate.Text + "' " +
                    " )");

                PartsTable();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridParts.CurrentRow == null) return;

            PartsAdd frmPartsModify = new PartsAdd(((MainForm)MdiParent).dbCtrl.sqlConn);

            frmPartsModify.Text = btnAdd.Text;
            frmPartsModify.btnSave.Text = "수 정";
            frmPartsModify.ckBoxIsUse.Enabled = true;
            frmPartsModify.ckBoxNewAdd.Enabled = true;
           
            int curRow = dataGridParts.CurrentRow.Index;

            frmPartsModify.ckBoxIsUse.Checked = (Convert.ToBoolean(dataGridParts["자재ID", curRow].Value)) ? true : false;
            frmPartsModify.VendorID = Convert.ToInt16(dataGridParts["공급자ID", curRow].Value);           
            frmPartsModify.cbBoxCategory1.Text = dataGridParts["구분1", curRow].Value.ToString();
                if (frmPartsModify.cbBoxCategory1.Text == "상용품")
                {
                    frmPartsModify.cbBoxCategory1.SelectedIndex = 0;
                }
                else if (frmPartsModify.cbBoxCategory1.Text == "가공품")
                {
                    frmPartsModify.cbBoxCategory1.SelectedIndex = 1;
                }
                else if (frmPartsModify.cbBoxCategory1.Text == "소모품")
                {
                    frmPartsModify.cbBoxCategory1.SelectedIndex = 2;
                }
                else 
                {
                    frmPartsModify.cbBoxCategory1.SelectedIndex = 3;
                }

            frmPartsModify.cbBoxCategory2.Text = dataGridParts["구분2", curRow].Value.ToString();
                if (frmPartsModify.cbBoxCategory2.Text == "Frame and Utility")
                {
                    frmPartsModify.cbBoxCategory2.SelectedIndex = 0;
                }
                else if (frmPartsModify.cbBoxCategory2.Text == "Chamber and Hotzone")
                {
                    frmPartsModify.cbBoxCategory2.SelectedIndex = 1;
                }
                else if (frmPartsModify.cbBoxCategory2.Text == "Vacuum")
                {
                    frmPartsModify.cbBoxCategory2.SelectedIndex = 2;
                }
                else if (frmPartsModify.cbBoxCategory2.Text == "Control Pack")
                {
                    frmPartsModify.cbBoxCategory2.SelectedIndex = 3;
                }
                else if (frmPartsModify.cbBoxCategory2.Text == "Driving Module")
                {
                    frmPartsModify.cbBoxCategory2.SelectedIndex = 4;
                }
                else
                {
                    frmPartsModify.cbBoxCategory2.SelectedIndex = 5;
                }
            frmPartsModify.textBox_code.Text = dataGridParts["코드", curRow].Value.ToString();
            frmPartsModify.txtBoxPartNumber.Text = dataGridParts["자재NO.", curRow].Value.ToString();
            frmPartsModify.txtBoxPartName.Text = dataGridParts["자재명", curRow].Value.ToString();
            frmPartsModify.txtBoxVendor.Text = dataGridParts["공급업체", curRow].Value.ToString();
            frmPartsModify.txtBoxManufacture.Text = dataGridParts["제조업체", curRow].Value.ToString();
            frmPartsModify.txtBoxDrawingNumber.Text = dataGridParts["도면번호", curRow].Value.ToString();
            frmPartsModify.txtBoxMakerPN.Text = dataGridParts["Maker P/N", curRow].Value.ToString();
            frmPartsModify.txtBoxUnit.Text = dataGridParts["단위", curRow].Value.ToString();
            frmPartsModify.txtBoxUnitPrice.Text = dataGridParts["단가", curRow].Value.ToString();
            if (dataGridParts[15, curRow].Value.ToString().Equals("원"))
            {
                frmPartsModify.comboBox_moneyType.SelectedIndex = 0;
            }
            else
            {
                frmPartsModify.comboBox_moneyType.SelectedIndex = 1;
            }

            frmPartsModify.txtBoxDeliveryDate.Text = dataGridParts["납품기간", curRow].Value.ToString();
            frmPartsModify.textBox_partsForMechine.Text = dataGridParts["한대당 필요 갯수", curRow].Value.ToString();
            frmPartsModify.textBox_Revision.Text = dataGridParts["도면Revision", curRow].Value.ToString();

            if (frmPartsModify.ShowDialog() == DialogResult.OK)
            {
                if (frmPartsModify.ckBoxNewAdd.Checked)
                {
                    ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [Parts] (" +
                        "[PartVendorID] " +
                        ",[PartCategory1] " +
                        ",[PartCategory2] " +
                        ",[PartsCode] " +
                        ",[PartNumber] " +
                        ",[PartName] " +
                        ",[PartManufacture] " +
                        ",[PartDrawingNumber] " +
                        ",[PartMakerPN] " +
                        ",[PartUnit] " +
                        ",[PartUnitPrice] " +
                        ",[PartUnitPriceType] " +
                        ",[PartCurrentQuantity] " +
                        ",[PartNeedParts] " +
                        ",[PartMakerPNRV] " +
                        ",[PartDeliveryPeriod]) VALUES ( " +
                        frmPartsModify.VendorID + "," +
                        frmPartsModify.cbBoxCategory1.SelectedIndex + "," +
                        frmPartsModify.cbBoxCategory2.SelectedIndex + "," +
                        "'" + frmPartsModify.textBox_code.Text + "'," +
                        "'" + frmPartsModify.txtBoxPartNumber.Text + "'," +
                        "'" + frmPartsModify.txtBoxPartName.Text + "'," +
                        "'" + frmPartsModify.txtBoxManufacture.Text + "'," +
                        "'" + frmPartsModify.txtBoxDrawingNumber.Text + "'," +
                        "'" + frmPartsModify.txtBoxMakerPN.Text + "'," +
                        "'" + frmPartsModify.txtBoxUnit.Text + "'," +
                        frmPartsModify.txtBoxUnitPrice.Text + ", 0, " +
                        "'" + frmPartsModify.comboBox_moneyType.SelectedIndex + "'," +
                        "'" + frmPartsModify.textBox_partsForMechine.Text + "'," +
                        "'" + frmPartsModify.textBox_Revision.Text + "'," +
                        "'" + frmPartsModify.txtBoxDeliveryDate.Text + "' " +
                        " )");
                }
                else {
                    ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [Parts] SET " +
                        "[PartModifyDate] = GETDATE() " +
                        ",[PartVendorID] = " + frmPartsModify.VendorID +
                        ",[PartCategory1] = " + frmPartsModify.cbBoxCategory1.SelectedIndex +
                        ",[PartCategory2] = " + frmPartsModify.cbBoxCategory2.SelectedIndex +
                        ",[PartsCode] = '" + frmPartsModify.textBox_code.Text + "'" +
                        ",[PartNumber] = '" + frmPartsModify.txtBoxPartNumber.Text + "'" +
                        ",[PartName] = '" + frmPartsModify.txtBoxPartName.Text + "'" +
                        ",[PartManufacture] = '" + frmPartsModify.txtBoxManufacture.Text + "'" +
                        ",[PartDrawingNumber] = '" + frmPartsModify.txtBoxDrawingNumber.Text + "'" +
                        ",[PartMakerPN] = '" + frmPartsModify.txtBoxMakerPN.Text + "'" +
                        ",[PartUnit] = '" + frmPartsModify.txtBoxUnit.Text + "'" +
                        ",[PartUnitPrice] = " + ReStringMoney(frmPartsModify.txtBoxUnitPrice.Text) +
                        ",[PartUnitPriceType] =" + frmPartsModify.comboBox_moneyType.SelectedIndex +
                        ",[PartDeliveryPeriod] = '" + frmPartsModify.txtBoxDeliveryDate.Text + "'" +
                        ",[PartNeedParts] = " + frmPartsModify.textBox_partsForMechine.Text +
                        ",[PartMakerPNRV] = '" + frmPartsModify.textBox_Revision.Text + "'" +
                        ",[PartIsUse] = " + ((frmPartsModify.ckBoxIsUse.Checked) ? 1 : 0).ToString() + " " +
                        "WHERE [PartID] = " + dataGridParts[0, curRow].Value.ToString());
                }

                PartsTable();
            }
        }

        private void PartsForm_Load(object sender, EventArgs e)
        {
            button_condition.Enabled = false;
            Radio_enable();

            //cbBoxCategory1.SelectedIndex = 0;
            //cbBoxCategory2.SelectedIndex = 0;

            PartsTable();
        }

        private void PartsTable()
        {
            var DateFrom = dateTimePickerDateFrom.Value.ToString("yyyy-MM-dd");
            var DateTo = dateTimePickerDateTo.Value.AddDays(1).ToString("yyyy-MM-dd");
            ((MainForm)MdiParent).dbCtrl.ConditionQuery = "";           
            string query = "SELECT " +
                        "[PartID] [자재ID] " +
                        ",[PartIsUse] [사용유무]" +
                        ",[PartVendorID] [공급자ID] " +
                        ",[PartCategory1] " +
                        ",CASE [PartCategory1] " +
                                "WHEN 0 THEN '상용품' " +
                                "WHEN 1 THEN '가공품' " +
                                "WHEN 2 THEN '소모품' " +
                                "WHEN 3 THEN '원재료' " +
                                "END [구분1] " +
                        ",CASE [PartCategory2] " +
                                "WHEN 0 THEN 'Frame and Utility' " +
                                "WHEN 1 THEN 'Chamber and Hotzone' " +
                                "WHEN 2 THEN 'Vacuum' " +
                                "WHEN 3 THEN 'Control Pack' " +
                                "WHEN 4 THEN 'Driving Module' " +
                                "WHEN 5 THEN '기타' " +
                                "END [구분2] " +
                        ",[PartsCode] [코드] " +
                        ",[PartNumber] [자재NO.] " +
                        ",[PartName] [자재명] " +
                        ",CONVERT(VARCHAR(10), [PartRecordDate], 120) [등록일] " +                       
                        ",[VendorName] [공급업체] " +
                        ",[PartManufacture] [제조업체] " +
                        ",[PartDrawingNumber] [도면번호] " +
                        ",[PartMakerPNRV] [도면Revision] " +
                        ",[PartMakerPN] [Maker P/N] " +
                        ",[PartUnit] [단위] " +
                        ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1)  [단가] " +
                        //",[PartUnitPriceType] " +
                        ",CASE [PartUnitPriceType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +                                
                                "END [화폐단위] " +
                        ",[PartDeliveryPeriod] [납품기간] " +
                        ",[PartNeedParts] [한대당 필요 갯수] " +
                    "FROM [Parts] LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID]";

            if (!ckBoxAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[PartIsUse] = 1", false);
            if (!rdBtnAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("([PartRecordDate] >= '" + DateFrom + "') AND ([PartRecordDate] < '" + DateTo + "')", false);
            //if (cbBoxCategory1.SelectedIndex > 0) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[PartCategory1] = " + (cbBoxCategory1.SelectedIndex - 1), false);
            //if (cbBoxCategory2.SelectedIndex > 0) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[PartCategory2] = " + (cbBoxCategory2.SelectedIndex - 1), false);
            ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[PartID]", true);
            query += ((MainForm)MdiParent).dbCtrl.ConditionQuery;

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridParts, 4);

            int partCnt = dataGridParts.RowCount;
            label5.Text = "Parts 갯수 : " + partCnt.ToString(); 
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            Radio_enable();
            PartsTable();
        }

        private void dataGridParts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModify_Click(sender, e);
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

        private void button1_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("Parts",dataGridParts);
        }

        String reString;
        private String ReStringMoney(String value)
        {
            reString = null;
            String money = value;
            string[] split = null;
            split = money.Split(',');
            foreach (string word in split)
            {
                reString += word;
            }
            return reString;
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

            var DateFrom = dateTimePickerDateFrom.Value.ToString("yyyy-MM-dd");
            var DateTo = dateTimePickerDateTo.Value.AddDays(1).ToString("yyyy-MM-dd");
            ((MainForm)MdiParent).dbCtrl.ConditionQuery = "";
            string query = "SELECT " +
                        "[PartID] [자재ID] " +
                        ",[PartIsUse] [사용유무]" +
                        ",[PartVendorID] [공급자ID] " +
                        ",[PartCategory1] " +
                        ",CASE [PartCategory1] " +
                                "WHEN 0 THEN '상용품' " +
                                "WHEN 1 THEN '가공품' " +
                                "WHEN 2 THEN '소모품' " +
                                "WHEN 3 THEN '원재료' " +
                                "END [구분1] " +
                        ",CASE [PartCategory2] " +
                                "WHEN 0 THEN 'Frame and Utility' " +
                                "WHEN 1 THEN 'Chamber and Hotzone' " +
                                "WHEN 2 THEN 'Vacuum' " +
                                "WHEN 3 THEN 'Control Pack' " +
                                "WHEN 4 THEN 'Driving Module' " +
                                "WHEN 5 THEN '기타' " +
                                "END [구분2] " +
                        ",[PartsCode] [코드] " +
                        ",[PartNumber] [자재NO.] " +
                        ",[PartName] [자재명] " +
                        ",CONVERT(VARCHAR(10), [PartRecordDate], 120) [등록일] " +
                        ",[VendorName] [공급업체] " +
                        ",[PartManufacture] [제조업체] " +
                        ",[PartDrawingNumber] [도면번호] " +
                        ",[PartMakerPNRV] [도면Revision] " +
                        ",[PartMakerPN] [Maker P/N] " +
                        ",[PartUnit] [단위] " +
                        ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1)  [단가] " +
                //",[PartUnitPriceType] " +
                        ",CASE [PartUnitPriceType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +
                                "END [화폐단위] " +
                        ",[PartDeliveryPeriod] [납품기간] " +
                        ",[PartNeedParts] [한대당 필요 갯수] " +
                    "FROM [Parts] LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID]";

            if (!ckBoxAll.Checked)
            {
                query = query + " WHERE [PartIsUse] = 1 AND " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [PartID] DESC";
            }
            else
            {
                query = query + " WHERE " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [PartID] DESC";
            }

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridParts, 3);
        }

        private void cbBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_condition.Enabled = true;
        }
    }
}
