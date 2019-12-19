namespace POManager
{
    partial class PartsAdd
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
            this.ckBoxIsUse = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxMakerPN = new System.Windows.Forms.TextBox();
            this.cbBoxCategory2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxManufacture = new System.Windows.Forms.TextBox();
            this.txtBoxVendor = new System.Windows.Forms.TextBox();
            this.txtBoxPartNumber = new System.Windows.Forms.TextBox();
            this.txtBoxDrawingNumber = new System.Windows.Forms.TextBox();
            this.cbBoxCategory1 = new System.Windows.Forms.ComboBox();
            this.txtBoxPartName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxUnit = new System.Windows.Forms.TextBox();
            this.txtBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBoxDeliveryDate = new System.Windows.Forms.TextBox();
            this.btnSelectVendor = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.ckBoxNewAdd = new System.Windows.Forms.CheckBox();
            this.textBox_partsForMechine = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox_moneyType = new System.Windows.Forms.ComboBox();
            this.textBox_Revision = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.la_code = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckBoxIsUse
            // 
            this.ckBoxIsUse.AutoSize = true;
            this.ckBoxIsUse.Checked = true;
            this.ckBoxIsUse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxIsUse.Location = new System.Drawing.Point(125, 355);
            this.ckBoxIsUse.Name = "ckBoxIsUse";
            this.ckBoxIsUse.Size = new System.Drawing.Size(76, 16);
            this.ckBoxIsUse.TabIndex = 16;
            this.ckBoxIsUse.Text = "사용 유무";
            this.ckBoxIsUse.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(418, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "취 소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(312, 342);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "저 장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "단 가 :";
            // 
            // txtBoxMakerPN
            // 
            this.txtBoxMakerPN.Location = new System.Drawing.Point(96, 233);
            this.txtBoxMakerPN.Name = "txtBoxMakerPN";
            this.txtBoxMakerPN.Size = new System.Drawing.Size(287, 21);
            this.txtBoxMakerPN.TabIndex = 10;
            // 
            // cbBoxCategory2
            // 
            this.cbBoxCategory2.FormattingEnabled = true;
            this.cbBoxCategory2.Items.AddRange(new object[] {
            "Frame and Utility",
            "Chamber and Hotzone",
            "Vacuum",
            "Control Pack",
            "Driving Module",
            "기타"});
            this.cbBoxCategory2.Location = new System.Drawing.Point(96, 41);
            this.cbBoxCategory2.Name = "cbBoxCategory2";
            this.cbBoxCategory2.Size = new System.Drawing.Size(169, 20);
            this.cbBoxCategory2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "제조 업체 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "공급 업체 :";
            // 
            // txtBoxManufacture
            // 
            this.txtBoxManufacture.Location = new System.Drawing.Point(96, 179);
            this.txtBoxManufacture.Name = "txtBoxManufacture";
            this.txtBoxManufacture.Size = new System.Drawing.Size(287, 21);
            this.txtBoxManufacture.TabIndex = 7;
            // 
            // txtBoxVendor
            // 
            this.txtBoxVendor.Location = new System.Drawing.Point(96, 152);
            this.txtBoxVendor.Name = "txtBoxVendor";
            this.txtBoxVendor.ReadOnly = true;
            this.txtBoxVendor.Size = new System.Drawing.Size(287, 21);
            this.txtBoxVendor.TabIndex = 37;
            // 
            // txtBoxPartNumber
            // 
            this.txtBoxPartNumber.Location = new System.Drawing.Point(96, 67);
            this.txtBoxPartNumber.Name = "txtBoxPartNumber";
            this.txtBoxPartNumber.Size = new System.Drawing.Size(172, 21);
            this.txtBoxPartNumber.TabIndex = 2;
            // 
            // txtBoxDrawingNumber
            // 
            this.txtBoxDrawingNumber.Location = new System.Drawing.Point(96, 206);
            this.txtBoxDrawingNumber.Name = "txtBoxDrawingNumber";
            this.txtBoxDrawingNumber.Size = new System.Drawing.Size(230, 21);
            this.txtBoxDrawingNumber.TabIndex = 8;
            // 
            // cbBoxCategory1
            // 
            this.cbBoxCategory1.FormattingEnabled = true;
            this.cbBoxCategory1.Items.AddRange(new object[] {
            "상용품",
            "가공품",
            "소모품",
            "원재료"});
            this.cbBoxCategory1.Location = new System.Drawing.Point(96, 15);
            this.cbBoxCategory1.Name = "cbBoxCategory1";
            this.cbBoxCategory1.Size = new System.Drawing.Size(169, 20);
            this.cbBoxCategory1.TabIndex = 0;
            // 
            // txtBoxPartName
            // 
            this.txtBoxPartName.Location = new System.Drawing.Point(96, 94);
            this.txtBoxPartName.Name = "txtBoxPartName";
            this.txtBoxPartName.Size = new System.Drawing.Size(393, 21);
            this.txtBoxPartName.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 32;
            this.label7.Text = "단 위 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "Part 구분2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "Maker P/N :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "도면 번호 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "Part 구분1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "Part number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "Part 명 : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 49;
            this.label11.Text = "납품 기간 :";
            // 
            // txtBoxUnit
            // 
            this.txtBoxUnit.Location = new System.Drawing.Point(96, 267);
            this.txtBoxUnit.Name = "txtBoxUnit";
            this.txtBoxUnit.Size = new System.Drawing.Size(169, 21);
            this.txtBoxUnit.TabIndex = 11;
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(96, 294);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(169, 21);
            this.txtBoxUnitPrice.TabIndex = 12;
            this.txtBoxUnitPrice.Text = "0";
            this.txtBoxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxDeliveryDate
            // 
            this.txtBoxDeliveryDate.Location = new System.Drawing.Point(96, 321);
            this.txtBoxDeliveryDate.Name = "txtBoxDeliveryDate";
            this.txtBoxDeliveryDate.Size = new System.Drawing.Size(169, 21);
            this.txtBoxDeliveryDate.TabIndex = 14;
            // 
            // btnSelectVendor
            // 
            this.btnSelectVendor.Location = new System.Drawing.Point(389, 152);
            this.btnSelectVendor.Name = "btnSelectVendor";
            this.btnSelectVendor.Size = new System.Drawing.Size(34, 23);
            this.btnSelectVendor.TabIndex = 6;
            this.btnSelectVendor.Text = "...";
            this.btnSelectVendor.UseVisualStyleBackColor = true;
            this.btnSelectVendor.Click += new System.EventHandler(this.btnSelectVendor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "일";
            // 
            // ckBoxNewAdd
            // 
            this.ckBoxNewAdd.AutoSize = true;
            this.ckBoxNewAdd.Location = new System.Drawing.Point(207, 355);
            this.ckBoxNewAdd.Name = "ckBoxNewAdd";
            this.ckBoxNewAdd.Size = new System.Drawing.Size(76, 16);
            this.ckBoxNewAdd.TabIndex = 17;
            this.ckBoxNewAdd.Text = "새로 추가";
            this.ckBoxNewAdd.UseVisualStyleBackColor = true;
            this.ckBoxNewAdd.CheckedChanged += new System.EventHandler(this.ckBoxNewAdd_CheckedChanged);
            // 
            // textBox_partsForMechine
            // 
            this.textBox_partsForMechine.Location = new System.Drawing.Point(184, 117);
            this.textBox_partsForMechine.Name = "textBox_partsForMechine";
            this.textBox_partsForMechine.Size = new System.Drawing.Size(84, 21);
            this.textBox_partsForMechine.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 12);
            this.label13.TabIndex = 100;
            this.label13.Text = "장비 한대당 필요한 parts 수 : ";
            // 
            // comboBox_moneyType
            // 
            this.comboBox_moneyType.FormattingEnabled = true;
            this.comboBox_moneyType.Items.AddRange(new object[] {
            "원",
            "달러"});
            this.comboBox_moneyType.Location = new System.Drawing.Point(271, 295);
            this.comboBox_moneyType.Name = "comboBox_moneyType";
            this.comboBox_moneyType.Size = new System.Drawing.Size(72, 20);
            this.comboBox_moneyType.TabIndex = 13;
            this.comboBox_moneyType.Text = "화폐단위";
            // 
            // textBox_Revision
            // 
            this.textBox_Revision.Location = new System.Drawing.Point(439, 206);
            this.textBox_Revision.Name = "textBox_Revision";
            this.textBox_Revision.Size = new System.Drawing.Size(50, 21);
            this.textBox_Revision.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(342, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 103;
            this.label14.Text = "도면 Revision :";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(367, 67);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(122, 21);
            this.textBox_code.TabIndex = 3;
            // 
            // la_code
            // 
            this.la_code.AutoSize = true;
            this.la_code.Location = new System.Drawing.Point(292, 70);
            this.la_code.Name = "la_code";
            this.la_code.Size = new System.Drawing.Size(69, 12);
            this.la_code.TabIndex = 105;
            this.la_code.Text = "Part Code :";
            // 
            // PartsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(530, 392);
            this.ControlBox = false;
            this.Controls.Add(this.la_code);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_Revision);
            this.Controls.Add(this.comboBox_moneyType);
            this.Controls.Add(this.textBox_partsForMechine);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ckBoxNewAdd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSelectVendor);
            this.Controls.Add(this.txtBoxDeliveryDate);
            this.Controls.Add(this.txtBoxUnitPrice);
            this.Controls.Add(this.txtBoxUnit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ckBoxIsUse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxMakerPN);
            this.Controls.Add(this.cbBoxCategory2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxManufacture);
            this.Controls.Add(this.txtBoxVendor);
            this.Controls.Add(this.txtBoxPartNumber);
            this.Controls.Add(this.txtBoxDrawingNumber);
            this.Controls.Add(this.cbBoxCategory1);
            this.Controls.Add(this.txtBoxPartName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PartsAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartsAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelectVendor;
        public System.Windows.Forms.CheckBox ckBoxNewAdd;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.CheckBox ckBoxIsUse;
        public System.Windows.Forms.TextBox txtBoxMakerPN;
        public System.Windows.Forms.ComboBox cbBoxCategory2;
        public System.Windows.Forms.TextBox txtBoxManufacture;
        public System.Windows.Forms.TextBox txtBoxVendor;
        public System.Windows.Forms.TextBox txtBoxPartNumber;
        public System.Windows.Forms.TextBox txtBoxDrawingNumber;
        public System.Windows.Forms.ComboBox cbBoxCategory1;
        public System.Windows.Forms.TextBox txtBoxPartName;
        public System.Windows.Forms.TextBox txtBoxUnit;
        public System.Windows.Forms.TextBox txtBoxUnitPrice;
        public System.Windows.Forms.TextBox txtBoxDeliveryDate;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox textBox_partsForMechine;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox comboBox_moneyType;
        public System.Windows.Forms.TextBox textBox_Revision;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label la_code;
    }
}