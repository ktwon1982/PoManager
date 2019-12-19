namespace POManager
{
    partial class PurchaseOrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ckBoxAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.dataGridPOs = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridPOParts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.button_condition = new System.Windows.Forms.Button();
            this.textBox_condition = new System.Windows.Forms.TextBox();
            this.radioButton_condition = new System.Windows.Forms.RadioButton();
            this.cbBoxSearch = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_to = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.gb_from = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.rdBtnDate = new System.Windows.Forms.RadioButton();
            this.rdBtnAll = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOParts)).BeginInit();
            this.gb_search.SuspendLayout();
            this.gb_to.SuspendLayout();
            this.gb_from.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckBoxAll
            // 
            this.ckBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxAll.AutoSize = true;
            this.ckBoxAll.Location = new System.Drawing.Point(805, 73);
            this.ckBoxAll.Name = "ckBoxAll";
            this.ckBoxAll.Size = new System.Drawing.Size(76, 16);
            this.ckBoxAll.TabIndex = 16;
            this.ckBoxAll.Text = "전체 표시";
            this.ckBoxAll.UseVisualStyleBackColor = true;
            this.ckBoxAll.CheckedChanged += new System.EventHandler(this.ckBoxAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "발 주 (PO)";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(802, 142);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 40);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "발주 수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dataGridPOs
            // 
            this.dataGridPOs.AllowUserToAddRows = false;
            this.dataGridPOs.AllowUserToDeleteRows = false;
            this.dataGridPOs.AllowUserToOrderColumns = true;
            this.dataGridPOs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPOs.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridPOs.Location = new System.Drawing.Point(11, 96);
            this.dataGridPOs.Name = "dataGridPOs";
            this.dataGridPOs.ReadOnly = true;
            this.dataGridPOs.RowHeadersVisible = false;
            this.dataGridPOs.RowTemplate.Height = 23;
            this.dataGridPOs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPOs.Size = new System.Drawing.Size(785, 163);
            this.dataGridPOs.TabIndex = 13;
            this.dataGridPOs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPOs_CellDoubleClick);
            this.dataGridPOs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPOs_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(802, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 40);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "발주 등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridPOParts
            // 
            this.dataGridPOParts.AllowUserToAddRows = false;
            this.dataGridPOParts.AllowUserToDeleteRows = false;
            this.dataGridPOParts.AllowUserToOrderColumns = true;
            this.dataGridPOParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPOParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPOParts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridPOParts.Location = new System.Drawing.Point(11, 265);
            this.dataGridPOParts.Name = "dataGridPOParts";
            this.dataGridPOParts.ReadOnly = true;
            this.dataGridPOParts.RowHeadersVisible = false;
            this.dataGridPOParts.RowTemplate.Height = 23;
            this.dataGridPOParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPOParts.Size = new System.Drawing.Size(785, 135);
            this.dataGridPOParts.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(633, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 21;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_search
            // 
            this.gb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_search.Controls.Add(this.button_condition);
            this.gb_search.Controls.Add(this.textBox_condition);
            this.gb_search.Controls.Add(this.radioButton_condition);
            this.gb_search.Controls.Add(this.cbBoxSearch);
            this.gb_search.Controls.Add(this.btn_search);
            this.gb_search.Controls.Add(this.gb_to);
            this.gb_search.Controls.Add(this.gb_from);
            this.gb_search.Controls.Add(this.rdBtnDate);
            this.gb_search.Controls.Add(this.rdBtnAll);
            this.gb_search.Location = new System.Drawing.Point(158, 10);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(637, 80);
            this.gb_search.TabIndex = 32;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "검색 조건";
            // 
            // button_condition
            // 
            this.button_condition.Location = new System.Drawing.Point(553, 54);
            this.button_condition.Name = "button_condition";
            this.button_condition.Size = new System.Drawing.Size(75, 23);
            this.button_condition.TabIndex = 34;
            this.button_condition.Text = "검색";
            this.button_condition.UseVisualStyleBackColor = true;
            this.button_condition.Click += new System.EventHandler(this.button_condition_Click);
            // 
            // textBox_condition
            // 
            this.textBox_condition.Location = new System.Drawing.Point(344, 54);
            this.textBox_condition.Name = "textBox_condition";
            this.textBox_condition.Size = new System.Drawing.Size(186, 21);
            this.textBox_condition.TabIndex = 33;
            // 
            // radioButton_condition
            // 
            this.radioButton_condition.AutoSize = true;
            this.radioButton_condition.Location = new System.Drawing.Point(102, 56);
            this.radioButton_condition.Name = "radioButton_condition";
            this.radioButton_condition.Size = new System.Drawing.Size(75, 16);
            this.radioButton_condition.TabIndex = 17;
            this.radioButton_condition.Text = "조건 검색";
            this.radioButton_condition.UseVisualStyleBackColor = true;
            this.radioButton_condition.CheckedChanged += new System.EventHandler(this.radioButton_condition_CheckedChanged);
            // 
            // cbBoxSearch
            // 
            this.cbBoxSearch.FormattingEnabled = true;
            this.cbBoxSearch.Items.AddRange(new object[] {
            "승인번호",
            "PO 번호",
            "공급업체"});
            this.cbBoxSearch.Location = new System.Drawing.Point(198, 54);
            this.cbBoxSearch.Name = "cbBoxSearch";
            this.cbBoxSearch.Size = new System.Drawing.Size(140, 20);
            this.cbBoxSearch.TabIndex = 16;
            this.cbBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cbBoxSearch_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(553, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.ckBoxAll_CheckedChanged);
            // 
            // gb_to
            // 
            this.gb_to.Controls.Add(this.dateTimePickerDateTo);
            this.gb_to.Location = new System.Drawing.Point(368, 8);
            this.gb_to.Name = "gb_to";
            this.gb_to.Size = new System.Drawing.Size(169, 36);
            this.gb_to.TabIndex = 4;
            this.gb_to.TabStop = false;
            this.gb_to.Text = "To";
            // 
            // dateTimePickerDateTo
            // 
            this.dateTimePickerDateTo.Location = new System.Drawing.Point(5, 11);
            this.dateTimePickerDateTo.Name = "dateTimePickerDateTo";
            this.dateTimePickerDateTo.Size = new System.Drawing.Size(157, 21);
            this.dateTimePickerDateTo.TabIndex = 1;
            // 
            // gb_from
            // 
            this.gb_from.Controls.Add(this.dateTimePickerDateFrom);
            this.gb_from.Location = new System.Drawing.Point(193, 9);
            this.gb_from.Name = "gb_from";
            this.gb_from.Size = new System.Drawing.Size(167, 36);
            this.gb_from.TabIndex = 3;
            this.gb_from.TabStop = false;
            this.gb_from.Text = "From";
            // 
            // dateTimePickerDateFrom
            // 
            this.dateTimePickerDateFrom.Location = new System.Drawing.Point(5, 11);
            this.dateTimePickerDateFrom.Name = "dateTimePickerDateFrom";
            this.dateTimePickerDateFrom.Size = new System.Drawing.Size(157, 21);
            this.dateTimePickerDateFrom.TabIndex = 0;
            // 
            // rdBtnDate
            // 
            this.rdBtnDate.AutoSize = true;
            this.rdBtnDate.Location = new System.Drawing.Point(102, 21);
            this.rdBtnDate.Name = "rdBtnDate";
            this.rdBtnDate.Size = new System.Drawing.Size(75, 16);
            this.rdBtnDate.TabIndex = 1;
            this.rdBtnDate.Text = "날짜 검색";
            this.rdBtnDate.UseVisualStyleBackColor = true;
            // 
            // rdBtnAll
            // 
            this.rdBtnAll.AutoSize = true;
            this.rdBtnAll.Checked = true;
            this.rdBtnAll.Location = new System.Drawing.Point(36, 21);
            this.rdBtnAll.Name = "rdBtnAll";
            this.rdBtnAll.Size = new System.Drawing.Size(47, 16);
            this.rdBtnAll.TabIndex = 0;
            this.rdBtnAll.TabStop = true;
            this.rdBtnAll.Text = "모두";
            this.rdBtnAll.UseVisualStyleBackColor = true;
            this.rdBtnAll.CheckedChanged += new System.EventHandler(this.ckBoxAll_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(802, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 33;
            this.button1.Text = "POExel 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(805, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 40);
            this.button2.TabIndex = 34;
            this.button2.Text = "POPartsExel 저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PurchaseOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 412);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridPOParts);
            this.Controls.Add(this.ckBoxAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dataGridPOs);
            this.Controls.Add(this.btnAdd);
            this.Name = "PurchaseOrdersForm";
            this.Text = "발주(PO) 관리";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            this.Activated += new System.EventHandler(this.PurchaseOrdersForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOParts)).EndInit();
            this.gb_search.ResumeLayout(false);
            this.gb_search.PerformLayout();
            this.gb_to.ResumeLayout(false);
            this.gb_from.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBoxAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.DataGridView dataGridPOs;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridPOParts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox gb_to;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.GroupBox gb_from;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.RadioButton rdBtnDate;
        private System.Windows.Forms.RadioButton rdBtnAll;
        private System.Windows.Forms.ComboBox cbBoxSearch;
        private System.Windows.Forms.RadioButton radioButton_condition;
        private System.Windows.Forms.Button button_condition;
        private System.Windows.Forms.TextBox textBox_condition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}