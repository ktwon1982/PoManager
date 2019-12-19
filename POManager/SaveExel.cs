using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;

namespace POManager
{
    public class SaveExel
    {
        SaveFileDialog saveFileDialog;
        SaveFileDialog saveFileDialog1;

        public SaveExel(string name, DataGridView datagridname)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = name;
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "xls";
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls";
            saveFileDialog1.InitialDirectory = "c:\\";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                int num = 0;
                object missingType = Type.Missing;

                Excel.Application objApp;
                Excel._Workbook objBook;
                Excel.Workbooks objBooks;
                Excel.Sheets objSheets;
                Excel._Worksheet objSheet;
                Excel.Range range;

                string[] headers = new string[datagridname.ColumnCount];
                string[] columns = new string[datagridname.ColumnCount];

                for (int c = 0; c < datagridname.ColumnCount; c++)
                {
                    headers[c] = datagridname.Rows[0].Cells[c].OwningColumn.HeaderText.ToString();
                    num = c + 65;
                    columns[c] = Convert.ToString((char)num);
                }

                try
                {
                    objApp = new Excel.Application();
                    objBooks = objApp.Workbooks;
                    objBook = objBooks.Add(Missing.Value);
                    objSheets = objBook.Worksheets;
                    objSheet = (Excel._Worksheet)objSheets.get_Item(1);

                    if (true)
                    {
                        for (int c = 0; c < datagridname.ColumnCount; c++)
                        {
                            range = objSheet.get_Range(columns[c] + "1", Missing.Value);
                            range.set_Value(Missing.Value, headers[c]);
                        }
                    }

                    for (int i = 0; i < datagridname.RowCount; i++)
                    {
                        for (int j = 0; j < datagridname.ColumnCount; j++)
                        {
                            range = objSheet.get_Range(columns[j] + Convert.ToString(i + 2),
                                                                   Missing.Value);
                            range.set_Value(Missing.Value,
                                                  datagridname.Rows[i].Cells[j].Value.ToString());
                        }
                    }

                    objApp.Visible = false;
                    objApp.UserControl = false;

                    objBook.SaveAs(@saveFileDialog.FileName,
                              Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
                              missingType, missingType, missingType, missingType,
                              Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                              missingType, missingType, missingType, missingType, missingType);
                    objBook.Close(false, missingType, missingType);

                    Cursor.Current = Cursors.Default;

                    MessageBox.Show("Save Success!!!");
                }
                catch (Exception theException)
                {
                    String errorMessage;
                    errorMessage = "Error: ";
                    errorMessage = String.Concat(errorMessage, theException.Message);
                    errorMessage = String.Concat(errorMessage, " Line: ");
                    errorMessage = String.Concat(errorMessage, theException.Source);

                    MessageBox.Show(errorMessage, "Error");
                }
            }
        }
    }
}