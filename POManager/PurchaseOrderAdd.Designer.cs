namespace POManager
{
    partial class PurchaseOrderAdd
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
            this.btnSelectVendor = new System.Windows.Forms.Button();
            this.txtBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBoxMakerPN = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxManufacture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxVendor = new System.Windows.Forms.TextBox();
            this.txtBoxPartName = new System.Windows.Forms.TextBox();
            this.txtBoxDrawingNumber = new System.Windows.Forms.TextBox();
            this.cbBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtBoxPONumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxConsultNumber = new System.Windows.Forms.TextBox();
            this.PORevision = new System.Windows.Forms.NumericUpDown();
            this.txtBoxUnit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbBoxPaymentCondition = new System.Windows.Forms.ComboBox();
            this.cbBoxDeliveryCondition = new System.Windows.Forms.ComboBox();
            this.dateTimeEstimate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeRequest = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PORevision)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectVendor
            // 
            this.btnSelectVendor.Location = new System.Drawing.Point(419, 106);
            this.btnSelectVendor.Name = "btnSelectVendor";
            this.btnSelectVendor.Size = new System.Drawing.Size(34, 23);
            this.btnSelectVendor.TabIndex = 4;
            this.btnSelectVendor.Text = "...";
            this.btnSelectVendor.UseVisualStyleBackColor = true;
            this.btnSelectVendor.Click += new System.EventHandler(this.btnSelectVendor_Click);
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(126, 268);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.ReadOnly = true;
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(169, 21);
            this.txtBoxUnitPrice.TabIndex = 77;
            this.txtBoxUnitPrice.Text = "0";
            this.txtBoxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxMakerPN
            // 
            this.txtBoxMakerPN.Location = new System.Drawing.Point(126, 214);
            this.txtBoxMakerPN.Name = "txtBoxMakerPN";
            this.txtBoxMakerPN.ReadOnly = true;
            this.txtBoxMakerPN.Size = new System.Drawing.Size(287, 21);
            this.txtBoxMakerPN.TabIndex = 76;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 75;
            this.label11.Text = "납품 조건 :";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "취 소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(301, 456);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "저 장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 71;
            this.label10.Text = "단 가 :";
            // 
            // txtBoxManufacture
            // 
            this.txtBoxManufacture.Location = new System.Drawing.Point(126, 160);
            this.txtBoxManufacture.Name = "txtBoxManufacture";
            this.txtBoxManufacture.ReadOnly = true;
            this.txtBoxManufacture.Size = new System.Drawing.Size(287, 21);
            this.txtBoxManufacture.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 68;
            this.label9.Text = "공급처 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 67;
            this.label8.Text = "Part 명 :";
            // 
            // txtBoxVendor
            // 
            this.txtBoxVendor.Location = new System.Drawing.Point(126, 133);
            this.txtBoxVendor.Name = "txtBoxVendor";
            this.txtBoxVendor.ReadOnly = true;
            this.txtBoxVendor.Size = new System.Drawing.Size(287, 21);
            this.txtBoxVendor.TabIndex = 66;
            // 
            // txtBoxPartName
            // 
            this.txtBoxPartName.Location = new System.Drawing.Point(126, 106);
            this.txtBoxPartName.Name = "txtBoxPartName";
            this.txtBoxPartName.ReadOnly = true;
            this.txtBoxPartName.Size = new System.Drawing.Size(287, 21);
            this.txtBoxPartName.TabIndex = 65;
            // 
            // txtBoxDrawingNumber
            // 
            this.txtBoxDrawingNumber.Location = new System.Drawing.Point(126, 187);
            this.txtBoxDrawingNumber.Name = "txtBoxDrawingNumber";
            this.txtBoxDrawingNumber.ReadOnly = true;
            this.txtBoxDrawingNumber.Size = new System.Drawing.Size(287, 21);
            this.txtBoxDrawingNumber.TabIndex = 63;
            // 
            // cbBoxCategory
            // 
            this.cbBoxCategory.FormattingEnabled = true;
            this.cbBoxCategory.Items.AddRange(new object[] {
            "구매부서 발주품",
            "구매요청 발주품"});
            this.cbBoxCategory.Location = new System.Drawing.Point(126, 17);
            this.cbBoxCategory.Name = "cbBoxCategory";
            this.cbBoxCategory.Size = new System.Drawing.Size(169, 20);
            this.cbBoxCategory.TabIndex = 0;
            // 
            // txtBoxPONumber
            // 
            this.txtBoxPONumber.Location = new System.Drawing.Point(126, 70);
            this.txtBoxPONumber.Name = "txtBoxPONumber";
            this.txtBoxPONumber.Size = new System.Drawing.Size(251, 21);
            this.txtBoxPONumber.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 60;
            this.label7.Text = "Maker P/N :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 59;
            this.label6.Text = "품의서 번호 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 58;
            this.label5.Text = "제조업체 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 57;
            this.label4.Text = "도면 번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "PO 구분 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 55;
            this.label2.Text = "Rev.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 54;
            this.label1.Text = "PO number :";
            // 
            // txtBoxConsultNumber
            // 
            this.txtBoxConsultNumber.Location = new System.Drawing.Point(126, 43);
            this.txtBoxConsultNumber.Name = "txtBoxConsultNumber";
            this.txtBoxConsultNumber.Size = new System.Drawing.Size(287, 21);
            this.txtBoxConsultNumber.TabIndex = 1;
            // 
            // PORevision
            // 
            this.PORevision.Location = new System.Drawing.Point(439, 70);
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
            this.PORevision.TabIndex = 3;
            this.PORevision.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBoxUnit
            // 
            this.txtBoxUnit.Location = new System.Drawing.Point(126, 241);
            this.txtBoxUnit.Name = "txtBoxUnit";
            this.txtBoxUnit.ReadOnly = true;
            this.txtBoxUnit.Size = new System.Drawing.Size(169, 21);
            this.txtBoxUnit.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 82;
            this.label12.Text = "단 위 :";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.Location = new System.Drawing.Point(126, 295);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(169, 21);
            this.txtBoxQuantity.TabIndex = 5;
            this.txtBoxQuantity.Text = "0";
            this.txtBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxQuantity_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 84;
            this.label13.Text = "수 량 :";
            // 
            // txtBoxTotalAmount
            // 
            this.txtBoxTotalAmount.Location = new System.Drawing.Point(126, 322);
            this.txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            this.txtBoxTotalAmount.Size = new System.Drawing.Size(169, 21);
            this.txtBoxTotalAmount.TabIndex = 6;
            this.txtBoxTotalAmount.Text = "0";
            this.txtBoxTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 325);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 86;
            this.label14.Text = "총 금액 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 352);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 88;
            this.label15.Text = "예상 납기 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 379);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 90;
            this.label16.Text = "요청 납기 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 406);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 92;
            this.label17.Text = "결제 조건 :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(301, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 97;
            this.label21.Text = "원";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(301, 325);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 8;
            this.label22.Text = "원";
            // 
            // cbBoxPaymentCondition
            // 
            this.cbBoxPaymentCondition.FormattingEnabled = true;
            this.cbBoxPaymentCondition.Items.AddRange(new object[] {
            "세금계산서 발행 후 30일",
            "세금계산서 발행 후 45일",
            "세금계산서 발행 후 60일",
            "송금"});
            this.cbBoxPaymentCondition.Location = new System.Drawing.Point(126, 403);
            this.cbBoxPaymentCondition.Name = "cbBoxPaymentCondition";
            this.cbBoxPaymentCondition.Size = new System.Drawing.Size(169, 20);
            this.cbBoxPaymentCondition.TabIndex = 9;
            // 
            // cbBoxDeliveryCondition
            // 
            this.cbBoxDeliveryCondition.FormattingEnabled = true;
            this.cbBoxDeliveryCondition.Items.AddRange(new object[] {
            "공장 인도"});
            this.cbBoxDeliveryCondition.Location = new System.Drawing.Point(126, 429);
            this.cbBoxDeliveryCondition.Name = "cbBoxDeliveryCondition";
            this.cbBoxDeliveryCondition.Size = new System.Drawing.Size(169, 20);
            this.cbBoxDeliveryCondition.TabIndex = 10;
            // 
            // dateTimeEstimate
            // 
            this.dateTimeEstimate.Location = new System.Drawing.Point(126, 349);
            this.dateTimeEstimate.Name = "dateTimeEstimate";
            this.dateTimeEstimate.Size = new System.Drawing.Size(169, 21);
            this.dateTimeEstimate.TabIndex = 98;
            // 
            // dateTimeRequest
            // 
            this.dateTimeRequest.Location = new System.Drawing.Point(126, 376);
            this.dateTimeRequest.Name = "dateTimeRequest";
            this.dateTimeRequest.Size = new System.Drawing.Size(169, 21);
            this.dateTimeRequest.TabIndex = 99;
            // 
            // PurchaseOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 501);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimeRequest);
            this.Controls.Add(this.dateTimeEstimate);
            this.Controls.Add(this.cbBoxDeliveryCondition);
            this.Controls.Add(this.cbBoxPaymentCondition);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxTotalAmount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxUnit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PORevision);
            this.Controls.Add(this.txtBoxConsultNumber);
            this.Controls.Add(this.btnSelectVendor);
            this.Controls.Add(this.txtBoxUnitPrice);
            this.Controls.Add(this.txtBoxMakerPN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxManufacture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxVendor);
            this.Controls.Add(this.txtBoxPartName);
            this.Controls.Add(this.txtBoxDrawingNumber);
            this.Controls.Add(this.cbBoxCategory);
            this.Controls.Add(this.txtBoxPONumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PurchaseOrderAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrderAdd";
            ((System.ComponentModel.ISupportInitialize)(this.PORevision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectVendor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.ComboBox cbBoxCategory;
        public System.Windows.Forms.TextBox txtBoxPONumber;
        public System.Windows.Forms.TextBox txtBoxConsultNumber;
        public System.Windows.Forms.NumericUpDown PORevision;
        public System.Windows.Forms.TextBox txtBoxQuantity;
        public System.Windows.Forms.TextBox txtBoxTotalAmount;
        public System.Windows.Forms.ComboBox cbBoxPaymentCondition;
        public System.Windows.Forms.ComboBox cbBoxDeliveryCondition;
        public System.Windows.Forms.TextBox txtBoxUnitPrice;
        public System.Windows.Forms.TextBox txtBoxMakerPN;
        public System.Windows.Forms.TextBox txtBoxManufacture;
        public System.Windows.Forms.TextBox txtBoxVendor;
        public System.Windows.Forms.TextBox txtBoxPartName;
        public System.Windows.Forms.TextBox txtBoxDrawingNumber;
        public System.Windows.Forms.TextBox txtBoxUnit;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DateTimePicker dateTimeEstimate;
        public System.Windows.Forms.DateTimePicker dateTimeRequest;
    }
}