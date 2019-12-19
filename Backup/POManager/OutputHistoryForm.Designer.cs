﻿namespace POManager
{
    partial class OutputHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ckBoxAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridOutputs = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_to = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateTo = new System.Windows.Forms.DateTimePicker();
            this.gb_from = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateFrom = new System.Windows.Forms.DateTimePicker();
            this.rdBtnDate = new System.Windows.Forms.RadioButton();
            this.rdBtnAll = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutputs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_to.SuspendLayout();
            this.gb_from.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckBoxAll
            // 
            this.ckBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxAll.AutoSize = true;
            this.ckBoxAll.Location = new System.Drawing.Point(842, 33);
            this.ckBoxAll.Name = "ckBoxAll";
            this.ckBoxAll.Size = new System.Drawing.Size(76, 16);
            this.ckBoxAll.TabIndex = 26;
            this.ckBoxAll.Text = "전체 표시";
            this.ckBoxAll.UseVisualStyleBackColor = true;
            this.ckBoxAll.CheckedChanged += new System.EventHandler(this.ckBoxAll_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "출고 기록";
            // 
            // dataGridOutputs
            // 
            this.dataGridOutputs.AllowUserToAddRows = false;
            this.dataGridOutputs.AllowUserToDeleteRows = false;
            this.dataGridOutputs.AllowUserToOrderColumns = true;
            this.dataGridOutputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOutputs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOutputs.Location = new System.Drawing.Point(13, 51);
            this.dataGridOutputs.Name = "dataGridOutputs";
            this.dataGridOutputs.ReadOnly = true;
            this.dataGridOutputs.RowHeadersVisible = false;
            this.dataGridOutputs.RowTemplate.Height = 23;
            this.dataGridOutputs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOutputs.Size = new System.Drawing.Size(903, 389);
            this.dataGridOutputs.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.gb_to);
            this.groupBox1.Controls.Add(this.gb_from);
            this.groupBox1.Controls.Add(this.rdBtnDate);
            this.groupBox1.Controls.Add(this.rdBtnAll);
            this.groupBox1.Location = new System.Drawing.Point(192, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 47);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 조건";
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
            this.rdBtnDate.Location = new System.Drawing.Point(69, 19);
            this.rdBtnDate.Name = "rdBtnDate";
            this.rdBtnDate.Size = new System.Drawing.Size(75, 16);
            this.rdBtnDate.TabIndex = 1;
            this.rdBtnDate.Text = "날짜 검색";
            this.rdBtnDate.UseVisualStyleBackColor = true;
            this.rdBtnDate.CheckedChanged += new System.EventHandler(this.ckBoxAll_CheckedChanged);
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
            this.button1.Location = new System.Drawing.Point(841, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Excel 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 479);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckBoxAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOutputs);
            this.Name = "OutputHistoryForm";
            this.Text = "출고 기록";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutputs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_to.ResumeLayout(false);
            this.gb_from.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckBoxAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridOutputs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnDate;
        private System.Windows.Forms.RadioButton rdBtnAll;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.GroupBox gb_to;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateTo;
        private System.Windows.Forms.GroupBox gb_from;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateFrom;
        private System.Windows.Forms.Button button1;
    }
}