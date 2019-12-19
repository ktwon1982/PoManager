﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;

namespace POManager
{
    public partial class VendorsForm : Form
    {
        public VendorsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            VendorAdd frmVendorAdd = new VendorAdd();

            frmVendorAdd.Text = btnAdd.Text;
            frmVendorAdd.btnSave.Text = "저 장";
            frmVendorAdd.txtBoxName.Enabled = true;
            frmVendorAdd.ckBoxIsUse.Enabled = false;

            frmVendorAdd.cbBoxCategory.SelectedIndex = 0;
            frmVendorAdd.cbBoxPayment.SelectedIndex = 0;
            frmVendorAdd.cbBoxDelivery.SelectedIndex = 0;

            if (frmVendorAdd.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [Vendors] (" +
                    "[VendorCode] " +
                    ",[VendorName] " +
                    ",[VendorAddr1] " +
                    ",[VendorAddr2] " +
                    ",[VendorAddr3] " +
                    ",[VendorCategory] " +
                    ",[VendorHomepage] " +
                    ",[VendorTel] " +
                    ",[VendorPaymentTerms] " +
                    ",[VendorDeliveryCondition] " +
                    ",[VendorComment]) VALUES ( " +
                    "'" + frmVendorAdd.textBox_vendorCode.Text + "'," +
                    "'" + frmVendorAdd.txtBoxName.Text + "'," +
                    "'" + frmVendorAdd.txtBoxAddr1.Text + "'," +
                    "'" + frmVendorAdd.txtBoxAddr2.Text + "'," +
                    "'" + frmVendorAdd.txtBoxAddr3.Text + "'," +
                    frmVendorAdd.cbBoxCategory.SelectedIndex + "," +
                    "'" + frmVendorAdd.txtBoxHomepage.Text + "'," +
                    "'" + frmVendorAdd.txtBoxTel.Text + "'," +
                    frmVendorAdd.cbBoxPayment.SelectedIndex + "," +
                    frmVendorAdd.cbBoxDelivery.SelectedIndex + "," +
                    "'" + frmVendorAdd.txtBoxComment.Text + "'" +
                    " )");

                LoadVendorTable();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dataGridVendors.CurrentRow == null) return;

            VendorAdd frmVendorModify = new VendorAdd();

            frmVendorModify.Text = btnModify.Text;
            frmVendorModify.btnSave.Text = "수 정";
            //frmVendorModify.txtBoxName.Enabled = false;
            frmVendorModify.ckBoxIsUse.Enabled = true;

            int curRow = dataGridVendors.CurrentRow.Index;
            frmVendorModify.ckBoxIsUse.Checked = (Convert.ToBoolean(dataGridVendors[1, curRow].Value)) ? true : false;
            frmVendorModify.textBox_vendorCode.Text = dataGridVendors["코드", curRow].Value.ToString();
            frmVendorModify.txtBoxName.Text = dataGridVendors["업체명", curRow].Value.ToString();
            frmVendorModify.txtBoxAddr1.Text = dataGridVendors["본사 주소", curRow].Value.ToString();
            frmVendorModify.txtBoxAddr2.Text = dataGridVendors["공장 주소", curRow].Value.ToString();
            frmVendorModify.txtBoxAddr3.Text = dataGridVendors["지사/사무소 주소", curRow].Value.ToString();
            //frmVendorModify.cbBoxCategory.SelectedIndex = Convert.ToInt16(dataGridVendors[2, curRow].Value); 
            frmVendorModify.txtBoxHomepage.Text = dataGridVendors["홈페이지", curRow].Value.ToString();
            frmVendorModify.txtBoxTel.Text = dataGridVendors["연락처", curRow].Value.ToString();
            frmVendorModify.cbBoxPayment.SelectedIndex = Convert.ToInt16(dataGridVendors[3, curRow].Value);  
            frmVendorModify.cbBoxDelivery.SelectedIndex = Convert.ToInt16(dataGridVendors[4, curRow].Value); 
            frmVendorModify.txtBoxComment.Text = dataGridVendors["비고", curRow].Value.ToString();

