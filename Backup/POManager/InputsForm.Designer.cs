namespace POManager
{
    partial class InputsForm
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
            this.ckBoxAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridInputs = new System.Windows.Forms.DataGridView();
            this.btnRegist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_condition = new System.Windows.Forms.Button();
            this.textBox_condition = new System.Windows.Forms.TextBox();
            this.cbBoxSearch = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInputs)).BeginInit();
            this.SuspendLayout();
            // 
            // ckBoxAll
            // 
            this.ckBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxAll.AutoSize = true;
            this.ckBoxAll.Location = new System.Drawing.Point(809, 36);
            this.ckBoxAll.Name = "ckBoxAll";
            this.ckBoxAll.Size = new System.Drawing.Size(76, 16);
            this.ckBoxAll.TabIndex = 21;
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
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "입 고";
            // 
            // dataGridInputs
            // 
            this.dataGridInputs.AllowUserToAddRows = false;
            this.dataGridInputs.AllowUserToDeleteRows = false;
            this.dataGridInputs.AllowUserToOrderColumns = true;
            this.dataGridInputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridInputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInputs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridInputs.Location = new System.Drawing.Point(12, 58);
            this.dataGridInputs.Name = "dataGridInputs";
            this.dataGridInputs.ReadOnly = true;
            this.dataGridInputs.RowHeadersVisible = false;
            this.dataGridInputs.RowTemplate.Height = 23;
            this.dataGridInputs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridInputs.Size = new System.Drawing.Size(782, 421);
            this.dataGridInputs.TabIndex = 18;
            this.dataGridInputs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInputs_CellDoubleClick);
            // 
            // btnRegist
            // 
            this.btnRegist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegist.Location = new System.Drawing.Point(800, 58);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(85, 40);
            this.btnRegist.TabIndex = 17;
            this.btnRegist.Text = "입고 등록";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(529, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 22);
            this.label2.TabIndex = 22;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(774, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 12);
            this.label3.TabIndex = 23;
            // 
            // button_condition
            // 
            this.button_condition.Location = new System.Drawing.Point(806, 26);
            this.button_condition.Name = "button_condition";
            this.button_condition.Size = new System.Drawing.Size(75, 23);
            this.button_condition.TabIndex = 37;
            this.button_condition.Text = "검색";
            this.button_condition.UseVisualStyleBackColor = true;
            this.button_condition.Click += new System.EventHandler(this.button_condition_Click);
            // 
            // textBox_condition
            // 
            this.textBox_condition.Location = new System.Drawing.Point(597, 26);
            this.textBox_condition.Name = "textBox_condition";
            this.textBox_condition.Size = new System.Drawing.Size(186, 21);
            this.textBox_condition.TabIndex = 36;
            // 
            // cbBoxSearch
            // 
            this.cbBoxSearch.FormattingEnabled = true;
            this.cbBoxSearch.Items.AddRange(new object[] {
            "코드",
            "자재NO.",
            "공급업체"});
            this.cbBoxSearch.Location = new System.Drawing.Point(451, 26);
            this.cbBoxSearch.Name = "cbBoxSearch";
            this.cbBoxSearch.Size = new System.Drawing.Size(140, 20);
            this.cbBoxSearch.TabIndex = 35;
            this.cbBoxSearch.SelectedIndexChanged += new System.EventHandler(this.cbBoxSearch_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(800, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 38;
            this.button1.Text = "Excel 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 491);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_condition);
            this.Controls.Add(this.textBox_condition);
            this.Controls.Add(this.cbBoxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckBoxAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridInputs);
            this.Controls.Add(this.btnRegist);
            this.Name = "InputsForm";
            this.Text = "입고 관리";
            this.Load += new System.EventHandler(this.InputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBoxAll;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridInputs;
        private System.Windows.Forms.Button btnRegist;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_condition;
        private System.Windows.Forms.TextBox textBox_condition;
        private System.Windows.Forms.ComboBox cbBoxSearch;
        private System.Windows.Forms.Button button1;
    }
}