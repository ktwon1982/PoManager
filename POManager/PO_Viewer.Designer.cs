namespace POManager
{
    partial class PO_Viewer
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
            this.picSelect = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // picSelect
            // 
            this.picSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelect.Location = new System.Drawing.Point(12, 37);
            this.picSelect.Name = "picSelect";
            this.picSelect.Size = new System.Drawing.Size(450, 576);
            this.picSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSelect.TabIndex = 3;
            this.picSelect.TabStop = false;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(387, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PO_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 664);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picSelect);
            this.Name = "PO_Viewer";
            this.Text = "PO_Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox picSelect;
        private System.Windows.Forms.Button button1;


    }
}