            if (frmVendorModify.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [Vendors] SET " +
                    "[VendorModifyDate] = GETDATE() " +
                    ",[VendorCode] = '" + frmVendorModify.textBox_vendorCode.Text + "'" +
                    ",[VendorName] = '" + frmVendorModify.txtBoxName.Text + "'" +
                    ",[VendorAddr1] = '" + frmVendorModify.txtBoxAddr1.Text + "'" +
                    ",[VendorAddr2] = '" + frmVendorModify.txtBoxAddr2.Text + "'" +
                    ",[VendorAddr3] = '" + frmVendorModify.txtBoxAddr2.Text + "'" +
                    ",[VendorCategory] = " + frmVendorModify.cbBoxCategory.SelectedIndex +
                    ",[VendorHomepage] = '" + frmVendorModify.txtBoxHomepage.Text + "'" +
                    ",[VendorTel] = '" + frmVendorModify.txtBoxTel.Text + "'" +
                    ",[VendorPaymentTerms] = " + frmVendorModify.cbBoxPayment.SelectedIndex +
                    ",[VendorDeliveryCondition] = " + frmVendorModify.cbBoxDelivery.SelectedIndex +
                    ",[VendorComment] = '" + frmVendorModify.txtBoxComment.Text + "'" +
                    ",[VendorIsUse] = " + ((frmVendorModify.ckBoxIsUse.Checked) ? 1 : 0).ToString() + " " +
                    "WHERE [VendorID] = " + dataGridVendors[0, curRow].Value.ToString());

                LoadVendorTable();
            }
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {            
            cbBoxCategory.SelectedIndex = 0;
            LoadVendorTable();
        }

        private void LoadVendorTable()
        {
            ((MainForm)MdiParent).dbCtrl.ConditionQuery = "";

            string query = "SELECT " +
                        "[VendorID] " +
                        ",[VendorIsUse] " +
                        ",[VendorCategory] " +
                        ",[VendorPaymentTerms] " +
                        ",[VendorDeliveryCondition] " +
                        ",[VendorCode] [코드] " + 
                        ",[VendorName] [업체명] " +                      
                        ",CONVERT(VARCHAR(10), [VendorRecordDate], 120) [등록일] " +
                        ",[VendorAddr1] [본사 주소] " +
                        ",[VendorAddr2] [공장 주소] " +
                        ",[VendorAddr3] [지사/사무소 주소] " +
                        ",CASE [VendorCategory] " + 
                                "WHEN 0 THEN '공급업체' "+
                                "WHEN 1 THEN '제조업체' "+
                                "END [거래처구분] " +
                        ",[VendorHomepage] [홈페이지] " +
                        ",[VendorTel] [연락처] " +
                        ",CASE [VendorPaymentTerms] " +
                                "WHEN 0 THEN '세금계산서 발행후 30일' " +
                                "WHEN 1 THEN '세금계산서 발행후 45일' " +
                                "WHEN 2 THEN '세금계산서 발행후 60일' " +
                                "WHEN 3 THEN '30%/70% 45일' " +
                                "WHEN 4 THEN '30%/70% 현금' " +
                                "WHEN 5 THEN '30%/70% 선결재' " +
                                "WHEN 6 THEN '현금결재' " +
                                "WHEN 7 THEN '익월말 결재' " +
                                "WHEN 8 THEN '선결재' " +
                                "WHEN 9 THEN '해회송금' " +
                                "END [결제조건] " +
                        ",CASE [VendorDeliveryCondition] " +
                                "WHEN 0 THEN '공장인도' " +
                                "END [납품조건] " +
                        ",[VendorComment] [비고] " +
                    "FROM [Vendors] ";

            if (!ckBoxAll.Checked) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[VendorIsUse] = 1", false);
            if (cbBoxCategory.SelectedIndex > 0) ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[VendorCategory] = " + (cbBoxCategory.SelectedIndex - 1), false);
            ((MainForm)MdiParent).dbCtrl.MakeConditionQuery("[VendorID]", true);

            query += ((MainForm)MdiParent).dbCtrl.ConditionQuery;
            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridVendors, 5);
            
