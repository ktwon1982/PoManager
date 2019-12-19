namespace POManager
{
    partial class POAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimeEstimate = new System.Windows.Forms.DateTimePicker();
            this.cbBox_DeliveryCondition = new System.Windows.Forms.ComboBox();
            this.cbBox_PaymentCondition = new System.Windows.Forms.ComboBox();
            this.la_PaymentCondition = new System.Windows.Forms.Label();
            this.la_RequestDay = new System.Windows.Forms.Label();
            this.la_ExpectDay = new System.Windows.Forms.Label();
            this.PORevision = new System.Windows.Forms.NumericUpDown();
            this.txtBox_ExpenseNum = new System.Windows.Forms.TextBox();
            this.la_DeliveryCondition = new System.Windows.Forms.Label();
            this.cbBox_PoGubun = new System.Windows.Forms.ComboBox();
            this.txtBox_PoNum = new System.Windows.Forms.TextBox();
            this.la_AcceptNum = new System.Windows.Forms.Label();
            this.la_PoGubun = new System.Windows.Forms.Label();
            this.la_Rev = new System.Windows.Forms.Label();
            this.la_PoNum = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txtBox_TotalAmount = new System.Windows.Forms.TextBox();
            this.lab_TotalAmount = new System.Windows.Forms.Label();
            this.txtBox_Quantity = new System.Windows.Forms.TextBox();
            this.la_Quantity = new System.Windows.Forms.Label();
            this.txtBox_Unit = new System.Windows.Forms.TextBox();
            this.la_Unit = new System.Windows.Forms.Label();
            this.btnSelectPart = new System.Windows.Forms.Button();
            this.txtBox_UnitPrice = new System.Windows.Forms.TextBox();
            this.la_UnitPrice = new System.Windows.Forms.Label();
            this.la_PartName = new System.Windows.Forms.Label();
            this.txtBox_PartName = new System.Windows.Forms.TextBox();
            this.dataGridPOParts = new System.Windows.Forms.DataGridView();
            this.gb_parts = new System.Windows.Forms.GroupBox();
            this.comboBox_moneyTypeTotal = new System.Windows.Forms.ComboBox();
            this.comboBox_moneyTypeEX = new System.Windows.Forms.ComboBox();
            this.textBox_PartNO = new System.Windows.Forms.TextBox();
            this.la_PartsNO = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_PartAdd = new System.Windows.Forms.Button();
            this.gb_po = new System.Windows.Forms.GroupBox();
            this.dateTimeRequest = new System.Windows.Forms.TextBox();
            this.btnSelectVendor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxVendor = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.la_total = new System.Windows.Forms.Label();
            this.la_value = new System.Windows.Forms.Label();
            this.comboBox_POSelect = new System.Windows.Forms.ComboBox();
            this.POView = new System.Windows.Forms.Button();
            this.textBox_penalty = new System.Windows.Forms.TextBox();
            this.la_bigo = new System.Windows.Forms.Label();
            this.textBox_bigo = new System.Windows.Forms.TextBox();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.la_penalty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PORevision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOParts)).BeginInit();
            this.gb_parts.SuspendLayout();
            this.gb_po.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeEstimate
            // 
            this.dateTimeEstimate.Location = new System.Drawing.Point(128, 95);
            this.dateTimeEstimate.Name = "dateTimeEstimate";
            this.dateTimeEstimate.Size = new System.Drawing.Size(169, 21);
            this.dateTimeEstimate.TabIndex = 6;
            // 
            // cbBox_DeliveryCondition
            // 
            this.cbBox_DeliveryCondition.FormattingEnabled = true;
            this.cbBox_DeliveryCondition.Items.AddRange(new object[] {
            "공장 인도"});
            this.cbBox_DeliveryCondition.Location = new System.Drawing.Point(421, 125);
            this.cbBox_DeliveryCondition.Name = "cbBox_DeliveryCondition";
            this.cbBox_DeliveryCondition.Size = new System.Drawing.Size(169, 20);
            this.cbBox_DeliveryCondition.TabIndex = 9;
            // 
            // cbBox_PaymentCondition
            // 
            this.cbBox_PaymentCondition.FormattingEnabled = true;
            this.cbBox_PaymentCondition.Items.AddRange(new object[] {
            "세금계산서 발행 후 30일",
            "세금계산서 발행 후 45일",
            "세금계산서 발행 후 60일",
            "30%/70% 45일",
            "30%/70% 현금",
            "30%/70% 선결재",
            "현금결재",
            "익월말 결재",
            "선결재",
            "해외송금"});
            this.cbBox_PaymentCondition.Location = new System.Drawing.Point(128, 122);
            this.cbBox_PaymentCondition.Name = "cbBox_PaymentCondition";
            this.cbBox_PaymentCondition.Size = new System.Drawing.Size(169, 20);
            this.cbBox_PaymentCondition.TabIndex = 8;
            // 
            // la_PaymentCondition
            // 
            this.la_PaymentCondition.AutoSize = true;
            this.la_PaymentCondition.Location = new System.Drawing.Point(14, 125);
            this.la_PaymentCondition.Name = "la_PaymentCondition";
            this.la_PaymentCondition.Size = new System.Drawing.Size(65, 12);
            this.la_PaymentCondition.TabIndex = 133;
            this.la_PaymentCondition.Text = "결제 조건 :";
            // 
            // la_RequestDay
            // 
            this.la_RequestDay.AutoSize = true;
            this.la_RequestDay.Location = new System.Drawing.Point(337, 98);
            this.la_RequestDay.Name = "la_RequestDay";
            this.la_RequestDay.Size = new System.Drawing.Size(65, 12);
            this.la_RequestDay.TabIndex = 132;
            this.la_RequestDay.Text = "요청 납기 :";
            // 
            // la_ExpectDay
            // 
            this.la_ExpectDay.AutoSize = true;
            this.la_ExpectDay.Location = new System.Drawing.Point(14, 98);
            this.la_ExpectDay.Name = "la_ExpectDay";
            this.la_ExpectDay.Size = new System.Drawing.Size(65, 12);
            this.la_ExpectDay.TabIndex = 131;
            this.la_ExpectDay.Text = "예상 납기 :";
            // 
            // PORevision
            // 
            this.PORevision.Location = new System.Drawing.Point(507, 68);
            this.PORevision.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.PORevision.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PORevision.Name = "PORevision";
            this.PORevision.Size = new System.Drawing.Size(83, 21);
            this.PORevision.TabIndex = 5;
            this.PORevision.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBox_ExpenseNum
            // 
            this.txtBox_ExpenseNum.Location = new System.Drawing.Point(439, 15);
            this.txtBox_ExpenseNum.Name = "txtBox_ExpenseNum";
            this.txtBox_ExpenseNum.Size = new System.Drawing.Size(150, 21);
            this.txtBox_ExpenseNum.TabIndex = 1;
            // 
            // la_DeliveryCondition
            // 
            this.la_DeliveryCondition.AutoSize = true;
            this.la_DeliveryCondition.Location = new System.Drawing.Point(337, 128);
            this.la_DeliveryCondition.Name = "la_DeliveryCondition";
            this.la_DeliveryCondition.Size = new System.Drawing.Size(65, 12);
            this.la_DeliveryCondition.TabIndex = 124;
            this.la_DeliveryCondition.Text = "납품 조건 :";
            // 
            // cbBox_PoGubun
            // 
            this.cbBox_PoGubun.FormattingEnabled = true;
            this.cbBox_PoGubun.Items.AddRange(new object[] {
            "구매부서 발주품",
            "구매요청 발주품"});
            this.cbBox_PoGubun.Location = new System.Drawing.Point(128, 15);
            this.cbBox_PoGubun.Name = "cbBox_PoGubun";
            this.cbBox_PoGubun.Size = new System.Drawing.Size(169, 20);
            this.cbBox_PoGubun.TabIndex = 0;
            // 
            // txtBox_PoNum
            // 
            this.txtBox_PoNum.Location = new System.Drawing.Point(128, 68);
            this.txtBox_PoNum.Name = "txtBox_PoNum";
            this.txtBox_PoNum.Size = new System.Drawing.Size(304, 21);
            this.txtBox_PoNum.TabIndex = 4;
            // 
            // la_AcceptNum
            // 
            this.la_AcceptNum.AutoSize = true;
            this.la_AcceptNum.Location = new System.Drawing.Point(360, 18);
            this.la_AcceptNum.Name = "la_AcceptNum";
            this.la_AcceptNum.Size = new System.Drawing.Size(61, 12);
            this.la_AcceptNum.TabIndex = 1;
            this.la_AcceptNum.Text = "승인번호 :";
            // 
            // la_PoGubun
            // 
            this.la_PoGubun.AutoSize = true;
            this.la_PoGubun.Location = new System.Drawing.Point(14, 18);
            this.la_PoGubun.Name = "la_PoGubun";
            this.la_PoGubun.Size = new System.Drawing.Size(58, 12);
            this.la_PoGubun.TabIndex = 112;
            this.la_PoGubun.Text = "PO 구분 :";
            // 
            // la_Rev
            // 
            this.la_Rev.AutoSize = true;
            this.la_Rev.Location = new System.Drawing.Point(467, 71);
            this.la_Rev.Name = "la_Rev";
            this.la_Rev.Size = new System.Drawing.Size(30, 12);
            this.la_Rev.TabIndex = 111;
            this.la_Rev.Text = "Rev.";
            // 
            // la_PoNum
            // 
            this.la_PoNum.AutoSize = true;
            this.la_PoNum.Location = new System.Drawing.Point(14, 71);
            this.la_PoNum.Name = "la_PoNum";
            this.la_PoNum.Size = new System.Drawing.Size(77, 12);
            this.la_PoNum.TabIndex = 110;
            this.la_PoNum.Text = "PO number :";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(515, 625);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "취 소";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txtBox_TotalAmount
            // 
            this.txtBox_TotalAmount.Location = new System.Drawing.Point(128, 128);
            this.txtBox_TotalAmount.Name = "txtBox_TotalAmount";
            this.txtBox_TotalAmount.Size = new System.Drawing.Size(169, 21);
            this.txtBox_TotalAmount.TabIndex = 7;
            this.txtBox_TotalAmount.Text = "0";
            this.txtBox_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lab_TotalAmount
            // 
            this.lab_TotalAmount.AutoSize = true;
            this.lab_TotalAmount.Location = new System.Drawing.Point(19, 131);
            this.lab_TotalAmount.Name = "lab_TotalAmount";
            this.lab_TotalAmount.Size = new System.Drawing.Size(53, 12);
            this.lab_TotalAmount.TabIndex = 162;
            this.lab_TotalAmount.Text = "총 금액 :";
            // 
            // txtBox_Quantity
            // 
            this.txtBox_Quantity.Location = new System.Drawing.Point(128, 101);
            this.txtBox_Quantity.Name = "txtBox_Quantity";
            this.txtBox_Quantity.Size = new System.Drawing.Size(169, 21);
            this.txtBox_Quantity.TabIndex = 6;
            this.txtBox_Quantity.Text = "0";
            this.txtBox_Quantity.MouseLeave += new System.EventHandler(this.txtBox_Quantity_MouseLeave);
            // 
            // la_Quantity
            // 
            this.la_Quantity.AutoSize = true;
            this.la_Quantity.Location = new System.Drawing.Point(19, 104);
            this.la_Quantity.Name = "la_Quantity";
            this.la_Quantity.Size = new System.Drawing.Size(41, 12);
            this.la_Quantity.TabIndex = 161;
            this.la_Quantity.Text = "수 량 :";
            // 
            // txtBox_Unit
            // 
            this.txtBox_Unit.Location = new System.Drawing.Point(128, 47);
            this.txtBox_Unit.Name = "txtBox_Unit";
            this.txtBox_Unit.ReadOnly = true;
            this.txtBox_Unit.Size = new System.Drawing.Size(169, 21);
            this.txtBox_Unit.TabIndex = 3;
            // 
            // la_Unit
            // 
            this.la_Unit.AutoSize = true;
            this.la_Unit.Location = new System.Drawing.Point(19, 50);
            this.la_Unit.Name = "la_Unit";
            this.la_Unit.Size = new System.Drawing.Size(41, 12);
            this.la_Unit.TabIndex = 159;
            this.la_Unit.Text = "단 위 :";
            // 
            // btnSelectPart
            // 
            this.btnSelectPart.Location = new System.Drawing.Point(316, 19);
            this.btnSelectPart.Name = "btnSelectPart";
            this.btnSelectPart.Size = new System.Drawing.Size(34, 23);
            this.btnSelectPart.TabIndex = 1;
            this.btnSelectPart.Text = "...";
            this.btnSelectPart.UseVisualStyleBackColor = true;
            this.btnSelectPart.Click += new System.EventHandler(this.btnSelectVendor_Click);
            // 
            // txtBox_UnitPrice
            // 
            this.txtBox_UnitPrice.Location = new System.Drawing.Point(128, 74);
            this.txtBox_UnitPrice.Name = "txtBox_UnitPrice";
            this.txtBox_UnitPrice.ReadOnly = true;
            this.txtBox_UnitPrice.Size = new System.Drawing.Size(169, 21);
            this.txtBox_UnitPrice.TabIndex = 4;
            this.txtBox_UnitPrice.Text = "0";
            this.txtBox_UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // la_UnitPrice
            // 
            this.la_UnitPrice.AutoSize = true;
            this.la_UnitPrice.Location = new System.Drawing.Point(19, 77);
            this.la_UnitPrice.Name = "la_UnitPrice";
            this.la_UnitPrice.Size = new System.Drawing.Size(41, 12);
            this.la_UnitPrice.TabIndex = 156;
            this.la_UnitPrice.Text = "단 가 :";
            // 
            // la_PartName
            // 
            this.la_PartName.AutoSize = true;
            this.la_PartName.Location = new System.Drawing.Point(14, 23);
            this.la_PartName.Name = "la_PartName";
            this.la_PartName.Size = new System.Drawing.Size(51, 12);
            this.la_PartName.TabIndex = 153;
            this.la_PartName.Text = "Part 명 :";
            // 
            // txtBox_PartName
            // 
            this.txtBox_PartName.Location = new System.Drawing.Point(128, 20);
            this.txtBox_PartName.Name = "txtBox_PartName";
            this.txtBox_PartName.ReadOnly = true;
            this.txtBox_PartName.Size = new System.Drawing.Size(180, 21);
            this.txtBox_PartName.TabIndex = 0;
            // 
            // dataGridPOParts
            // 
            this.dataGridPOParts.AllowUserToAddRows = false;
            this.dataGridPOParts.AllowUserToDeleteRows = false;
            this.dataGridPOParts.AllowUserToResizeColumns = false;
            this.dataGridPOParts.AllowUserToResizeRows = false;
            this.dataGridPOParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPOParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPOParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPOParts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPOParts.Location = new System.Drawing.Point(12, 344);
            this.dataGridPOParts.Name = "dataGridPOParts";
            this.dataGridPOParts.ReadOnly = true;
            this.dataGridPOParts.RowHeadersVisible = false;
            this.dataGridPOParts.RowTemplate.Height = 23;
            this.dataGridPOParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPOParts.Size = new System.Drawing.Size(606, 176);
            this.dataGridPOParts.TabIndex = 165;
            // 
            // gb_parts
            // 
            this.gb_parts.Controls.Add(this.comboBox_moneyTypeTotal);
            this.gb_parts.Controls.Add(this.comboBox_moneyTypeEX);
            this.gb_parts.Controls.Add(this.textBox_PartNO);
            this.gb_parts.Controls.Add(this.la_PartsNO);
            this.gb_parts.Controls.Add(this.btn_Delete);
            this.gb_parts.Controls.Add(this.btn_PartAdd);
            this.gb_parts.Controls.Add(this.txtBox_PartName);
            this.gb_parts.Controls.Add(this.txtBox_TotalAmount);
            this.gb_parts.Controls.Add(this.lab_TotalAmount);
            this.gb_parts.Controls.Add(this.la_PartName);
            this.gb_parts.Controls.Add(this.txtBox_Quantity);
            this.gb_parts.Controls.Add(this.la_Quantity);
            this.gb_parts.Controls.Add(this.btnSelectPart);
            this.gb_parts.Controls.Add(this.txtBox_Unit);
            this.gb_parts.Controls.Add(this.la_Unit);
            this.gb_parts.Controls.Add(this.txtBox_UnitPrice);
            this.gb_parts.Controls.Add(this.la_UnitPrice);
            this.gb_parts.Location = new System.Drawing.Point(12, 175);
            this.gb_parts.Name = "gb_parts";
            this.gb_parts.Size = new System.Drawing.Size(606, 162);
            this.gb_parts.TabIndex = 1;
            this.gb_parts.TabStop = false;
            this.gb_parts.Text = "Part 추가";
            // 
            // comboBox_moneyTypeTotal
            // 
            this.comboBox_moneyTypeTotal.FormattingEnabled = true;
            this.comboBox_moneyTypeTotal.Items.AddRange(new object[] {
            "원",
            "달러"});
            this.comboBox_moneyTypeTotal.Location = new System.Drawing.Point(303, 127);
            this.comboBox_moneyTypeTotal.Name = "comboBox_moneyTypeTotal";
            this.comboBox_moneyTypeTotal.Size = new System.Drawing.Size(72, 20);
            this.comboBox_moneyTypeTotal.TabIndex = 8;
            this.comboBox_moneyTypeTotal.Text = "화폐단위";
            // 
            // comboBox_moneyTypeEX
            // 
            this.comboBox_moneyTypeEX.FormattingEnabled = true;
            this.comboBox_moneyTypeEX.Items.AddRange(new object[] {
            "원",
            "달러"});
            this.comboBox_moneyTypeEX.Location = new System.Drawing.Point(303, 74);
            this.comboBox_moneyTypeEX.Name = "comboBox_moneyTypeEX";
            this.comboBox_moneyTypeEX.Size = new System.Drawing.Size(72, 20);
            this.comboBox_moneyTypeEX.TabIndex = 5;
            this.comboBox_moneyTypeEX.Text = "화폐단위";
            // 
            // textBox_PartNO
            // 
            this.textBox_PartNO.Location = new System.Drawing.Point(431, 21);
            this.textBox_PartNO.Name = "textBox_PartNO";
            this.textBox_PartNO.ReadOnly = true;
            this.textBox_PartNO.Size = new System.Drawing.Size(169, 21);
            this.textBox_PartNO.TabIndex = 2;
            // 
            // la_PartsNO
            // 
            this.la_PartsNO.AutoSize = true;
            this.la_PartsNO.Location = new System.Drawing.Point(366, 24);
            this.la_PartsNO.Name = "la_PartsNO";
            this.la_PartsNO.Size = new System.Drawing.Size(57, 12);
            this.la_PartsNO.TabIndex = 170;
            this.la_PartsNO.Text = "Part NO :";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(505, 121);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(90, 30);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Parts 삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_PartAdd
            // 
            this.btn_PartAdd.Location = new System.Drawing.Point(409, 121);
            this.btn_PartAdd.Name = "btn_PartAdd";
            this.btn_PartAdd.Size = new System.Drawing.Size(90, 30);
            this.btn_PartAdd.TabIndex = 9;
            this.btn_PartAdd.Text = "Parts 추가";
            this.btn_PartAdd.UseVisualStyleBackColor = true;
            this.btn_PartAdd.Click += new System.EventHandler(this.btn_partAdd_Click);
            // 
            // gb_po
            // 
            this.gb_po.Controls.Add(this.dateTimeRequest);
            this.gb_po.Controls.Add(this.btnSelectVendor);
            this.gb_po.Controls.Add(this.label8);
            this.gb_po.Controls.Add(this.txtBoxVendor);
            this.gb_po.Controls.Add(this.txtBox_ExpenseNum);
            this.gb_po.Controls.Add(this.la_PoNum);
            this.gb_po.Controls.Add(this.la_Rev);
            this.gb_po.Controls.Add(this.la_PoGubun);
            this.gb_po.Controls.Add(this.la_AcceptNum);
            this.gb_po.Controls.Add(this.txtBox_PoNum);
            this.gb_po.Controls.Add(this.dateTimeEstimate);
            this.gb_po.Controls.Add(this.cbBox_PoGubun);
            this.gb_po.Controls.Add(this.cbBox_DeliveryCondition);
            this.gb_po.Controls.Add(this.PORevision);
            this.gb_po.Controls.Add(this.cbBox_PaymentCondition);
            this.gb_po.Controls.Add(this.la_RequestDay);
            this.gb_po.Controls.Add(this.la_PaymentCondition);
            this.gb_po.Controls.Add(this.la_DeliveryCondition);
            this.gb_po.Controls.Add(this.la_ExpectDay);
            this.gb_po.Location = new System.Drawing.Point(12, 12);
            this.gb_po.Name = "gb_po";
            this.gb_po.Size = new System.Drawing.Size(606, 157);
            this.gb_po.TabIndex = 0;
            this.gb_po.TabStop = false;
            this.gb_po.Text = "발주";
            // 
            // dateTimeRequest
            // 
            this.dateTimeRequest.Location = new System.Drawing.Point(421, 95);
            this.dateTimeRequest.Name = "dateTimeRequest";
            this.dateTimeRequest.Size = new System.Drawing.Size(150, 21);
            this.dateTimeRequest.TabIndex = 168;
            // 
            // btnSelectVendor
            // 
            this.btnSelectVendor.Location = new System.Drawing.Point(338, 41);
            this.btnSelectVendor.Name = "btnSelectVendor";
            this.btnSelectVendor.Size = new System.Drawing.Size(34, 23);
            this.btnSelectVendor.TabIndex = 3;
            this.btnSelectVendor.Text = "...";
            this.btnSelectVendor.UseVisualStyleBackColor = true;
            this.btnSelectVendor.Click += new System.EventHandler(this.btnSelectVendor_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 167;
            this.label8.Text = "공급 업체 :";
            // 
            // txtBoxVendor
            // 
            this.txtBoxVendor.Location = new System.Drawing.Point(129, 41);
            this.txtBoxVendor.Name = "txtBoxVendor";
            this.txtBoxVendor.Size = new System.Drawing.Size(200, 21);
            this.txtBoxVendor.TabIndex = 2;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(409, 625);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 40);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "저장";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // la_total
            // 
            this.la_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.la_total.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_total.Location = new System.Drawing.Point(12, 539);
            this.la_total.Name = "la_total";
            this.la_total.Size = new System.Drawing.Size(77, 23);
            this.la_total.TabIndex = 168;
            this.la_total.Text = "총금액 :";
            // 
            // la_value
            // 
            this.la_value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.la_value.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.la_value.Location = new System.Drawing.Point(81, 539);
            this.la_value.Name = "la_value";
            this.la_value.Size = new System.Drawing.Size(186, 23);
            this.la_value.TabIndex = 169;
            // 
            // comboBox_POSelect
            // 
            this.comboBox_POSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "AiMS 발주서(한글)",
            "AiMS 발주서(영문)",
            "AsTEK 발주서(한글)",
            "AsTEK 발주서(영문)"});
            this.comboBox_POSelect.FormattingEnabled = true;
            this.comboBox_POSelect.Items.AddRange(new object[] {
            "AiMS발주서(한글)",
            "AiMS발주서(영어)",
            "AsTEK발주서(한글)",
            "AsTEK발주서(영어)"});
            this.comboBox_POSelect.Location = new System.Drawing.Point(306, 596);
            this.comboBox_POSelect.Name = "comboBox_POSelect";
            this.comboBox_POSelect.Size = new System.Drawing.Size(140, 20);
            this.comboBox_POSelect.TabIndex = 4;
            this.comboBox_POSelect.Text = "발주서양식선택";
            this.comboBox_POSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox_POSelect_SelectedIndexChanged);
            // 
            // POView
            // 
            this.POView.Location = new System.Drawing.Point(303, 625);
            this.POView.Name = "POView";
            this.POView.Size = new System.Drawing.Size(100, 40);
            this.POView.TabIndex = 6;
            this.POView.Text = "발주서미리보기";
            this.POView.UseVisualStyleBackColor = true;
            this.POView.Click += new System.EventHandler(this.POView_Click);
            // 
            // textBox_penalty
            // 
            this.textBox_penalty.Location = new System.Drawing.Point(366, 542);
            this.textBox_penalty.Name = "textBox_penalty";
            this.textBox_penalty.Size = new System.Drawing.Size(252, 21);
            this.textBox_penalty.TabIndex = 2;
            // 
            // la_bigo
            // 
            this.la_bigo.AutoSize = true;
            this.la_bigo.Location = new System.Drawing.Point(250, 572);
            this.la_bigo.Name = "la_bigo";
            this.la_bigo.Size = new System.Drawing.Size(37, 12);
            this.la_bigo.TabIndex = 172;
            this.la_bigo.Text = "비고 :";
            // 
            // textBox_bigo
            // 
            this.textBox_bigo.Location = new System.Drawing.Point(311, 569);
            this.textBox_bigo.Name = "textBox_bigo";
            this.textBox_bigo.Size = new System.Drawing.Size(304, 21);
            this.textBox_bigo.TabIndex = 3;
            // 
            // comboBox_country
            // 
            this.comboBox_country.AutoCompleteCustomSource.AddRange(new string[] {
            "AiMS 발주서(한글)",
            "AiMS 발주서(영문)",
            "AsTEK 발주서(한글)",
            "AsTEK 발주서(영문)"});
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Items.AddRange(new object[] {
            "America",
            "Russia",
            "China",
            "Japan",
            "United Kingdom",
            "France"});
            this.comboBox_country.Location = new System.Drawing.Point(475, 596);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(140, 20);
            this.comboBox_country.TabIndex = 5;
            this.comboBox_country.Text = "국가선택";
            // 
            // la_penalty
            // 
            this.la_penalty.AutoSize = true;
            this.la_penalty.Location = new System.Drawing.Point(250, 545);
            this.la_penalty.Name = "la_penalty";
            this.la_penalty.Size = new System.Drawing.Size(110, 12);
            this.la_penalty.TabIndex = 170;
            this.la_penalty.Text = "Penalty/Warranty :";
            // 
            // POAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 674);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.textBox_bigo);
            this.Controls.Add(this.la_bigo);
            this.Controls.Add(this.textBox_penalty);
            this.Controls.Add(this.la_penalty);
            this.Controls.Add(this.POView);
            this.Controls.Add(this.comboBox_POSelect);
            this.Controls.Add(this.la_value);
            this.Controls.Add(this.la_total);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_po);
            this.Controls.Add(this.gb_parts);
            this.Controls.Add(this.dataGridPOParts);
            this.Controls.Add(this.btn_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "POAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Add";
            this.Load += new System.EventHandler(this.POAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PORevision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOParts)).EndInit();
            this.gb_parts.ResumeLayout(false);
            this.gb_parts.PerformLayout();
            this.gb_po.ResumeLayout(false);
            this.gb_po.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dateTimeEstimate;
        public System.Windows.Forms.ComboBox cbBox_DeliveryCondition;
        public System.Windows.Forms.ComboBox cbBox_PaymentCondition;
        private System.Windows.Forms.Label la_PaymentCondition;
        private System.Windows.Forms.Label la_RequestDay;
        private System.Windows.Forms.Label la_ExpectDay;
        public System.Windows.Forms.NumericUpDown PORevision;
        public System.Windows.Forms.TextBox txtBox_ExpenseNum;
        private System.Windows.Forms.Label la_DeliveryCondition;
        public System.Windows.Forms.ComboBox cbBox_PoGubun;
        public System.Windows.Forms.TextBox txtBox_PoNum;
        private System.Windows.Forms.Label la_AcceptNum;
        private System.Windows.Forms.Label la_PoGubun;
        private System.Windows.Forms.Label la_Rev;
        private System.Windows.Forms.Label la_PoNum;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.TextBox txtBox_TotalAmount;
        private System.Windows.Forms.Label lab_TotalAmount;
        public System.Windows.Forms.TextBox txtBox_Quantity;
        private System.Windows.Forms.Label la_Quantity;
        public System.Windows.Forms.TextBox txtBox_Unit;
        private System.Windows.Forms.Label la_Unit;
        private System.Windows.Forms.Button btnSelectPart;
        public System.Windows.Forms.TextBox txtBox_UnitPrice;
        private System.Windows.Forms.Label la_UnitPrice;
        private System.Windows.Forms.Label la_PartName;
        public System.Windows.Forms.TextBox txtBox_PartName;
        private System.Windows.Forms.GroupBox gb_parts;
        private System.Windows.Forms.GroupBox gb_po;
        private System.Windows.Forms.Button btn_PartAdd;
        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.DataGridView dataGridPOParts;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btnSelectVendor;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtBoxVendor;
        private System.Windows.Forms.Label la_total;
        private System.Windows.Forms.Label la_value;
        private System.Windows.Forms.ComboBox comboBox_POSelect;
        private System.Windows.Forms.Button POView;
        public System.Windows.Forms.TextBox textBox_penalty;
        private System.Windows.Forms.Label la_bigo;
        public System.Windows.Forms.TextBox textBox_bigo;
        public System.Windows.Forms.TextBox textBox_PartNO;
        private System.Windows.Forms.Label la_PartsNO;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.Label la_penalty;
        public System.Windows.Forms.ComboBox comboBox_moneyTypeTotal;
        public System.Windows.Forms.ComboBox comboBox_moneyTypeEX;
        public System.Windows.Forms.TextBox dateTimeRequest;
    }
}