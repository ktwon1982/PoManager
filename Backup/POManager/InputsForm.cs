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
    public partial class InputsForm : Form
    {
        int needParts;
        public InputsForm()
        {
            InitializeComponent();
        }       
        private void btnRegist_Click(object sender, EventArgs e)
        {
            if (dataGridInputs.CurrentRow == null) return;

            InputRegist inputRegist = new InputRegist(((MainForm)MdiParent).dbCtrl.sqlConn);

            int curRow = dataGridInputs.CurrentRow.Index;
            inputRegist.txtBoxPONumber.Text = dataGridInputs["PO번호", curRow].Value.ToString();
            inputRegist.txtBoxPORevision.Text = dataGridInputs["PO Rev.", curRow].Value.ToString();//revison
            inputRegist.textBox_code.Text = dataGridInputs["코드", curRow].Value.ToString();
            inputRegist.txtBoxPartName.Text = dataGridInputs["Part명", curRow].Value.ToString();
            inputRegist.txtBoxVendor.Text = dataGridInputs["공급업체", curRow].Value.ToString();
            inputRegist.txtBoxManufacture.Text = dataGridInputs["제조업체", curRow].Value.ToString();
            inputRegist.txtBoxMakerPN.Text = dataGridInputs["Maker P/N", curRow].Value.ToString();
            inputRegist.txtBoxUnit.Text = dataGridInputs["단위", curRow].Value.ToString();
            inputRegist.txtBoxUnitPrice.Text = dataGridInputs["단가", curRow].Value.ToString();
            inputRegist.txtBoxPOQuantity.Text = dataGridInputs["PO수량", curRow].Value.ToString();
            inputRegist.txtBoxPOTotalAmount.Text = dataGridInputs["총금액", curRow].Value.ToString();
            inputRegist.txtBoxInputQuantity.Text = dataGridInputs["입고수량", curRow].Value.ToString();
            if(dataGridInputs["화폐단위", curRow].Value.ToString()=="달러"){
                inputRegist.label21.Text = "달러";
                inputRegist.label22.Text = "달러";
                inputRegist.label3.Text = "달러";
                inputRegist.label6.Text = "달러";
            }

            //inputRegist.or_poQuantity = Convert.ToInt16(dataGridInputs["PO수량", curRow].Value);
            //inputRegist.or_minusQuantity = Convert.ToInt16(dataGridInputs["미입고수량", curRow].Value);

            inputRegist.txtBoxInputTotalAmount.Text = dataGridInputs["총입고금액", curRow].Value.ToString();
            if (inputRegist.txtBoxInputTotalAmount.Text == "")
            {
                inputRegist.txtBoxInputTotalAmount.Text = "0";
            }
            inputRegist.txtBoxMinusQuantity.Text = dataGridInputs["미입고수량", curRow].Value.ToString();
            if (inputRegist.txtBoxMinusQuantity.Text=="")
            {
                inputRegist.txtBoxMinusQuantity.Text = "0";
            }
            inputRegist.txtBoxMinusTotalAmount.Text = dataGridInputs["미입고금액", curRow].Value.ToString();
            if (inputRegist.txtBoxMinusTotalAmount.Text == "")
            {
                inputRegist.txtBoxMinusTotalAmount.Text = "0";
            }
            inputRegist.txtBoxResolver.Text = dataGridInputs["입고처리자", curRow].Value.ToString();
            //inputRegist.txtInputComment.Text = dataGridInputs["기타", curRow].Value.ToString();

            inputRegist.poPartID = dataGridInputs[0, curRow].Value.ToString();//POPartsID

            string query = "select [PartNeedParts] from [Parts] where [PartID]='" + Convert.ToInt16(dataGridInputs[2, curRow].Value) + "'";
            needParts = ((MainForm)MdiParent).dbCtrl.GetNeedParts(query);

            if (inputRegist.ShowDialog() == DialogResult.OK) 
            {
                int intputQuantity = Convert.ToInt16(inputRegist.txtBoxInputQuantity.Text);
                int machineQuantity = intputQuantity / needParts;//제작장비 갯수
                int needQuantity = needParts - (intputQuantity % needParts);//필요수량


                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [POParts] SET " +
                    "[POPartMechineQuantity] =" + machineQuantity +
                    ",[POPartRequirementsPartsQuantity]=" + needQuantity +
                    " WHERE [POPartsID] = " + dataGridInputs[0, curRow].Value.ToString());

                int curPOID = Convert.ToInt16(dataGridInputs[1, curRow].Value);
                int curPartID = Convert.ToInt16(dataGridInputs[2, curRow].Value);
                
                ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [Inputs] ( " +
                    "[InputPOID] " +
                    ",[InputPartID] " +
                    ",[InputQuantity] " +
                    ",[InputTotalAmount] " +
                    ",[InputMinusQuantity] " +
                    ",[InputMinusTotalAmount] " +
                    ",[InputComment] " +
                    ",[InputResolver] " +
                    ",[InputDate] ) VALUES ( " +
                    curPOID + ", " +
                    curPartID + ", " +
                    inputRegist.txtBoxInputQuantity.Text + ", " +
                    inputRegist.txtBoxInputTotalAmount.Text + ", " +
                    inputRegist.txtBoxMinusQuantity.Text + ", " +
                    inputRegist.txtBoxMinusTotalAmount.Text + ", " +
                    "'', " +
                    "'" + inputRegist.txtBoxResolver.Text + "', " +
                    "'" + inputRegist.dateTimeInputDate.Value.ToShortDateString() + "') ");               

                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [POParts] SET " +
                    "[POPartInputQuantity] = (SELECT SUM([InputQuantity]) FROM [Inputs] WHERE [InputPOID] = " + curPOID + " AND [InputPartID] = " + curPartID + " AND [POPartIsUse] = 1 ) " +//수량을 합한다.
                    ",[POPartInputTotalAmount] = (SELECT SUM([InputTotalAmount]) FROM [Inputs] WHERE [InputPOID] = " + curPOID + " AND [InputPartID] = " + curPartID +" AND [POPartIsUse] = 1 ) " +
                    ",[POPartInputMinusQuantity] = " + inputRegist.txtBoxMinusQuantity.Text +
                    ",[POPartInputMinusTotalAmount] = " + inputRegist.txtBoxMinusTotalAmount.Text +
                    ",[POPartInputResolver] = '" + inputRegist.txtBoxResolver.Text + "'" +
                    ",[POPartInputDate] = '" + inputRegist.dateTimeInputDate.Value.ToShortDateString() + "'" +
                    ",[POPartInputComment] = ''" +
                    ",[POPartIsComplete] = " + ((inputRegist.isComplete)? 1 : 0).ToString() +
                    " WHERE [POPartsID] = " + dataGridInputs[0, curRow].Value.ToString());
                
                ((MainForm)MdiParent).dbCtrl.SendQuery("IF(SELECT COUNT(*) FROM [POParts] WHERE [POPartsPOID] = " + curPOID + " AND [POPartIsComplete] = 0) = 0 BEGIN " +
                    " UPDATE [POs] SET [POIsComplete] = 1 WHERE [POID] = " + curPOID +
                    " END");

                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [Parts] SET " +
                    "[PartCurrentQuantity] = " +
                        "((SELECT [PartCurrentQuantity] FROM [Parts] WHERE [PartID] = " + curPartID + ") + " +
                            inputRegist.txtBoxInputQuantity.Text + ") " +
                    " WHERE [PartID] = " + curPartID);

                InputTable();
            }
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            button_condition.Enabled = false;
            InputTable();            
        }

        private void InputTable()
        {
            string query = "SELECT " +
                        "[POPartsID] " +
                        ",[POPartsPOID] " +
                        ",[POPartsPartID] " +                        
                        ",PONumber [PO번호] " +
                        ",PONumRevion [PO Rev.] " +
                        ",[PartsCode] [코드]" +
                        ",[PartNumber] [자재NO.]" +
                        ",[PartName] [Part명]" +
                        ",[VendorName] [공급업체] " +
                        ",[PartManufacture] [제조업체] " +
                        ",[PartDrawingNumber] [도면번호] " +
                        ",[PartMakerPNRV] [도면Revision] " +
                        ",[PartMakerPN] [Maker P/N] " +
                        ",[PartUnit] [단위] " +
                //convert(VARCHAR, convert(MONEY,POPartInputMinusTotalAmount),1)
                        ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1) [단가] " +                        
                        ",[POPartQuantity] [PO수량] " +
                        ",convert(VARCHAR, convert(MONEY,POPartTotalAmount),1) [총금액] " +
                        ",[POPartInputQuantity] [입고수량] " +
                        ", ISNULL([POPartMechineQuantity], 0) " +
                                "[제작 장비수] " +
                        ", ISNULL([POPartRequirementsPartsQuantity], 0) " +
                                "[필요 parts] " +
                       // ",[POPartRequirementsPartsQuantity] [필요 parts] " +
                        ",convert(VARCHAR, convert(MONEY,POPartInputTotalAmount),1) [총입고금액] " +
                        ",[POPartInputMinusQuantity] [미입고수량] " +
                        ",convert(VARCHAR, convert(MONEY,POPartInputMinusTotalAmount),1) [미입고금액] " +
                       ",CASE [PartUnitPriceType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +
                                "END [화폐단위] " +
                        //",CONVERT(VARCHAR(10), [POPartInputResolver], 120) [입고처리자] " +
                        ",ISNULL(CONVERT(VARCHAR(10), [POPartInputResolver], 120), '미입력')[입고처리자] " +
                        ",ISNULL(CONVERT(VARCHAR(10), [POPartInputDate], 120), '미입력') [입고날짜] " +
                       // ",ISNULL([POPartInputComment], '미입력') [기타] " +
                     "FROM (([POParts] LEFT JOIN [Parts] ON [POPartsPartID] = [PartID]) " +
                        "LEFT JOIN [POs] ON [POPartsPOID] = [POID]) " +
                        "LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID] ";

            if (!ckBoxAll.Checked) query = query + " WHERE [POPartIsComplete] = 0";
            query = query + " ORDER BY [POPartsID] DESC ";

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridInputs, 3);

            dataGridInputs.Columns["PO수량"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridInputs.Columns["입고수량"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridInputs.Columns["미입고수량"].DefaultCellStyle.ForeColor = Color.Red;

            int inputCnt = dataGridInputs.RowCount;
            label2.Text = "입고대기 갯수 : " + inputCnt.ToString();           
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            InputTable();
        }

        private void dataGridInputs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRegist_Click(sender, e);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
            if (dataGridInputs.CurrentRow == null) return;

            InputRegist inputUpdate = new InputRegist(((MainForm)MdiParent).dbCtrl.sqlConn);
            inputUpdate.btnSave.Text = "수정";
            int curRow = dataGridInputs.CurrentRow.Index;

            //String complateChekQuery = "SELECT [POPartIsComplete] FROM [POParts] WHERE [POPartsPartID] = " + dataGridInputs[2, curRow].Value.ToString();
            //bool checkUse = ((MainForm)MdiParent).dbCtrl.CheckUse(complateChekQuery);
                       
            inputUpdate.txtBoxPONumber.Text = dataGridInputs["PO번호", curRow].Value.ToString();
            inputUpdate.txtBoxPORevision.Text = dataGridInputs["PO Rev.", curRow].Value.ToString();//revison
            inputUpdate.textBox_code.Text = dataGridInputs["코드", curRow].Value.ToString();
            inputUpdate.txtBoxPartName.Text = dataGridInputs["Part명", curRow].Value.ToString();
            inputUpdate.txtBoxVendor.Text = dataGridInputs["공급업체", curRow].Value.ToString();
            inputUpdate.txtBoxManufacture.Text = dataGridInputs["제조업체", curRow].Value.ToString();
            inputUpdate.txtBoxMakerPN.Text = dataGridInputs["Maker P/N", curRow].Value.ToString();
            inputUpdate.txtBoxUnit.Text = dataGridInputs["단위", curRow].Value.ToString();
            inputUpdate.txtBoxUnitPrice.Text = dataGridInputs["단가", curRow].Value.ToString();
            inputUpdate.txtBoxPOQuantity.Text = dataGridInputs["PO수량", curRow].Value.ToString();
            inputUpdate.txtBoxPOTotalAmount.Text = dataGridInputs["총금액", curRow].Value.ToString();
            inputUpdate.txtBoxInputQuantity.Text = dataGridInputs["입고수량", curRow].Value.ToString();
            inputUpdate.txtBoxInputTotalAmount.Text = dataGridInputs["총입고금액", curRow].Value.ToString();
            if (inputUpdate.txtBoxInputTotalAmount.Text == "")
            {
                inputUpdate.txtBoxInputTotalAmount.Text = "0";
            }
            inputUpdate.txtBoxMinusQuantity.Text = dataGridInputs["미입고수량", curRow].Value.ToString();
            if (inputUpdate.txtBoxMinusQuantity.Text == "")
            {
                inputUpdate.txtBoxMinusQuantity.Text = "0";
            }
            inputUpdate.txtBoxMinusTotalAmount.Text = dataGridInputs["미입고금액", curRow].Value.ToString();
            if (inputUpdate.txtBoxMinusTotalAmount.Text == "")
            {
                inputUpdate.txtBoxMinusTotalAmount.Text = "0";
            }
            inputUpdate.txtBoxResolver.Text = dataGridInputs["입고처리자", curRow].Value.ToString();
           // inputUpdate.txtInputComment.Text = dataGridInputs["기타", curRow].Value.ToString();

            string query = "select [PartNeedParts] from [Parts] where [PartID]='" + Convert.ToInt16(dataGridInputs[2, curRow].Value) + "'";
            needParts = ((MainForm)MdiParent).dbCtrl.GetNeedParts(query);
            if (inputUpdate.ShowDialog() == DialogResult.OK)
            {
                int intputQuantity = Convert.ToInt16(inputUpdate.txtBoxInputQuantity.Text);
                int machineQuantity = intputQuantity / needParts;//제작장비 갯수
                int needQuantity = needParts - (intputQuantity % needParts);//필요수량

                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [POParts] SET " +
                    "[POPartMechineQuantity] =" + machineQuantity +
                    ",[POPartRequirementsPartsQuantity]=" + needQuantity +
                    " WHERE [POPartsID] = " + dataGridInputs[0, curRow].Value.ToString());

                int curPOID = Convert.ToInt16(dataGridInputs[1, curRow].Value);
                int curPartID = Convert.ToInt16(dataGridInputs[2, curRow].Value);

                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [Inputs] SET " +
                   "[InputPOID] = " + curPOID +
                   ",[InputPartID] = " + curPartID +
                   ",[InputQuantity] = " + inputUpdate.txtBoxInputQuantity.Text +
                   ",[InputTotalAmount] = " + inputUpdate.txtBoxInputTotalAmount.Text +
                   ",[InputMinusQuantity] = '" + inputUpdate.txtBoxMinusQuantity.Text +
                   ",[InputMinusTotalAmount] = '" + inputUpdate.txtBoxMinusTotalAmount.Text +
                   ",[InputComment] = ''" +
                   ",[InputResolver] = " + inputUpdate.txtBoxResolver.Text +                   
                   " WHERE [POPartsID] = " + dataGridInputs[0, curRow].Value.ToString());

                
                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [POParts] SET " +
                   "[POPartInputQuantity] = (SELECT SUM([InputQuantity]) FROM [Inputs] WHERE [InputPOID] = " + curPOID + " AND [InputPartID] = " + curPartID + ") " +//수량을 합한다.
                   ",[POPartInputTotalAmount] = (SELECT SUM([InputTotalAmount]) FROM [Inputs] WHERE [InputPOID] = " + curPOID + " AND [InputPartID] = " + curPartID + ") " +
                   ",[POPartInputMinusQuantity] = " + inputUpdate.txtBoxMinusQuantity.Text +
                   ",[POPartInputMinusTotalAmount] = " + inputUpdate.txtBoxMinusTotalAmount.Text +
                   ",[POPartInputResolver] = '" + inputUpdate.txtBoxResolver.Text + "'" +
                   ",[POPartInputDate] = '" + inputUpdate.dateTimeInputDate.Value.ToShortDateString() + "'" +
                   ",[POPartInputComment] = ''" +
                   ",[POPartIsComplete] = " + ((inputUpdate.isComplete) ? 1 : 0).ToString() +
                   " WHERE [POPartsID] = " + dataGridInputs[0, curRow].Value.ToString());
                
                ((MainForm)MdiParent).dbCtrl.SendQuery("IF(SELECT COUNT(*) FROM [POParts] WHERE [POPartsPOID] = " + curPOID + " AND [POPartIsComplete] = 0) = 0 BEGIN " +
                   " UPDATE [POs] SET [POIsComplete] = 1 WHERE [POID] = " + curPOID +
                   " END");                            
               
                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [Parts] SET " +
                    "[PartCurrentQuantity] = " +
                        "((SELECT [PartCurrentQuantity] FROM [Parts] WHERE [PartID] = " + curPartID + ") + " +
                            inputUpdate.txtBoxInputQuantity.Text + ") " +
                    " WHERE [PartID] = " + curPartID);

                InputTable();
            }
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
                        "[POPartsID] " +
                        ",[POPartsPOID] " +
                        ",[POPartsPartID] " +
                        ",PONumber [PO번호] " +
                        ",PONumRevion [PO Rev.] " +
                        ",[PartsCode] [코드]" +
                        ",[PartNumber] [자재NO.]" +
                        ",[PartName] [Part명]" +
                        ",[VendorName] [공급업체] " +
                        ",[PartManufacture] [제조업체] " +
                        ",[PartDrawingNumber] [도면번호] " +
                        ",[PartMakerPNRV] [도면Revision] " +
                        ",[PartMakerPN] [Maker P/N] " +
                        ",[PartUnit] [단위] " +
                         ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1) [단가] " +
                        ",[POPartQuantity] [PO수량] " +
                        ",convert(VARCHAR, convert(MONEY,POPartTotalAmount),1) [총금액] " +
                        ",[POPartInputQuantity] [입고수량] " +
                        ",[POPartMechineQuantity] [제작 장비수] " +
                        ",[POPartRequirementsPartsQuantity] [필요 parts] " +
                        ",convert(VARCHAR, convert(MONEY,POPartInputTotalAmount),1) [총입고금액] " +
                        ",[POPartInputMinusQuantity] [미입고수량] " +
                        ",convert(VARCHAR, convert(MONEY,POPartInputMinusTotalAmount),1) [미입고금액] " +
                       ",CASE [PartUnitPriceType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +
                                "END [화폐단위] " +
                        ",CONVERT(VARCHAR(10), [POPartInputResolver], 120) [입고처리자] " +
                        ",CONVERT(VARCHAR(10), [POPartInputDate], 120) [입고날짜] " +
                        ",[POPartInputComment] [기타] " +
                     "FROM (([POParts] LEFT JOIN [Parts] ON [POPartsPartID] = [PartID]) " +
                        "LEFT JOIN [POs] ON [POPartsPOID] = [POID]) " +
                        "LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID] ";

            if (!ckBoxAll.Checked)
            {
                query = query + " WHERE [PartIsUse] = 1 AND " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [POID] DESC";
            }
            else
            {
                query = query + " WHERE " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [POID] DESC";
            }
           
            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridInputs, 3);

            dataGridInputs.Columns["PO수량"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridInputs.Columns["입고수량"].DefaultCellStyle.ForeColor = Color.Red;
            dataGridInputs.Columns["미입고수량"].DefaultCellStyle.ForeColor = Color.Red;

            int inputCnt = dataGridInputs.RowCount;
            label2.Text = "입고대기 갯수 : " + inputCnt.ToString();
        }

        private void cbBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_condition.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("입고", dataGridInputs);
        }
    }
}
