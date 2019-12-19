using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;


namespace POManager
{
    public partial class Login : Form
    {
        private DBCtrl dbCtrl;       

        public Login(DBCtrl dbc)
        {
            InitializeComponent();
            dbCtrl = dbc;
            RegistryKey reg;
            reg = Registry.LocalMachine.CreateSubKey("Software\\AsTEK\\Pomanager");

            textBox_server.Text = reg.GetValue("SERVER", "").ToString();
            textBox_ID.Text = reg.GetValue("ID", "").ToString();
            reg.Close();
            //textBox_server.Text = "localhost\\SQLEXPRESS";
        }

        private void checkBox_window_Click(object sender, EventArgs e)
        {
            if (checkBox_window.Checked)
            {
                //textBox_server.Text = "localhost\\SQLEXPRESS";
                textBox_server.Enabled = false;
                textBox_ID.Enabled = false;
                textBox_pwd.Enabled = false;
            }
            else
            {
                textBox_server.Enabled = true;
                textBox_ID.Enabled = true;
                textBox_pwd.Enabled = true;
            }
        }          

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (cbBoxSelectCompany.Text == "")
            {
                MessageBox.Show("회사를 선택해 주세요");
            }
            else
            {
                try
                {
                    if (checkBox_window.Checked)
                    {
                        dbCtrl.DBConnect(cbBoxSelectCompany.Text);
                    }
                    else
                    {
                        dbCtrl.DBConnect(textBox_server.Text, textBox_ID.Text, textBox_pwd.Text, cbBoxSelectCompany.Text);
                        RegistryKey reg;
                        reg = Registry.LocalMachine.CreateSubKey("Software\\AsTEK\\Pomanager");
                        reg.SetValue("SERVER", textBox_server.Text);
                        reg.SetValue("ID", textBox_ID.Text);
                        reg.Close();
                    }
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("아이디와 비밀번호를 확인해 주세요!");
                }
            }
        }

        private void textBox_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_login_Click_1(sender, e);
        }

        public string GetCompanyName()
        {
            return cbBoxSelectCompany.Text;
        }
    }
}
