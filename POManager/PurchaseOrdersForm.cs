﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace POManager
{
    public partial class PurchaseOrdersForm : Form
    {
        int modify_poid;
        bool flag = true;

        public PurchaseOrdersForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            POAdd frmPurchaseOrderAdd = new POAdd(((MainForm)MdiParent).dbCtrl.sqlConn);
            
            frmPurchaseOrderAdd.cbBox_PoGubun.SelectedIndex = 0;
            frmPurchaseOrderAdd.cbBox_PaymentCondition.SelectedIndex = 0;
            frmPurchaseOrderAdd.cbBox_DeliveryCondition.SelectedIndex = 0;

            if (frmPurchaseOrderAdd.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [POs] (" +
                "[POVendorID] " +
                ",[POCategory] " +
                ",[POConsultNumber] " +
                ",[PONumber] " +
                ",[PONumRevion] " +
                ",[POEstimatedDeliveryDate] " +
                ",[PORequestDeliveryDate] " +
                ",[POPaymentTerms] " +
                ",[PODeliveryCondition] " +
                ",[POTotalAmountType] " +
                ",[POTotalAmount]) VALUES ( " +
                frmPurchaseOrderAdd.VendorID + "," +
                frmPurchaseOrderAdd.cbBox_PoGubun.SelectedIndex + "," +
                "'" + frmPurchaseOrderAdd.txtBox_ExpenseNum.Text + "'," +
                "'" + frmPurchaseOrderAdd.txtBox_PoNum.Text + "'," +
                frmPurchaseOrderAdd.PORevision.Value + "," +
                "'" + frmPurchaseOrderAdd.dateTimeEstimate.Value.ToShortDateString() + "'," +
                "'" + frmPurchaseOrderAdd.dateTimeRequest.Text + "'," +
                frmPurchaseOrderAdd.cbBox_PaymentCondition.SelectedIndex + "," +
                frmPurchaseOrderAdd.cbBox_DeliveryCondition.SelectedIndex + "," +
                frmPurchaseOrderAdd.comboBox_moneyTypeEX.SelectedIndex + "," +
                frmPurchaseOrderAdd.total +
                " )");
                
                POsTable();         

                if (dataGridPOs.CurrentRow == null) return;

                for (int i = 0; i < frmPurchaseOrderAdd.dataGridPOParts.RowCount; i++)
                {
                    ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [POParts] (" +
                        "[POPartsPOID] " +
                        ",[POPartsPartID] " +
                        ",[POPartQuantity] " +
                        ",[POPartTotalAmount] " +
                        ",[POPartInputQuantity] " +//입고량
                        ",[POPartInputTotalAmount] " +//입고 총액
                        ",[POPartInputMinusQuantity] " +//미입고 수량
                        ",[POPartInputMinusTotalAmount] " +//미입고 금액
                        " ) VALUES ( " +
                        dataGridPOs[0, 0].Value.ToString() + "," +
                        frmPurchaseOrderAdd.dataGridPOParts[0, i].Value.ToString() + "," +
                        frmPurchaseOrderAdd.dataGridPOParts["수량", i].Value.ToString() + "," +   
                         ReStringMoney(frmPurchaseOrderAdd.dataGridPOParts["금액", i].Value.ToString()) + "," +   
                        "0, 0,"+ 
                        frmPurchaseOrderAdd.dataGridPOParts["수량", i].Value.ToString() + "," +
                        ReStringMoney(frmPurchaseOrderAdd.dataGridPOParts["금액", i].Value.ToString()) + ")");
                }
                string searchPoid_query = "SELECT Max([POID]) FROM [POs]";
                int opId = ((MainForm)MdiParent).dbCtrl.GetPOid(searchPoid_query);                
                POPartsTable(opId);                
            }
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

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridPOs.CurrentRow == null) return;

            POAdd frmPurchaseOrderModify = new POAdd(((MainForm)MdiParent).dbCtrl.sqlConn);
                       
            frmPurchaseOrderModify.Text = btnModify.Text;

            if (flag)
            {
                frmPurchaseOrderModify.btn_Save.Text = "수 정";
            }
            else
            {
                frmPurchaseOrderModify.btn_Save.Text = "추가 발주";
            }           
                        
            int curRow = dataGridPOs.CurrentRow.Index;
            frmPurchaseOrderModify.poid = dataGridPOs[0, curRow].Value.ToString();   
            if (dataGridPOs["구분", curRow].Value.ToString().Equals("구매부서 발주품"))
            {
                frmPurchaseOrderModify.cbBox_PoGubun.SelectedIndex = 0;
            }
            else
            {
                frmPurchaseOrderModify.cbBox_PoGubun.SelectedIndex = 1;
            }

            frmPurchaseOrderModify.txtBox_ExpenseNum.Text = dataGridPOs["승인번호", curRow].Value.ToString();
            frmPurchaseOrderModify.txtBox_PoNum.Text = dataGridPOs["PO번호", curRow].Value.ToString();
            
            if (flag)
            {
                frmPurchaseOrderModify.PORevision.Value = Convert.ToInt16(dataGridPOs["PO Rev.", curRow].Value) + 1;
            }
            else
            {
                frmPurchaseOrderModify.PORevision.Value = 1;
            }
            if (dataGridPOs["화폐단위", curRow].Value.Equals("원"))
            {
                frmPurchaseOrderModify.comboBox_moneyTypeEX.SelectedIndex = 0;
                frmPurchaseOrderModify.comboBox_moneyTypeTotal.SelectedIndex = 0;
            }
            else
            {
                frmPurchaseOrderModify.comboBox_moneyTypeEX.SelectedIndex = 1;
                frmPurchaseOrderModify.comboBox_moneyTypeTotal.SelectedIndex = 1;
            }
            frmPurchaseOrderModify.dateTimeEstimate.Value = Convert.ToDateTime(dataGridPOs["예상납기일", curRow].Value);

            if (dataGridPOs["요청납기일", curRow].ToString() == "DataGridViewTextBoxCell { ColumnIndex=12, RowIndex=0 }")
            {
                frmPurchaseOrderModify.dateTimeRequest.Text = "";
            }
            else
            {
                frmPurchaseOrderModify.dateTimeRequest.Text = dataGridPOs["요청납기일", curRow].ToString();
            }

            if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("세금계산서 발행후 30일"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 0;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("세금계산서 발행후 45일"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 1;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("세금계산서 발행후 60일"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 2;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("30%/70% 45일"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 3;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("30%/70% 현금"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 4;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("30%/70% 선결재"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 5;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("현금결재"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 6;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("익월말 결재"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 7;
            }
            else if (dataGridPOs["결제조건", curRow].Value.ToString().Equals("선결재"))
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 8;
            }
            else
            {
                frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex = 9;
            }

            frmPurchaseOrderModify.cbBox_DeliveryCondition.SelectedIndex = 0;           

            string getVenderIDquery = "SELECT " + 
                 "[VendorID] " +                     
                 "FROM [Vendors] " +
                 "WHERE [VendorIsUse] = 1 AND [VendorName] =" +"'"+ dataGridPOs[5, curRow].Value.ToString()+"'";

            frmPurchaseOrderModify.VendorID = ((MainForm)MdiParent).dbCtrl.GetVendorID(getVenderIDquery);

            string query = "SELECT " +
                "[PartID] " +
                ",[POPartsID] " +
                ",[POPartsPartID] " +
                ",[PartNumber] [자재 NO.] " +
                ",[PartName] [자재명] " +
                ",[VendorName] [공급업체] " +
                ",[PartManufacture] [제조업체] " +
                ",[PartDrawingNumber] [도면번호] " +
                ",[PartMakerPN] [Maker P/N]" +
                ",[PartUnit] [단위] " +
                ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1)  [단가] " +
                ",[POPartQuantity] [수량] " +             
                ",convert(VARCHAR, convert(MONEY,POPartTotalAmount),1)  [금액] " +
                ",CASE [PartUnitPriceType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +
                                "END [화폐단위] " +
            "FROM ([POParts] LEFT JOIN [Parts] ON [POPartsPartID] = [PartID]) LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID] " +
            "WHERE [POPartsPOID] = " + modify_poid;

            if (!ckBoxAll.Checked) query = query + " AND [POPartIsUse] = 1 ";
            query = query + " ORDER BY [POPartsID] ";

            ArrayList entity = ((MainForm)MdiParent).dbCtrl.GetData(query);

            IEnumerator enu = entity.GetEnumerator();
            while (enu.MoveNext())
            {
                PartsDTO date = (PartsDTO)enu.Current;
                
                frmPurchaseOrderModify.UpdateAddParts(date.getPartID(), date.getPartNo(), date.getPartName(), date.getVendorName(),
                                                      date.getPartManufacture(), date.getPartDrawingNumber(),
                                                      date.getPartMakerPN(),date.getPartUnit(),date.getPartUnitPrice(),
                                                      date.getPOPartQuantity(), date.getPOPartTotalAmount(), date.getPriceType());

                frmPurchaseOrderModify.total += date.getPOPartTotalAmount();
            }
            frmPurchaseOrderModify.dataGridPOParts.Columns[0].Visible = false;            
            
            if (frmPurchaseOrderModify.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [POs] SET " +
                    "[POIsComplete] = 1,"+
                    "[POIsUse] = 0 " + 
                    "WHERE [POID] = " + dataGridPOs[0, curRow].Value.ToString());

                if (Convert.ToInt16(frmPurchaseOrderModify.PORevision.Value)>1)
                {
                                    
                   ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [POParts] SET " +
                    "[POPartIsComplete] = 1"+                    
                    "WHERE [POPartsPOID] = " + modify_poid);
                    
                }

                ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [POs] (" +
               "[POVendorID] " +
               ",[POCategory] " +
               ",[POConsultNumber] " +
               ",[PONumber] " +
               ",[PONumRevion] " +
               ",[POEstimatedDeliveryDate] " +
               ",[PORequestDeliveryDate] " +
               ",[POPaymentTerms] " +
               ",[PODeliveryCondition] " +
               ",[POTotalAmountType] " +
               ",[POTotalAmount]) VALUES ( " +
               frmPurchaseOrderModify.VendorID + "," +
               frmPurchaseOrderModify.cbBox_PoGubun.SelectedIndex + "," +
               "'" + frmPurchaseOrderModify.txtBox_ExpenseNum.Text + "'," +
               "'" + frmPurchaseOrderModify.txtBox_PoNum.Text + "'," +
               frmPurchaseOrderModify.PORevision.Value + "," +
               "'" + frmPurchaseOrderModify.dateTimeEstimate.Value.ToShortDateString() + "'," +
               "'" + frmPurchaseOrderModify.dateTimeRequest.Text + "'," +
               frmPurchaseOrderModify.cbBox_PaymentCondition.SelectedIndex + "," +
               frmPurchaseOrderModify.cbBox_DeliveryCondition.SelectedIndex + "," +
               frmPurchaseOrderModify.comboBox_moneyTypeEX.SelectedIndex + "," +
               frmPurchaseOrderModify.total +
               " )");

                POsTable();

                if (dataGridPOs.CurrentRow == null) return;

                for (int i = 0; i < frmPurchaseOrderModify.dataGridPOParts.RowCount; i++)
                {
                    ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [POParts] (" +
                         "[POPartsPOID] " +
                        ",[POPartsPartID] " +
                        ",[POPartQuantity] " +
                        ",[POPartTotalAmount] " +
                        ",[POPartInputQuantity] " +//입고량
                        ",[POPartInputTotalAmount] " +//입고 총액
                        ",[POPartInputMinusQuantity] " +//미입고 수량
                        ",[POPartInputMinusTotalAmount] " +//미입고 금액
                        " ) VALUES ( " +
                        dataGridPOs[0, 0].Value.ToString() + "," +
                        frmPurchaseOrderModify.dataGridPOParts[0, i].Value.ToString() + "," +
                        frmPurchaseOrderModify.dataGridPOParts["수량", i].Value.ToString() + "," +
                        //frmPurchaseOrderModify.dataGridPOParts["금액", i].Value.ToString() + "," +
                        ReStringMoney(frmPurchaseOrderModify.dataGridPOParts["금액", i].Value.ToString()) + "," +
                        "0, 0," +
                        frmPurchaseOrderModify.dataGridPOParts["수량", i].Value.ToString() + "," +
                        //frmPurchaseOrderModify.dataGridPOParts["금액", i].Value.ToString()+")");
                        ReStringMoney(frmPurchaseOrderModify.dataGridPOParts["금액", i].Value.ToString()) + ")");
                }
                string searchPoid_query = "SELECT Max([POID]) FROM [POs]";
                int opId = ((MainForm)MdiParent).dbCtrl.GetPOid(searchPoid_query);                             
                POPartsTable(opId);

            }
        }

        private void PurchaseOrderForm_Load(object sender, EventArgs e)
        {            
            Radio_enable();
            POsTable();
            try
            {
                POPartsTable(Convert.ToInt16(dataGridPOs[0, 1].Value));
            }catch(Exception exc){

            }
        }

        private void POsTable()
        {
            var DateFrom = dateTimePickerDateFrom.Value.ToString("yyyy-MM-dd");
            var DateTo = dateTimePickerDateTo.Value.AddDays(1).ToString("yyyy-MM-dd");

            ((MainForm)MdiParent).dbCtrl.ConditionQuery = "";

            string query = "SELECT " +
                        "[POID] " +
                        ",[POCategory] " +
                        ",[POPaymentTerms] " +
                        ",[PODeliveryCondition] " +
                        ",CASE [POCategory] " +
                                "WHEN 0 THEN '구매부서 발주품' " +
                                "WHEN 1 THEN '구매요청 발주품' " +
                                "END [구분] " +
                        ",[VendorName] [공급업체] " +
                        ",[POConsultNumber] [승인번호] " +
                        ",[PONumber] [PO번호] " +
                        ",[PONumRevion] [PO Rev.] " +            
                        ",convert(VARCHAR, convert(MONEY,POTotalAmount),1)  [총금액] " +
                         ",CASE [POTotalAmountType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +
                                "END [화폐단위] " +
                        ",CONVERT(VARCHAR(10), [POEstimatedDeliveryDate], 120) [예상납기일] " +
                        ",CONVERT(VARCHAR(10), [PORequestDeliveryDate], 120) [요청납기일] " +
                        ",CASE [POPaymentTerms] " +
                                "WHEN 0 THEN '세금계산서 발행후 30일' " +
                                "WHEN 1 THEN '세금계산서 발행후 45일' " +
                                "WHEN 2 THEN '세금계산서 발행후 60일' " +
                                "WHEN 3 THEN '30%/70% 45일' " +
                                "WHEN 4 THEN '30%/70% 현금' " +
                                "WHEN 5 THEN '30%/70% 선결재' " +
                                "WHEN 6 THEN '현금결재' " +
                                "WHEN 7 THEN '익월말 결재' " +
                                "WHEN 8 THEN '선결재' " +
                                "WHEN 9 THEN '해외송금' " +
                                "END [결제조건] " +
                        ",CASE [PODeliveryCondition] " +
                                "WHEN 0 THEN '공장인도' " +
                                "END [납품조건] " +
                    "FROM [POs] LEFT JOIN [Vendors] ON [POVendorID] = [VendorID]";
        
            if (!ckBoxAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[POIsComplete] = 0", false);
            if (rdBtnDate.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("([PORecordDate] >= '" + DateFrom + "') AND ([PORecordDate] < '" + DateTo + "')", false);
          
            ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[POID] DESC", true);
            query += ((MainForm)MdiParent).dbCtrl.ConditionQuery;

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridPOs, 4);

            int poCnt = dataGridPOs.RowCount;
            label3.Text = "PO 갯수 : " + poCnt.ToString();   
        }

        private void POPartsTable(int POID)
        {
            string query = "SELECT " +
                "[POPartsID] " +
                ",[POPartsPartID] " +
                ",[PartsCode] [코드] " +
                ",[PartNumber] [자재 NO.] " +
                ",[PartName] [자재명] " +
                //",[VendorName] [공급업체] " +
                ",[PartManufacture] [제조업체] " +
                ",[PartDrawingNumber] [도면번호] " +
                 ",[PartMakerPNRV] [도면Revision]" +
                ",[PartMakerPN] [Maker P/N]" +
                ",[PartUnit] [단위] " +
                ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1)  [단가] " +
                ",[POPartQuantity] [수량] " +              
                ",convert(VARCHAR, convert(MONEY,POPartTotalAmount),1)  [금액] " +
                ",CASE [PartUnitPriceType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +
                                "END [화폐단위] " +
                ",[PartNeedParts] [한대당 필요 갯수] " +
            "FROM ([POParts] LEFT JOIN [Parts] ON [POPartsPartID] = [PartID]) LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID] " +
            "WHERE [POPartsPOID] = " + POID;
            query = query + " ORDER BY [POPartsID] ";

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridPOParts, 2);
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            Radio_enable();
            POsTable();

            if ((dataGridPOs.CurrentRow == null) || (dataGridPOs.CurrentRow.Index < 0)) return;

            POPartsTable(Convert.ToInt16(dataGridPOs[0, dataGridPOs.CurrentRow.Index].Value));
        }       

        private void dataGridPOs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            modify_poid = Convert.ToInt16(dataGridPOs[0, e.RowIndex].Value);
            POPartsTable(modify_poid);
        }

        private void PurchaseOrdersForm_Activated(object sender, EventArgs e)
        {
            if ((dataGridPOs.CurrentRow == null) || (dataGridPOs.CurrentRow.Index < 0)) return;
            modify_poid = Convert.ToInt16(dataGridPOs[0, dataGridPOs.CurrentRow.Index].Value);
            POPartsTable(Convert.ToInt16(dataGridPOs[0, dataGridPOs.CurrentRow.Index].Value));
        }

        private void dataGridPOs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModify_Click(sender, e);
        }       

        private void btn_search_Click(object sender, EventArgs e)
        {
            var DateFrom = dateTimePickerDateFrom.Value.ToString("yyyy-MM-dd");           
            var DateTo = dateTimePickerDateTo.Value.AddDays(1).ToString("yyyy-MM-dd");            

            string query = "SELECT " +
                       "[POID] " +
                       ",[POCategory] " +
                       ",[POPaymentTerms] " +
                       ",[PODeliveryCondition] " +
                       ",CASE [POCategory] " +
                               "WHEN 0 THEN '구매부서 발주품' " +
                               "WHEN 1 THEN '구매요청 발주품' " +
                               "END [구분] " +
                       ",[POConsultNumber] [품의서번호] " +
                       ",[PONumber] [PO번호] " +
                       ",[PONumRevion] [PO Rev.] " +                
                       ",convert(VARCHAR, convert(MONEY,POTotalAmount),1)  [총금액] " +
                       ",CONVERT(VARCHAR(10), [POEstimatedDeliveryDate], 120) [예상납기일] " +
                       ",CONVERT(VARCHAR(10), [PORequestDeliveryDate], 120) [요청납기일] " +
                       ",CASE [POPaymentTerms] " +
                               "WHEN 0 THEN '세금계산서 발행후 30일' " +
                               "WHEN 1 THEN '세금계산서 발행후 45일' " +
                               "WHEN 2 THEN '세금계산서 발행후 60일' " +
                               "WHEN 3 THEN '송금' " +
                               "END [결제조건] " +
                       ",CASE [PODeliveryCondition] " +
                               "WHEN 0 THEN '공장인도' " +
                               "END [납품조건] " +
                   "FROM [POs] ";

            if (!ckBoxAll.Checked) query = query + "WHERE ([PORecordDate] >= '" + DateFrom + "') AND ([PORecordDate] < '" + DateTo + "')";
            query = query + " ORDER BY [POID] DESC";
            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridPOs, 4);
        }

        private void Radio_enable()
        {            
            if (rdBtnAll.Checked)
            {
                gb_from.Enabled = false;
                gb_to.Enabled = false;
                btn_search.Enabled = false;
                cbBoxSearch.Enabled = false;
                textBox_condition.Enabled = false;
                button_condition.Enabled = false;
            }
            else if (rdBtnDate.Checked)
            {
                gb_from.Enabled = true;
                gb_to.Enabled = true;
                btn_search.Enabled = true;
                cbBoxSearch.Enabled = false;
                textBox_condition.Enabled = false;
                button_condition.Enabled = false;
            }
            else
            {
                gb_from.Enabled = false;
                gb_to.Enabled = false;
                btn_search.Enabled = false;
                cbBoxSearch.Enabled = true;
                textBox_condition.Enabled = true;
                button_condition.Enabled = false;
            }
        }

        public int GetcurPOID()
        {
            return dataGridPOs.Rows.Count;     
        }

        private void radioButton_condition_CheckedChanged(object sender, EventArgs e)
        {
            Radio_enable();
        }
        private void ConditionSerchingTable()
        {
           
        }

        private void button_condition_Click(object sender, EventArgs e)
        {
            String searchgubun="";
             int searchingGubun = cbBoxSearch.SelectedIndex;
            
            if (searchingGubun==0)
             {
                 searchgubun = "[POConsultNumber]";
             }
             else if (searchingGubun == 1)
             {
                 searchgubun = "[PONumber]";
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
                       "[POID] " +
                       ",[POCategory] " +
                       ",[POPaymentTerms] " +
                       ",[PODeliveryCondition] " +
                       ",CASE [POCategory] " +
                               "WHEN 0 THEN '구매부서 발주품' " +
                               "WHEN 1 THEN '구매요청 발주품' " +
                               "END [구분] " +
                       ",[VendorName] [공급업체] " +
                       ",[POConsultNumber] [승인번호] " +
                       ",[PONumber] [PO번호] " +
                       ",[PONumRevion] [PO Rev.] " +
                       ",convert(VARCHAR, convert(MONEY,POTotalAmount),1)  [총금액] " +
                        ",CASE [POTotalAmountType] " +
                               "WHEN 0 THEN '원' " +
                               "WHEN 1 THEN '달러' " +
                               "END [화폐단위] " +
                       ",CONVERT(VARCHAR(10), [POEstimatedDeliveryDate], 120) [예상납기일] " +
                       ",CONVERT(VARCHAR(10), [PORequestDeliveryDate], 120) [요청납기일] " +
                       ",CASE [POPaymentTerms] " +
                               "WHEN 0 THEN '세금계산서 발행후 30일' " +
                               "WHEN 1 THEN '세금계산서 발행후 45일' " +
                               "WHEN 2 THEN '세금계산서 발행후 60일' " +
                               "WHEN 3 THEN '30%/70% 45일' " +
                               "WHEN 4 THEN '30%/70% 현금' " +
                               "WHEN 5 THEN '30%/70% 선결재' " +
                               "WHEN 6 THEN '현금결재' " +
                               "WHEN 7 THEN '익월말 결재' " +
                               "WHEN 8 THEN '선결재' " +
                               "WHEN 9 THEN '해외송금' " +
                               "END [결제조건] " +
                       ",CASE [PODeliveryCondition] " +
                               "WHEN 0 THEN '공장인도' " +
                               "END [납품조건] " +
                   "FROM [POs] LEFT JOIN [Vendors] ON [POVendorID] = [VendorID]";

            if (!ckBoxAll.Checked)
            {
                query = query + " WHERE [POIsComplete] = 0 AND " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [POID] DESC";
            }
            else
            {
                query = query + " WHERE " + searchgubun + " like" + "'%" + searchingWord + "%' ORDER BY [POID] DESC";
            }      
                                            
            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridPOs, 4);

            int poCnt = dataGridPOs.RowCount;
            label3.Text = "PO 갯수 : " + poCnt.ToString();   
        }

        private void cbBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_condition.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("PO", dataGridPOs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("POParts", dataGridPOParts);
        }
    }
}
