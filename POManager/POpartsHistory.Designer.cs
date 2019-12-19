namespace POManager
{
    partial class POpartsHistory
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
            this.la_vendorName = new System.Windows.Forms.Label();
            this.textBox_vendorName = new System.Windows.Forms.TextBox();
            this.dataGridPOParts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOParts)).BeginInit();
            this.SuspendLayout();
            // 
            // la_vendorName
            // 
            this.la_vendorName.Location = new System.Drawing.Point(0, 18);
            this.la_vendorName.Name = "la_vendorName";
            this.la_vendorName.Size = new System.Drawing.Size(100, 23);
            this.la_vendorName.TabIndex = 0;
            this.la_vendorName.Text = "업체명 : ";
            this.la_vendorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_vendorName
            // 
            this.textBox_vendorName.Enabled = false;
            this.textBox_vendorName.Location = new System.Drawing.Point(119, 18);
            this.textBox_vendorName.Name = "textBox_vendorName";
            this.textBox_vendorName.Size = new System.Drawing.Size(236, 21);
            this.textBox_vendorName.TabIndex = 1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPOParts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPOParts.Location = new System.Drawing.Point(21, 56);
            this.dataGridPOParts.Name = "dataGridPOParts";
            this.dataGridPOParts.ReadOnly = true;
            this.dataGridPOParts.RowHeadersVisible = false;
            this.dataGridPOParts.RowTemplate.Height = 23;
            this.dataGridPOParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPOParts.Size = new System.Drawing.Size(399, 180);
            this.dataGridPOParts.TabIndex = 166;
            // 
            // POpartsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 264);
            this.Controls.Add(this.dataGridPOParts);
            this.Controls.Add(this.textBox_vendorName);
            this.Controls.Add(this.la_vendorName);
            this.Name = "POpartsHistory";
            this.Text = "POpartsHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPOParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label la_vendorName;
        public System.Windows.Forms.TextBox textBox_vendorName;
        public System.Windows.Forms.DataGridView dataGridPOParts;
    }
}