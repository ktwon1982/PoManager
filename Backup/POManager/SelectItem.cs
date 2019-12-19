using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POManager
{
    public partial class SelectItem : Form
    {
        public SelectItem()
        {
            InitializeComponent();
        }

        public void LoadSelectItem(string str, SqlConnection conn)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(str, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dataGridSelect.DataSource = table;

            dataGridSelect.Columns[0].Visible = false;
        }

        private void dataGridSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
