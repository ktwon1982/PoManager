using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace POManager
{
    public partial class InputRegist : Form
    {
        public InputRegist()
        {
            InitializeComponent();

            isComplete = false;
        }

        public InputRegist(SqlConnection sql)
        {
            InitializeComponent();
            conn = sql;
            isComplete = false;
        }
        ArrayList entity;
        private SqlConnection conn;
        public bool isComplete;
        bool flag = false;     //엔터키 press 여부
        public String poPartID;

        double POPartInputQuantity; //현재 입고수량
        double POPartInputTotalAmount; //현재 입고금액
        double POPartInputMinusQuantity; //현재 미입고수량
        double POPartInputMinusTotalAmount; //현재 미입고 금액

        private void txtBoxInputQuantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            isComplete = false;
            this.ActiveControl.BackColor = Color.Yellow;

            if (e.KeyCode == Keys.Enter)
            {
                flag = true;
                if (btnSave.Text == "수정")
                {                
                }
                else
                {            
                   
                     this.ActiveControl.BackColor = Color.White;

                     int poQuantity = Convert.ToInt16(txtBoxPOQuantity.Text);//PO총수량
                     int inputQuantity = Convert.ToInt16(this.ActiveControl.Text);//입고수량(사용자 조작)
                     double unitPrice = Convert.ToDouble(txtBoxUnitPrice.Text);//단가

                     if (poQuantity == POPartInputMinusQuantity)
                     {
                         if (inputQuantity > poQuantity - POPartInputQuantity)
                         {
                             MessageBox.Show("PO 수량을 초과 했습니다.");
                             
                             return;
                         }
                         txtBoxInputTotalAmount.Text = (inputQuantity * unitPrice).ToString();//총 입고금액
                         if (inputQuantity == poQuantity)
                         {
                             isComplete = true;
                             txtBoxMinusQuantity.Text = txtBoxMinusTotalAmount.Text = "0";
                         }
                         else
                         {
                             txtBoxMinusQuantity.Text = (poQuantity - inputQuantity).ToString();
                             txtBoxMinusTotalAmount.Text = ((poQuantity - inputQuantity) * unitPrice).ToString();
                         }
                     }
                     else
                     {
                         if (inputQuantity > poQuantity - POPartInputQuantity)
                         {
                             MessageBox.Show("PO 수량을 초과 했습니다.");
                             btnSave.Enabled = false;
                             return;
                         }

                        
                         txtBoxInputTotalAmount.Text = (inputQuantity * unitPrice).ToString();//총 입고금액
                                                           
              
                         txtBoxMinusQuantity.Text = (POPartInputMinusQuantity - inputQuantity).ToString();// 미입고 수량
                         if (inputQuantity < 0)
                         {
                             isComplete = false;
                             txtBoxMinusTotalAmount.Text = (POPartInputMinusTotalAmount + ((-inputQuantity) * unitPrice)).ToString();//미입고 금액
                         }
                         else
                         {                             
                             txtBoxMinusTotalAmount.Text = (POPartInputMinusTotalAmount - (inputQuantity * unitPrice)).ToString();//미입고 금액
                         }

                         if (txtBoxMinusQuantity.Text == "0")
                         {
                             isComplete = true;
                         }  
                     }
                    /*
                    int poQuantity = Convert.ToInt16(txtBoxPOQuantity.Text);//PO총수량
                    int inputQuantity = Convert.ToInt16(this.ActiveControl.Text);//입고수량
                    int unitPrice = Convert.ToInt32(txtBoxUnitPrice.Text);//단가
                    int minusQuantity = Convert.ToInt16(txtBoxMinusQuantity.Text);//미입고수량
                                       

                    if (minusQuantity > 0) poQuantity = minusQuantity;

                    if (inputQuantity > poQuantity)
                    {
                        MessageBox.Show("Invaild input");
                        btnSave.Enabled = false;
                        return;
                    }

                    txtBoxInputTotalAmount.Text = (inputQuantity * unitPrice).ToString();
                    if (inputQuantity == poQuantity)
                    {
                        isComplete = true;
                        txtBoxMinusQuantity.Text = txtBoxMinusTotalAmount.Text = "0";
                    }
                    else
                    {
                        txtBoxMinusQuantity.Text = (poQuantity - inputQuantity).ToString();
                        txtBoxMinusTotalAmount.Text = ((poQuantity - inputQuantity) * unitPrice).ToString();
                    }*/                                  
                }
            }         
        }

        private void txtBoxInputQuantity_Leave(object sender, EventArgs e)
        {
            if (flag)
            {               
            }
            else
            {
                MessageBox.Show("엔터키를 눌러 수량을 입력 시키세요");
            }
        }

        private ArrayList GetInit(String query)
        {
            entity = new ArrayList();

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                entity.Add(read[0]);
                entity.Add(read[1]);
                entity.Add(read[2]);
                entity.Add(read[3]);
            }
            read.Close();
            return entity;
        }

        private void txtBoxInputQuantity_MouseDown(object sender, MouseEventArgs e)
        {
            
            flag = false;
            String initializationQuery = "select  POPartInputQuantity, POPartInputTotalAmount," +
                                         "POPartInputMinusQuantity, POPartInputMinusTotalAmount " +
                                         "from [POParts] where [POPartsID] =" + poPartID;

            ArrayList initValue = GetInit(initializationQuery);
            IEnumerator enu = entity.GetEnumerator();
            if (enu.MoveNext())
            {
                POPartInputQuantity = Convert.ToDouble(enu.Current);//현재 입고량
                txtBoxInputQuantity.Text = POPartInputQuantity.ToString();

                if (enu.MoveNext())
                {
                    POPartInputTotalAmount = Convert.ToDouble(enu.Current);//현재 입고금액
                    txtBoxInputTotalAmount.Text = POPartInputTotalAmount.ToString();

                    if (enu.MoveNext())
                    {
                        POPartInputMinusQuantity = Convert.ToDouble(enu.Current);//현재 미입고량
                        txtBoxMinusQuantity.Text = POPartInputMinusQuantity.ToString();

                        if (enu.MoveNext())
                        {
                            POPartInputMinusTotalAmount = Convert.ToDouble(enu.Current);//현재 미입고금액
                            txtBoxMinusTotalAmount.Text = POPartInputMinusTotalAmount.ToString();
                        }
                    }
                }
            }           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtBoxPOQuantity.Text) < Convert.ToInt32(txtBoxInputQuantity.Text) + Convert.ToInt32(txtBoxMinusQuantity.Text))
            {
                MessageBox.Show("입고수량을 확인해 주세요");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
