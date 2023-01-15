using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgresTest
{
    internal static class ExcelReporter
    {
        public static void GetReport(DataGridView GridView)
        {
            try
            {
                _Application app = new Microsoft.Office.Interop.Excel.Application();
                _Workbook workbook = app.Workbooks.Add(Type.Missing);
                _Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Лист1"];
                worksheet = workbook.ActiveSheet;
                // Устанавливаем текстовый формат ячеек.
                Range cells = workbook.Worksheets[1].Cells;
                cells.NumberFormat = "@";
                // Вынужденная мера. Удаляем вхождение 0:00:00 в датах, пока не разобрался.
                char[] toTrim = { '0', ':', '0', '0', ':', '0', '0' };

                for (int i = 1; i < GridView.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = GridView.Columns[i - 1].HeaderText;
                    app.ActiveCell.EntireRow.Font.Bold = true;
                }
                for (int i = 0; i < GridView.Rows.Count; i++)// GridView.Rows.Count-1 было неверно.
                {
                    for (int j = 0; j < GridView.Columns.Count; j++)
                    {
                        if (GridView.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = GridView.Rows[i].Cells[j].Value.ToString().Replace("0:00:00", "");
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                app.Columns.AutoFit();
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("Ошибка выгрузки данных. Вероятно в системе не установлен MS Office. \r\n\r\n" + ex.Message,
                                "Ошибка выгрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка выгрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