            int companyNum = dataGridVendors.RowCount;
            label4.Text = "업체수 : " + companyNum.ToString();  
        }

        private void LoadContactTable(int vendorID)
        {
            string query = "SELECT " +
                        "[ContactID] " +
                        ",[ContactIsUse] " +
                        ",[ContactName] [성명] " +
                        ",[ContactTitle] [직책] " +
                        ",[ContactTel] [Tel.] " +
                        ",[ContactCell] [Mobile.] " +
                        ",[ContactFax] [Fax.] " +
                        ",[ContactMail] [Email] " +
                    "FROM [Contacts] " +
                    "WHERE ContactVendorID = " + vendorID;

            if (!ckBoxAll.Checked) query = query + " AND [ContactIsUse] = 1 ";
            query = query + " ORDER BY [ContactID] ";

            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, dataGridContacts, 2);
        }

        private void btnContactAdd_Click(object sender, EventArgs e)
        {
            if (dataGridVendors.CurrentRow == null) return;

            ContactAdd frmContactAdd = new ContactAdd();

            frmContactAdd.Text = btnContactAdd.Text;
            frmContactAdd.btnSave.Text = "저 장";
            frmContactAdd.ckBoxIsUse.Enabled = false;

            int curVendorRow = dataGridVendors.CurrentRow.Index;
            //frmContactAdd.txtBoxVendorName.Text = dataGridVendors[5, curVendorRow].Value.ToString();

            if (frmContactAdd.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("INSERT INTO [Contacts] (" +
                    "[ContactVendorID] " +
                    ",[ContactName] " +
                    ",[ContactTitle] " +
                    ",[ContactTel] " +
                    ",[ContactCell] " +
                    ",[ContactFax] " +
                    ",[ContactMail]) VALUES ( " +
                    dataGridVendors[0, curVendorRow].Value.ToString() + "," +
                    "'" + frmContactAdd.txtBoxName.Text + "'," +
                    "'" + frmContactAdd.txtBoxTitle.Text + "'," +
                    "'" + frmContactAdd.txtBoxTel.Text + "'," +
                    "'" + frmContactAdd.txtBoxCell.Text + "'," +
                    "'" + frmContactAdd.txtBoxFax.Text + "'," +
                    "'" + frmContactAdd.txtBoxEmail.Text + "'" +
                    " )");

                LoadContactTable(Convert.ToInt16(dataGridVendors[0, curVendorRow].Value));
            }
        }

        private void btnContactModify_Click(object sender, EventArgs e)
        {
            if ((dataGridVendors.CurrentRow == null) || (dataGridContacts.CurrentRow == null)) return;

            ContactAdd frmContactModify = new ContactAdd();

            frmContactModify.Text = btnContactModify.Text;
            frmContactModify.btnSave.Text = "수 정";
            frmContactModify.ckBoxIsUse.Enabled = true;

            int curVendorRow = dataGridVendors.CurrentRow.Index;
            int curRow = dataGridContacts.CurrentRow.Index;
            //frmContactModify.txtBoxVendorName.Text = dataGridVendors[5, curVendorRow].Value.ToString();
            frmContactModify.ckBoxIsUse.Checked = (Convert.ToBoolean(dataGridContacts[1, curRow].Value)) ? true : false;
            frmContactModify.txtBoxName.Text = dataGridContacts["성명", curRow].Value.ToString();
            frmContactModify.txtBoxTitle.Text = dataGridContacts["직책", curRow].Value.ToString();
            frmContactModify.txtBoxTel.Text = dataGridContacts["Tel.", curRow].Value.ToString();
            frmContactModify.txtBoxCell.Text = dataGridContacts["Mobile.", curRow].Value.ToString();
            frmContactModify.txtBoxFax.Text = dataGridContacts["Fax.", curRow].Value.ToString();
            frmContactModify.txtBoxEmail.Text = dataGridContacts["Email", curRow].Value.ToString();

            if (frmContactModify.ShowDialog() == DialogResult.OK)
            {
                ((MainForm)MdiParent).dbCtrl.SendQuery("UPDATE [Contacts] SET " +
                    "[ContactModifyDate] = GETDATE() " +
                    ",[ContactName] = '" + frmContactModify.txtBoxName.Text + "'" +
                    ",[ContactTitle] = '" + frmContactModify.txtBoxTitle.Text + "'" +
                    ",[ContactTel] = '" + frmContactModify.txtBoxTel.Text + "'" +
                    ",[ContactCell] = '" + frmContactModify.txtBoxCell.Text + "'" +
                    ",[ContactFax] = '" + frmContactModify.txtBoxFax.Text + "'" +
                    ",[ContactMail] = '" + frmContactModify.txtBoxEmail.Text + "'" +
                    ",[ContactIsUse] = " + ((frmContactModify.ckBoxIsUse.Checked) ? 1 : 0).ToString() + " " +
                    "WHERE [ContactID] = " + dataGridContacts[0, curRow].Value.ToString());

                LoadContactTable(Convert.ToInt16(dataGridVendors[0, curVendorRow].Value));
            }
        }

        private void ckBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadVendorTable();

            if ((dataGridVendors.CurrentRow == null) || (dataGridVendors.CurrentRow.Index < 0)) return;

            LoadContactTable(Convert.ToInt16(dataGridVendors[0, dataGridVendors.CurrentRow.Index].Value));
        }

        private void dataGridVendor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            LoadContactTable(Convert.ToInt16(dataGridVendors[0, e.RowIndex].Value));
        }

        private void VendorForm_Activated(object sender, EventArgs e)
        {
            if ((dataGridVendors.CurrentRow == null) || (dataGridVendors.CurrentRow.Index < 0)) return;
            
            LoadContactTable(Convert.ToInt16(dataGridVendors[0, dataGridVendors.CurrentRow.Index].Value));
        }

        private void dataGridVendors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModify_Click(sender, e);
        }

        private void dataGridContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnContactModify_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("업체리스트",dataGridVendors);
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveExel saveExel = new SaveExel("업체담당자",dataGridContacts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String query = "select  (select PartName from Parts where PartID =  POPartsPartID ) [자재명],"+
                            "POPartQuantity [발주수량], POPartRecordDate [발주날짜]" +  
                            "from POParts";
            bool flag = true;
            if (dataGridVendors.CurrentRow == null) return;
            POpartsHistory poparthistory = new POpartsHistory();
            int curVendorRow = dataGridVendors.CurrentRow.Index;
            int vendorID = Convert.ToInt16(dataGridVendors[0, curVendorRow].Value);
            poparthistory.textBox_vendorName.Text = dataGridVendors["업체명", curVendorRow].Value.ToString();
            ArrayList POIDs = ((MainForm)MdiParent).dbCtrl.GetPOIDs(vendorID);

            IEnumerator enu = POIDs.GetEnumerator();
            
            while (enu.MoveNext())
            {
                int poid = Convert.ToInt32(enu.Current);
                if (flag)
                {
                    query = query + " WHERE POPartsPOID = " + poid;
                    flag = false;
                }
                else
                {
                    query = query + " OR POPartsPOID = " + poid;                    
                }
            }
            ((MainForm)MdiParent).dbCtrl.UpdateTable(query, poparthistory.dataGridPOParts,0);
            poparthistory.ShowDialog();
        }
    }
}
