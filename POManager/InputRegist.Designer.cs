namespace POManager
{
    partial class InputRegist
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxPONumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxPORevision = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtBoxInputTotalAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxInputQuantity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxPOTotalAmount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxPOQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxUnit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBoxMakerPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxManufacture = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxVendor = new System.Windows.Forms.TextBox();
            this.txtBoxPartName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMinusQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxMinusTotalAmount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBoxResolver = new System.Windows.Forms.TextBox();
            this.dateTimeInputDate = new System.Windows.Forms.DateTimePicker();
            this.la_code = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(416, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "취 소";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(310, 411);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "저 장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxPONumber
            // 
            this.txtBoxPONumber.Location = new System.Drawing.Point(123, 13);
            this.txtBoxPONumber.Name = "txtBoxPONumber";
            this.txtBoxPONumber.ReadOnly = true;
            this.txtBoxPONumber.Size = new System.Drawing.Size(251, 21);
            this.txtBoxPONumber.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 12);
            this.label11.TabIndex = 83;
            this.label11.Text = "Rev.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 82;
            this.label12.Text = "PO number :";
            // 
            // txtBoxPORevision
            // 
            this.txtBoxPORevision.Location = new System.Drawing.Point(432, 13);
            this.txtBoxPORevision.Name = "txtBoxPORevision";
            this.txtBoxPORevision.ReadOnly = true;
            this.txtBoxPORevision.Size = new System.Drawing.Size(83, 21);
            this.txtBoxPORevision.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(298, 232);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 128;
            this.label22.Text = "원";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(298, 178);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 12);
            this.label21.TabIndex = 127;
            this.label21.Text = "원";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 12);
            this.label17.TabIndex = 124;
            this.label17.Text = "미 입고 수량 :";
            // 
            // txtBoxInputTotalAmount
            // 
            this.txtBoxInputTotalAmount.Location = new System.Drawing.Point(123, 283);
            this.txtBoxInputTotalAmount.Name = "txtBoxInputTotalAmount";
            this.txtBoxInputTotalAmount.ReadOnly = true;
            this.txtBoxInputTotalAmount.Size = new System.Drawing.Size(169, 21);
            this.txtBoxInputTotalAmount.TabIndex = 12;
            this.txtBoxInputTotalAmount.Text = "0";
            this.txtBoxInputTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 12);
            this.label16.TabIndex = 122;
            this.label16.Text = "총 입고 금액 :";
            // 
            // txtBoxInputQuantity
            // 
            this.txtBoxInputQuantity.Location = new System.Drawing.Point(123, 256);
            this.txtBoxInputQuantity.Name = "txtBoxInputQuantity";
            this.txtBoxInputQuantity.Size = new System.Drawing.Size(169, 21);
            this.txtBoxInputQuantity.TabIndex = 11;
            this.txtBoxInputQuantity.Text = "0";
            this.txtBoxInputQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxInputQuantity_KeyDown_1);
            this.txtBoxInputQuantity.Leave += new System.EventHandler(this.txtBoxInputQuantity_Leave);
            this.txtBoxInputQuantity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBoxInputQuantity_MouseDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 259);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 120;
            this.label15.Text = "입고 수량 :";
            // 
            // txtBoxPOTotalAmount
            // 
            this.txtBoxPOTotalAmount.Location = new System.Drawing.Point(123, 229);
            this.txtBoxPOTotalAmount.Name = "txtBoxPOTotalAmount";
            this.txtBoxPOTotalAmount.ReadOnly = true;
            this.txtBoxPOTotalAmount.Size = new System.Drawing.Size(169, 21);
            this.txtBoxPOTotalAmount.TabIndex = 10;
            this.txtBoxPOTotalAmount.Text = "0";
            this.txtBoxPOTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 12);
            this.label14.TabIndex = 118;
            this.label14.Text = "총 PO 금액 :";
            // 
            // txtBoxPOQuantity
            // 
            this.txtBoxPOQuantity.Location = new System.Drawing.Point(123, 202);
            this.txtBoxPOQuantity.Name = "txtBoxPOQuantity";
            this.txtBoxPOQuantity.ReadOnly = true;
            this.txtBoxPOQuantity.Size = new System.Drawing.Size(169, 21);
            this.txtBoxPOQuantity.TabIndex = 9;
            this.txtBoxPOQuantity.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 12);
            this.label13.TabIndex = 116;
            this.label13.Text = "PO 수량 :";
            // 
            // txtBoxUnit
            // 
            this.txtBoxUnit.Location = new System.Drawing.Point(123, 148);
            this.txtBoxUnit.Name = "txtBoxUnit";
            this.txtBoxUnit.ReadOnly = true;
            this.txtBoxUnit.Size = new System.Drawing.Size(169, 21);
            this.txtBoxUnit.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 114;
            this.label1.Text = "단 위 :";
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(123, 175);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.ReadOnly = true;
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(169, 21);
            this.txtBoxUnitPrice.TabIndex = 8;
            this.txtBoxUnitPrice.Text = "0";
            this.txtBoxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBoxMakerPN
            // 
            this.txtBoxMakerPN.Location = new System.Drawing.Point(123, 121);
            this.txtBoxMakerPN.Name = "txtBoxMakerPN";
            this.txtBoxMakerPN.ReadOnly = true;
            this.txtBoxMakerPN.Size = new System.Drawing.Size(287, 21);
            this.txtBoxMakerPN.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 111;
            this.label2.Text = "미 입고 금액 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 110;
            this.label10.Text = "단 가 :";
            // 
            // txtBoxManufacture
            // 
            this.txtBoxManufacture.Location = new System.Drawing.Point(123, 94);
            this.txtBoxManufacture.Name = "txtBoxManufacture";
            this.txtBoxManufacture.ReadOnly = true;
            this.txtBoxManufacture.Size = new System.Drawing.Size(287, 21);
            this.txtBoxManufacture.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 108;
            this.label9.Text = "공급처 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 107;
            this.label8.Text = "Part 명 :";
            // 
            // txtBoxVendor
            // 
            this.txtBoxVendor.Location = new System.Drawing.Point(123, 67);
            this.txtBoxVendor.Name = "txtBoxVendor";
            this.txtBoxVendor.ReadOnly = true;
            this.txtBoxVendor.Size = new System.Drawing.Size(287, 21);
            this.txtBoxVendor.TabIndex = 4;
            // 
            // txtBoxPartName
            // 
            this.txtBoxPartName.Location = new System.Drawing.Point(123, 40);
            this.txtBoxPartName.Name = "txtBoxPartName";
            this.txtBoxPartName.ReadOnly = true;
            this.txtBoxPartName.Size = new System.Drawing.Size(169, 21);
            this.txtBoxPartName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 103;
            this.label7.Text = "Maker P/N :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 102;
            this.label5.Text = "제조업체 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 129;
            this.label3.Text = "원";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 130;
            this.label6.Text = "원";
            // 
            // txtBoxMinusQuantity
            // 
            this.txtBoxMinusQuantity.Location = new System.Drawing.Point(123, 310);
            this.txtBoxMinusQuantity.Name = "txtBoxMinusQuantity";
            this.txtBoxMinusQuantity.ReadOnly = true;
            this.txtBoxMinusQuantity.Size = new System.Drawing.Size(169, 21);
            this.txtBoxMinusQuantity.TabIndex = 13;
            this.txtBoxMinusQuantity.Text = "0";
            // 
            // txtBoxMinusTotalAmount
            // 
            this.txtBoxMinusTotalAmount.Location = new System.Drawing.Point(123, 337);
            this.txtBoxMinusTotalAmount.Name = "txtBoxMinusTotalAmount";
            this.txtBoxMinusTotalAmount.ReadOnly = true;
            this.txtBoxMinusTotalAmount.Size = new System.Drawing.Size(169, 21);
            this.txtBoxMinusTotalAmount.TabIndex = 14;
            this.txtBoxMinusTotalAmount.Text = "0";
            this.txtBoxMinusTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 367);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 135;
            this.label19.Text = "입고 처리자 :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 397);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 136;
            this.label20.Text = "입고 날짜 :";
            // 
            // txtBoxResolver
            // 
            this.txtBoxResolver.Location = new System.Drawing.Point(123, 364);
            this.txtBoxResolver.Name = "txtBoxResolver";
            this.txtBoxResolver.Size = new System.Drawing.Size(169, 21);
            this.txtBoxResolver.TabIndex = 16;
            // 
            // dateTimeInputDate
            // 
            this.dateTimeInputDate.Location = new System.Drawing.Point(123, 391);
            this.dateTimeInputDate.Name = "dateTimeInputDate";
            this.dateTimeInputDate.Size = new System.Drawing.Size(169, 21);
            this.dateTimeInputDate.TabIndex = 17;
            // 
            // la_code
            // 
            this.la_code.AutoSize = true;
            this.la_code.Location = new System.Drawing.Point(319, 43);
            this.la_code.Name = "la_code";
            this.la_code.Size = new System.Drawing.Size(69, 12);
            this.la_code.TabIndex = 138;
            this.la_code.Text = "Part Code :";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(394, 40);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.ReadOnly = true;
            this.textBox_code.Size = new System.Drawing.Size(122, 21);
            this.textBox_code.TabIndex = 3;
            // 
            // InputRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(524, 464);
            this.ControlBox = false;
            this.Controls.Add(this.la_code);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.dateTimeInputDate);
            this.Controls.Add(this.txtBoxResolver);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtBoxMinusTotalAmount);
            this.Controls.Add(this.txtBoxMinusQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBoxInputTotalAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBoxInputQuantity);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxPOTotalAmount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBoxPOQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBoxUnit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxUnitPrice);
            this.Controls.Add(this.txtBoxMakerPN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBoxManufacture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxVendor);
            this.Controls.Add(this.txtBoxPartName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxPORevision);
            this.Controls.Add(this.txtBoxPONumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InputRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "입고 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label22;
        public System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtBoxPONumber;
        public System.Windows.Forms.TextBox txtBoxPORevision;
        public System.Windows.Forms.TextBox txtBoxPOTotalAmount;
        public System.Windows.Forms.TextBox txtBoxPOQuantity;
        public System.Windows.Forms.TextBox txtBoxUnit;
        public System.Windows.Forms.TextBox txtBoxUnitPrice;
        public System.Windows.Forms.TextBox txtBoxMakerPN;
        public System.Windows.Forms.TextBox txtBoxManufacture;
        public System.Windows.Forms.TextBox txtBoxVendor;
        public System.Windows.Forms.TextBox txtBoxPartName;
        public System.Windows.Forms.TextBox txtBoxInputQuantity;
        public System.Windows.Forms.TextBox txtBoxResolver;
        public System.Windows.Forms.TextBox txtBoxInputTotalAmount;
        public System.Windows.Forms.TextBox txtBoxMinusQuantity;
        public System.Windows.Forms.TextBox txtBoxMinusTotalAmount;
        public System.Windows.Forms.DateTimePicker dateTimeInputDate;
        private System.Windows.Forms.Label la_code;
        public System.Windows.Forms.TextBox textBox_code;

    }
}