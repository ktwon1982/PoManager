using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace POManager
{
    public partial class POAdd : Form
    {
        public int VendorID;
        public double total;
        public double totalAmount;
        public string poid;
        DataTable table = new DataTable("AddPart");
        DataColumn column;
        string vendor="";
        string manufacture="";
        string drawingNumber="";
        string makerPN="";        
        String m_strPath; //그림 전체 경로
        String seller_add;
        String seller_name;
        String seller_tel;
        String seller_fax;


        public POAdd()
        {
        }

        public POAdd(SqlConnection sql)
        {
            InitializeComponent();
            conn = sql;
            CreateTable();           
        }

        private SqlConnection conn;
        public int PartID;
        

        private void btnSelectVendor_Click(object sender, EventArgs e)
        {
            if (txtBoxVendor.Text != "")
            {
                PartID = 0;

                SelectItem selectItem = new SelectItem();

                string query = "SELECT " +
                    "[PartID] " +
                    ",[PartNumber] [자재 NO.]" +
                    ",[PartName] [자재명] " +                   
                    ",[PartManufacture] [제조업체] " +
                    ",[PartDrawingNumber] [도면번호] " +
                    ",[PartMakerPN] [Maker P/N] " +
                    ",[PartUnit] [단위] " +
                    ",convert(VARCHAR, convert(MONEY,PartUnitPrice),1) [단가] " +                  
                    ",CASE [PartUnitPriceType] " +
                                "WHEN 0 THEN '원' " +
                                "WHEN 1 THEN '달러' " +
                                "END [화폐단위] " +
                "FROM [Parts] LEFT JOIN [Vendors] ON [PartVendorID] = [VendorID] " +
                "WHERE [PartIsUse] = 1 AND [PartVendorID] = " + VendorID + " " +
                "ORDER BY [PartID] ";

                selectItem.LoadSelectItem(query, conn);

                if (selectItem.ShowDialog() == DialogResult.OK)
                {
                    int selectRow = selectItem.dataGridSelect.CurrentRow.Index;
                    PartID = Convert.ToInt16(selectItem.dataGridSelect[0, selectRow].Value);
                    textBox_PartNO.Text = selectItem.dataGridSelect["자재 NO.", selectRow].Value.ToString();
                    txtBox_PartName.Text = selectItem.dataGridSelect["자재명", selectRow].Value.ToString();
                    txtBox_Quantity.Text = "0";
                    manufacture = selectItem.dataGridSelect["제조업체", selectRow].Value.ToString();
                    drawingNumber = selectItem.dataGridSelect["도면번호", selectRow].Value.ToString();
                    makerPN = selectItem.dataGridSelect["Maker P/N", selectRow].Value.ToString();
                    txtBox_Unit.Text = selectItem.dataGridSelect["단위", selectRow].Value.ToString();
                    if (selectItem.dataGridSelect[8, selectRow].Value.ToString() == "원")
                    {
                        comboBox_moneyTypeEX.SelectedIndex = 0;
                        comboBox_moneyTypeTotal.SelectedIndex = 0;
                        string[] split = null;
                        String partsPrice = selectItem.dataGridSelect["단가", selectRow].Value.ToString();
                        split = partsPrice.Split('.');
                        txtBox_UnitPrice.Text = split[0];
                    }
                    else
                    {
                        comboBox_moneyTypeEX.SelectedIndex = 1;
                        comboBox_moneyTypeTotal.SelectedIndex = 1;
                        txtBox_UnitPrice.Text = selectItem.dataGridSelect["단가", selectRow].Value.ToString();
                    }


                }
            }
            else
            {
                MessageBox.Show("공급업체를 선택해주세요!!");
            }
        }

        private void POAdd_Load(object sender, EventArgs e)
        {
            la_value.Text = total.ToString();
            if (comboBox_moneyTypeTotal.SelectedIndex == 0)
            {
                la_value.Text = MoneyString(total.ToString()) + " 원";
            }
            else
            {
                la_value.Text = total.ToString() + " 달러";
            }
            comboBox_country.Enabled = false;
        }      

        private void CreateTable()
        {
            //ID
            column = new DataColumn();
            column.DataType = Type.GetType(("System.Int32"));
            column.ColumnName = "PartID";  //0           
            table.Columns.Add(column);

            //자재NO
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "자재NO.";   //1
            table.Columns.Add(column);

            //자재컬럼
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "자재명";   //1
            table.Columns.Add(column);

            //제조업체
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "제조업체";  //2
            table.Columns.Add(column);

            //도면번호
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "도면번호";  //3
            table.Columns.Add(column);

            //Maker P/N
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "Maker P/N";  //4
            table.Columns.Add(column);

            //단위
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "단위";   //5
            table.Columns.Add(column);

            //단가
            /*
            column = new DataColumn();
            column.DataType = Type.GetType(("System.Double"));
            column.ColumnName = "단가";  //6
            table.Columns.Add(column);*/
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "단가";  //6
            table.Columns.Add(column);

            //수량
            column = new DataColumn();
            column.DataType = Type.GetType(("System.Int32"));
            column.ColumnName = "수량";  //7
            table.Columns.Add(column);

            //금액
            /*
            column = new DataColumn();
            column.DataType = Type.GetType(("System.Double"));
            column.ColumnName = "금액";  //8
            table.Columns.Add(column);*/
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "금액";  //8
            table.Columns.Add(column);

            //화폐단위
            column = new DataColumn();
            column.DataType = Type.GetType(("System.String"));
            column.ColumnName = "화폐단위";  //9
            table.Columns.Add(column);  

            dataGridPOParts.DataSource = table;
            dataGridPOParts.ReadOnly = true;
            dataGridPOParts.Columns[0].Visible = false;           
                        
        }

        private void btn_partAdd_Click(object sender, EventArgs e)
        {
            if (txtBox_Quantity.Text == "0")
            {
                MessageBox.Show("수량을 입력하세요");
            }
            else
            {
                if (txtBox_PartName.Text != "")
                {
                    AddParts();
                    total += Convert.ToDouble(txtBox_TotalAmount.Text);
                    if (comboBox_moneyTypeTotal.SelectedIndex == 0)
                    {
                        la_value.Text = MoneyString(total.ToString()) + " 원";
                    }
                    else
                    {
                        la_value.Text = total.ToString() + " 달러";
                    }

                    TextClear();

                }
                else
                {
                    MessageBox.Show("Parts 선택을 해주세요!! ");
                }
            }
        }

        private void AddParts()
        {
            DataRow addRow;
            addRow = table.NewRow();

            addRow["PartID"] = PartID;
            //addRow["공급업체"] = vendor;
            addRow["자재NO."] = textBox_PartNO.Text;
            addRow["자재명"] = txtBox_PartName.Text;
            addRow["제조업체"] = manufacture;
            if (drawingNumber == "")
            {
                drawingNumber = "0";
            }
            addRow["도면번호"] = drawingNumber;
            addRow["Maker P/N"] = makerPN;
            addRow["단위"] = txtBox_Unit.Text;       
            //addRow["단가"] = Convert.ToDouble(txtBox_UnitPrice.Text);
            addRow["단가"] = txtBox_UnitPrice.Text; 
            addRow["수량"] = Convert.ToInt32(txtBox_Quantity.Text);        
            //addRow["금액"] = Convert.ToDouble(txtBox_TotalAmount.Text);
            addRow["금액"] = txtBox_TotalAmount.Text;
            if (comboBox_moneyTypeEX.SelectedIndex == 0)
            {
                addRow["화폐단위"] = "원";
            }
            else
            {
                addRow["화폐단위"] = "달러";
            }
            
            table.Rows.Add(addRow);            
            this.dataGridPOParts.DataSource = table;          

        }

        private void TextClear()
        {
            txtBox_PartName.Text = "";           
            txtBox_Unit.Text = "";
            txtBox_UnitPrice.Text = "0";
            txtBox_Quantity.Text= "0";
            txtBox_TotalAmount.Text= "0";
            textBox_PartNO.Text = "";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int curRow = dataGridPOParts.CurrentRow.Index;
                string popartsid = dataGridPOParts[0, curRow].Value.ToString();
                total -= Convert.ToDouble(dataGridPOParts["금액", curRow].Value);
                la_value.Text = MoneyString(total.ToString()) + comboBox_moneyTypeTotal.Text; 
            
                dataGridPOParts.Rows.RemoveAt(curRow);

            }catch(Exception exc)
            {
                 MessageBox.Show("삭제할 데이터가 없습니다.");
            }  
        }

        public void UpdateAddParts(int partID, string partNo, string partName, string vendorName, 
                                   string partManufacture, string partDrawingNumber,
                                   string partMakerPN, string partUnit, double partUnitPrice,
                                   int pOPartQuantity, double pOPartTotalAmount, string priceType)
        {
            DataRow addRow;
            addRow = table.NewRow();

            addRow["PartID"] = partID;
            //addRow["공급업체"] = vendorName;
            addRow["자재NO."] = partNo;
            addRow["자재명"] = partName;
            addRow["제조업체"] = partManufacture;            
            addRow["도면번호"] = partDrawingNumber;
            addRow["Maker P/N"] = partMakerPN;
            addRow["단위"] = partUnit;            
           //addRow["단가"] = Convert.ToDouble(MoneyString(partUnitPrice.ToString()));
            addRow["단가"] = MoneyString(partUnitPrice.ToString());
            addRow["수량"] = pOPartQuantity;
            addRow["금액"] = MoneyString(pOPartTotalAmount.ToString());
           //addRow["금액"] = Convert.ToDouble(MoneyString(pOPartTotalAmount.ToString()));
            addRow["화폐단위"] = priceType;

            table.Rows.Add(addRow);
            this.dataGridPOParts.DataSource = table;
        }

        private void btnSelectVendor_Click_1(object sender, EventArgs e)
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
                   ",[ContactName] [담당자이름] " +
                   ",[ContactTel] [담당자Tel] " +
                   ",[ContactMail] [담당자Mail] " +
                   ",[ContactFax] [담당자Fax] " +
               "FROM [Vendors] LEFT JOIN [Contacts] ON [ContactVendorID] = [VendorID]" +
               "WHERE [VendorIsUse] = 1 " +
               "ORDER BY [VendorID] ";

            selectItem.LoadSelectItem(query, conn);
         

            if (selectItem.ShowDialog() == DialogResult.OK)
            {
                int selectRow = selectItem.dataGridSelect.CurrentRow.Index;
                VendorID = Convert.ToInt16(selectItem.dataGridSelect[0, selectRow].Value);
                txtBoxVendor.Text = selectItem.dataGridSelect["업체명", selectRow].Value.ToString();
                seller_add = selectItem.dataGridSelect["본사 주소", selectRow].Value.ToString();
                seller_name = selectItem.dataGridSelect["담당자이름", selectRow].Value.ToString();
                seller_tel = selectItem.dataGridSelect["담당자Tel", selectRow].Value.ToString();
                seller_fax = selectItem.dataGridSelect["담당자Fax", selectRow].Value.ToString();
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

        private void POView_Click(object sender, EventArgs e)
        {
            
            String country ="";
            DateTime today = DateTime.Today;
            String acceptNum = txtBox_ExpenseNum.Text;//승인번호
            String date = today.ToString().Substring(0,10);//발주날짜
            String poNum = this.txtBox_PoNum.Text;//PONUMBER
            String seller = this.txtBoxVendor.Text;//판매처
            String sellerAdd = seller_add;// 판매처주소
            String deliveryCondition = this.cbBox_DeliveryCondition.Text;//납품조건
            String paymentCondition = this.cbBox_PaymentCondition.Text;//지불조건
            String expactdateRequest = this.dateTimeEstimate.Text;//납기
            String dateRequest = this.dateTimeRequest.Text;//납기 요청일
            String penalty = this.textBox_penalty.Text;//페널티
            String bigo = this.textBox_bigo.Text;//비고      
            String type;
            if (comboBox_country.Enabled == true && comboBox_country.Text == "국가선택")
            {
                MessageBox.Show("국가를 선택해 주세요~!!");
            }
            else
            {
                if (comboBox_moneyTypeTotal.SelectedIndex == 0)
                {
                    type = " 원";
                }
                else
                {
                    type = " 달러";
                }
                String totalAumount = this.la_value.Text;


                int rowCnt = dataGridPOParts.RowCount;
                ArrayList partDategrid = new ArrayList();

                for (int i = 0; i < rowCnt; i++)
                {

                    partDategrid.Add(dataGridPOParts["자재NO.", i].Value.ToString() + "+"//자제 NO
                                    + dataGridPOParts["제조업체", i].Value.ToString() + "+"//maker 
                                    + dataGridPOParts["Maker P/N", i].Value.ToString() + "+"//maker 규격
                                    + dataGridPOParts["수량", i].Value.ToString() + "+"//수량
                                    + dataGridPOParts["단가", i].Value.ToString() + "+"//단가
                                    + dataGridPOParts["금액", i].Value.ToString() + type //금액                    
                                    );
                }

                if (comboBox_POSelect.Text.Equals("AiMS발주서(한글)"))
                {
                    int gubun = 1;
                    m_strPath = "C:\\OP_Form\\AiMS_PO.png";
                    PO_Viewer poviewer = new PO_Viewer(acceptNum, country, gubun, date, poNum, seller,
                                                       sellerAdd, deliveryCondition, paymentCondition,
                                                       expactdateRequest, dateRequest, penalty, bigo, m_strPath,
                                                       partDategrid, totalAumount,
                                                       seller_name, seller_tel, seller_fax);
                    poviewer.picSelect.Image = new Bitmap("C:\\OP_Form\\save\\" + poNum + ".png");

                    if (poviewer.ShowDialog() == DialogResult.OK)
                    {
                        poviewer.Dispose();
                        poviewer.picSelect.Image.Dispose();
                    }

                }
                else if (comboBox_POSelect.Text.Equals("AiMS발주서(영어)"))
                {
                    int gubun = 2;
                    m_strPath = "C:\\OP_Form\\AiMS_PO_ENG.png";
                    country = this.comboBox_country.Text;
                    PO_Viewer poviewer = new PO_Viewer(acceptNum, country, gubun, date, poNum, seller,
                                                       sellerAdd, deliveryCondition, paymentCondition,
                                                       expactdateRequest, dateRequest, penalty, bigo, m_strPath,
                                                       partDategrid, totalAumount,
                                                       seller_name, seller_tel, seller_fax);
                    poviewer.picSelect.Image = new Bitmap("C:\\OP_Form\\save\\" + poNum + ".png");
                    poviewer.ShowDialog();
                }
                else if (comboBox_POSelect.Text.Equals("AsTEK발주서(한글)"))
                {
                    int gubun = 3;
                    m_strPath = "C:\\OP_Form\\AsTEK_PO.png";
                    PO_Viewer poviewer = new PO_Viewer(acceptNum, country, gubun, date, poNum, seller,
                                                       sellerAdd, deliveryCondition, paymentCondition,
                                                       expactdateRequest, dateRequest, penalty, bigo, m_strPath,
                                                       partDategrid, totalAumount,
                                                       seller_name, seller_tel, seller_fax);
                    poviewer.picSelect.Image = new Bitmap("C:\\OP_Form\\save\\" + poNum + ".png");
                    poviewer.ShowDialog();
                }
                else if (comboBox_POSelect.Text.Equals("AsTEK발주서(영어)"))
                {
                    int gubun = 4;
                    m_strPath = "C:\\OP_Form\\AsTEK_PO_ENG.png";
                    country = this.comboBox_country.Text;
                    PO_Viewer poviewer = new PO_Viewer(acceptNum, country, gubun, date, poNum, seller,
                                                       sellerAdd, deliveryCondition, paymentCondition,
                                                       expactdateRequest, dateRequest, penalty, bigo, m_strPath,
                                                       partDategrid, totalAumount,
                                                       seller_name, seller_tel, seller_fax);
                    poviewer.picSelect.Image = new Bitmap("C:\\OP_Form\\save\\" + poNum + ".png");
                    poviewer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("발주서 양식을 선택해 주세요");
                }
            }
        }

        private void comboBox_POSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            String date = today.ToString().Substring(0, 10);//발주날짜         
            string poIdMaxQuery = "select max(POID) from POs";
            int rePOID;

            String maxOpId = GetMaxPOid(poIdMaxQuery);
            if (maxOpId == "")
            {
                 rePOID = 1;
            }
            else
            {
                 rePOID = Convert.ToInt32(maxOpId) + 1;
            }
            String selectForm;
            if (comboBox_POSelect.SelectedIndex == 0)
            {
                 selectForm = "AiMS(KOR)";
            }
            else if (comboBox_POSelect.SelectedIndex == 1)
            {
                selectForm = "AiMS(ENG)";
                comboBox_country.Enabled = true;              
            }
            else if (comboBox_POSelect.SelectedIndex == 2)
            {
                selectForm = "AsTEK(KOR)";
            }
            else
            {
                selectForm = "AsTEK(ENG)";
                comboBox_country.Enabled = true;      
            }
            if (btn_Save.Text == "수 정")
            {
                this.txtBox_PoNum.Text = date.Substring(2, 8) + "-" + selectForm + "-" + poid + "-" + "RV." + PORevision.Value.ToString();
            }
            else
            {
                this.txtBox_PoNum.Text = date.Substring(2, 8) + "-" + selectForm + "-" + rePOID + "-" + "RV." + PORevision.Value.ToString();
            }
        }
        public String GetMaxPOid(string query)
        {
            String max = "1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                max = (read[0]).ToString();
            }
            read.Close();
            return max;
        }

        private void txtBox_Quantity_MouseLeave(object sender, EventArgs e)
        {
            double quantity = Convert.ToDouble(txtBox_Quantity.Text);
            double unitPrice = 0;
            if (txtBox_UnitPrice.Text == "")
            {
                MessageBox.Show("단가는 '0' 이 될수 없습니다.");
            }
            else
            {              
                unitPrice = Convert.ToDouble(txtBox_UnitPrice.Text);                
            }
            if (comboBox_moneyTypeTotal.SelectedIndex == 0)
            {
                txtBox_TotalAmount.Text = MoneyString((quantity * unitPrice).ToString());
            }
            else
            {
                txtBox_TotalAmount.Text = (quantity * unitPrice).ToString();
            }           
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txtBox_PoNum.Text == "")
            {
                MessageBox.Show("발주서 양식을 선택해 주세요");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }     
    }
}