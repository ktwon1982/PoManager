namespace POManager
{
    partial class VendorsForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridVendors = new System.Windows.Forms.DataGridView();
            this.dataGridContacts = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ckBoxAll = new System.Windows.Forms.CheckBox();
            this.btnContactModify = new System.Windows.Forms.Button();
            this.btnContactAdd = new System.Windows.Forms.Button();
            this.cbBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(809, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "업체 등록";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridVendors
            // 
            this.dataGridVendors.AllowUserToAddRows = false;
            this.dataGridVendors.AllowUserToDeleteRows = false;
            this.dataGridVendors.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridVendors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridVendors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridVendors.Location = new System.Drawing.Point(15, 36);
            this.dataGridVendors.Name = "dataGridVendors";
            this.dataGridVendors.ReadOnly = true;
            this.dataGridVendors.RowHeadersVisible = false;
            this.dataGridVendors.RowTemplate.Height = 23;
            this.dataGridVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVendors.Size = new System.Drawing.Size(788, 186);
            this.dataGridVendors.TabIndex = 1;
            this.dataGridVendors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVendors_CellDoubleClick);
            this.dataGridVendors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVendor_CellClick);
            // 
            // dataGridContacts
            // 
            this.dataGridContacts.AllowUserToAddRows = false;
            this.dataGridContacts.AllowUserToDeleteRows = false;
            this.dataGridContacts.AllowUserToOrderColumns = true;
            this.dataGridContacts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridContacts.Location = new System.Drawing.Point(15, 228);
            this.dataGridContacts.Name = "dataGridContacts";
            this.dataGridContacts.ReadOnly = true;
            this.dataGridContacts.RowHeadersVisible = false;
            this.dataGridContacts.RowTemplate.Height = 23;
            this.dataGridContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridContacts.Size = new System.Drawing.Size(788, 147);
            this.dataGridContacts.TabIndex = 2;
            this.dataGridContacts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridContacts_CellDoubleClick);
            // 
            // btnModify
            // 
            this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModify.Location = new System.Drawing.Point(809, 80);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 40);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "업체 수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "업 체";
            // 
            // ckBoxAll
            // 
            this.ckBoxAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckBoxAll.AutoSize = true;
            this.ckBoxAll.Location = new System.Drawing.Point(809, 12);
            this.ckBoxAll.Name = "ckBoxAll";
            this.ckBoxAll.Size = new System.Drawing.Size(76, 16);
            this.ckBoxAll.TabIndex = 6;
            this.ckBoxAll.Text = "전체 표시";
            this.ckBoxAll.UseVisualStyleBackColor = true;
            this.ckBoxAll.CheckedChanged += new System.EventHandler(this.ckBoxAll_CheckedChanged);
            // 
            // btnContactModify
            // 
            this.btnContactModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContactModify.Location = new System.Drawing.Point(809, 272);
            this.btnContactModify.Name = "btnContactModify";
            this.btnContactModify.Size = new System.Drawing.Size(85, 40);
            this.btnContactModify.TabIndex = 8;
            this.btnContactModify.Text = "담당자 수정";
            this.btnContactModify.UseVisualStyleBackColor = true;
            this.btnContactModify.Click += new System.EventHandler(this.btnContactModify_Click);
            // 
            // btnContactAdd
            // 
            this.btnContactAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContactAdd.Location = new System.Drawing.Point(809, 226);
            this.btnContactAdd.Name = "btnContactAdd";
            this.btnContactAdd.Size = new System.Drawing.Size(85, 40);
            this.btnContactAdd.TabIndex = 7;
            this.btnContactAdd.Text = "담당자 등록";
            this.btnContactAdd.UseVisualStyleBackColor = true;
            this.btnContactAdd.Click += new System.EventHandler(this.btnContactAdd_Click);
            // 
            // cbBoxCategory
            // 
            this.cbBoxCategory.FormattingEnabled = true;
            this.cbBoxCategory.Items.AddRange(new object[] {
            "모두",
            "공급업체",
            "제조업체"});
            this.cbBoxCategory.Location = new System.Drawing.Point(173, 12);
            this.cbBoxCategory.Name = "cbBoxCategory";
            this.cbBoxCategory.Size = new System.Drawing.Size(169, 20);
            this.cbBoxCategory.TabIndex = 16;
            this.cbBoxCategory.SelectedIndexChanged += new System.EventHandler(this.ckBoxAll_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "거래처 구분 :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(640, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 15);
            this.label4.TabIndex = 18;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(809, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Exel 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(809, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Exel 저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(809, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 40);
            this.button3.TabIndex = 21;
            this.button3.Text = "발주 현황";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VendorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 387);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContactModify);
            this.Controls.Add(this.btnContactAdd);
            this.Controls.Add(this.ckBoxAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dataGridContacts);
            this.Controls.Add(this.dataGridVendors);
            this.Controls.Add(this.btnAdd);
            this.Name = "VendorsForm";
            this.Text = "업체 관리";
            this.Load += new System.EventHandler(this.VendorForm_Load);
            this.Activated += new System.EventHandler(this.VendorForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContacts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridVendors;
        private System.Windows.Forms.DataGridView dataGridContacts;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckBoxAll;
        private System.Windows.Forms.Button btnContactModify;
        private System.Windows.Forms.Button btnContactAdd;
        private System.Windows.Forms.ComboBox cbBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}