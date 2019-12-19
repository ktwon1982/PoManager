namespace POManager
{
    partial class PartsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ckBoxAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.dataGridParts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_search = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_to = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.gb_from = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.rdBtnDate = new System.Windows.Forms.RadioButton();
            this.rdBtnAll = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button_condition = new System.Windows.Forms.Button();
            this.textBox_condition = new System.Windows.Forms.TextBox();
            this.cbBoxSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).BeginInit();
            this.gb_search.SuspendLayout();
            this.gb_to.SuspendLayout();
            this.gb_from.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckBoxAll
            // 
            this.ckBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxAll.AutoSize = true;
            this.ckBoxAll.Location = new System.Drawing.Point(811, 78);
            this.ckBoxAll.Name = "ckBoxAll";
            this.ckBoxAll.Size = new System.Drawing.Size(76, 16);
            this.ckBoxAll.TabIndex = 11;
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
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Parts";
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(807, 145);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 40);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "Parts 수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // dataGridParts
            // 
            this.dataGridParts.AllowUserToAddRows = false;
            this.dataGridParts.AllowUserToDeleteRows = false;
            this.dataGridParts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridParts.Location = new System.Drawing.Point(17, 99);
            this.dataGridParts.Name = "dataGridParts";
            this.dataGridParts.ReadOnly = true;
            this.dataGridParts.RowHeadersVisible = false;
            this.dataGridParts.RowTemplate.Height = 23;
            this.dataGridParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParts.Size = new System.Drawing.Size(784, 280);
            this.dataGridParts.TabIndex = 8;
            this.dataGridParts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridParts_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(807, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Parts 등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(613, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 17;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gb_search
            // 
            this.gb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_search.Controls.Add(this.btn_search);
            this.gb_search.Controls.Add(this.gb_to);
            this.gb_search.Controls.Add(this.gb_from);
            this.gb_search.Controls.Add(this.rdBtnDate);
            this.gb_search.Controls.Add(this.rdBtnAll);
            this.gb_search.Location = new System.Drawing.Point(199, 12);
            this.gb_search.Name = "gb_search";
            this.gb_search.Size = new System.Drawing.Size(602, 47);
            this.gb_search.TabIndex = 33;
            this.gb_search.TabStop = false;
            this.gb_search.Text = "검색 조건";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(518, 20);
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
            this.gb_to.Location = new System.Drawing.Point(333, 8);
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
            this.gb_from.Location = new System.Drawing.Point(158, 9);
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
            this.rdBtnDate.Location = new System.Drawing.Point(69, 19);
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
            this.rdBtnAll.Location = new System.Drawing.Point(16, 20);
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
            this.button1.Location = new System.Drawing.Point(807, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 34;
            this.button1.Text = "Exel 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_condition
            // 
            this.button_condition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_condition.Location = new System.Drawing.Point(715, 66);
            this.button_condition.Name = "button_condition";
            this.button_condition.Size = new System.Drawing.Size(77, 24);
            this.button_condition.TabIndex = 46;
            this.button_condition.Text = "검색";
            this.button_condition.UseVisualStyleBackColor = true;
            this.button_condition.Click += new System.EventHandler(this.button_condition_Click);
            // 
            // textBox_condition
            // 
            this.textBox_condition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_condition.Location = new System.Drawing.Point(506, 66);
            this.textBox_condition.Name = "textBox_condition";
            this.textBox_condition.Size = new System.Drawing.Size(188, 21);
            this.textBox_condition.TabIndex = 45;
            // 
            // cbBoxSearch
            // 
            this.cbBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxSearch.FormattingEnabled = true;
            this.cbBoxSearch.Items.AddRange(new object[] {
            "코드",
            "자재NO.",
            "공급업체"});
            this.cbBoxSearch.Location = new System.Drawing.Point(360, 66);
            this.cbBoxSearch.Name = "cbBoxSearch";
            this.cbBoxSearch.Size = new System.Drawing.Size(142, 20);
            this.cbBoxSearch.TabIndex = 44;
            this.cbBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cbBoxSearch_SelectedIndexChanged);
            // 
            // PartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 391);
            this.ControlBox = false;
            this.Controls.Add(this.button_condition);
            this.Controls.Add(this.textBox_condition);
            this.Controls.Add(this.cbBoxSearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckBoxAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dataGridParts);
            this.Controls.Add(this.btnAdd);
            this.Name = "PartsForm";
            this.Text = "Parts 관리";
            this.Load += new System.EventHandler(this.PartsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParts)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridParts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox gb_to;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.GroupBox gb_from;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.RadioButton rdBtnDate;
        private System.Windows.Forms.RadioButton rdBtnAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_condition;
        private System.Windows.Forms.TextBox textBox_condition;
        private System.Windows.Forms.ComboBox cbBoxSearch;
    }
}