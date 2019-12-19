using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POManager
{
    public partial class OutputRegist : Form
    {
        public OutputRegist()
        {
            InitializeComponent();
        }
        bool flag = false;     //엔터키 press 여부

        private void txtBoxOutputQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            this.ActiveControl.BackColor = Color.Yellow;
            if (e.KeyCode == Keys.Enter)
            {
                flag = true;
                this.ActiveControl.BackColor = Color.White;

                int stockQuantity = Convert.ToInt16(txtBoxStockQuantity.Text);
                int outputQuantity = Convert.ToInt16(txtBoxOutputQuantity.Text);

                if (outputQuantity > stockQuantity)
                {
                    MessageBox.Show("Invaild output");
                    btnSave.Enabled = false;
                    return;
                }

                double unitPrice = Convert.ToDouble(txtBoxUnitPrice.Text);
                txtBoxOutputAmount.Text = (outputQuantity * unitPrice).ToString();

                txtBoxRestQuantity.Text = (stockQuantity - outputQuantity).ToString();
                int restQuantity = Convert.ToInt16(txtBoxRestQuantity.Text);
                txtBoxRestAmount.Text = (restQuantity * unitPrice).ToString();
            }
        }

        private void txtBoxOutputQuantity_Leave(object sender, EventArgs e)
        {
            if (flag)
            {
            }
            else
            {
                MessageBox.Show("엔터키를 눌러 수량을 입력 시키세요");
            }
        }

        private void txtBoxOutputQuantity_MouseDown(object sender, MouseEventArgs e)
        {
            flag = false;
        }

    }
}
