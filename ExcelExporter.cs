using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml.Drawing.Chart;

namespace Ayo_Laurence_Act7_EDP
{
    public static class ExcelExporter
    {
        public static void ExportToExcel(DataTable dataTable, string worksheetName = "Report")
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save Excel File";
                    saveFileDialog.FileName = "StudentReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo file = new FileInfo(saveFileDialog.FileName);

                        using (ExcelPackage excelPackage = new ExcelPackage(file))
                        {
                            // Create worksheet
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(worksheetName);

                            // Load data
                            worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                            // Format header
                            using (var headerRange = worksheet.Cells[1, 1, 1, dataTable.Columns.Count])
                            {
                                headerRange.Style.Font.Bold = true;
                                headerRange.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                headerRange.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                            }

                            // Auto-fit columns
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            // Add chart (example with age distribution)
                            if (dataTable.Columns.Contains("Age"))
                            {
                                var chart = worksheet.Drawings.AddChart("AgeChart", eChartType.ColumnClustered);
                                chart.Title.Text = "Age Distribution";

                                // Set chart position (row, rowOffsetPixels, column, columnOffsetPixels)
                                chart.SetPosition(3, 0, dataTable.Columns.Count + 2, 0);
                                chart.SetSize(600, 400);

                                // Add series
                                var rangeLabel = worksheet.Cells[2, 1, dataTable.Rows.Count + 1, 1];
                                var rangeValue = worksheet.Cells[2, dataTable.Columns.IndexOf("Age") + 1,
                                                       dataTable.Rows.Count + 1, dataTable.Columns.IndexOf("Age") + 1];

                                var series = chart.Series.Add(rangeValue, rangeLabel);
                                series.Header = "Age";
                            }

                            excelPackage.Save();
                        }

                        MessageBox.Show("Excel report generated successfully!", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Excel report: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}