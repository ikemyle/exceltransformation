using DocumentFormat.OpenXml.Spreadsheet;
using EpplusSample.Models;
using EpplusSample.Utilities;
using OfficeOpenXml;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EpplusSample.UserControls
{
    public partial class ExcelExporter : UserControl
    {
        private MapColumnCollection mapColumns = new MapColumnCollection();
        private string binPath = Application.StartupPath;
        private DataFiles files = new DataFiles();
        private DataSet dsOrders = new DataSet();
        private string selectedItem;

        public ExcelExporter()
        {
            InitializeComponent();
        }

        private void dungeonComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedItem = dungeonComboBox1.SelectedItem.ToString();
            if (selectedItem == "select a db object")
                return;

            var fileName= files.FileName(selectedItem);
            dsOrders = CsvLoader.LoadCsv($@"{binPath}\{fileName}");
            dsOrders.DataSetName = fileName.Substring(0, fileName.LastIndexOf('.'));
            poisonDataGridView1.DataSource = dsOrders.Tables[0];
        }

        private void CreateExcel_Click(object sender, EventArgs e)
        {
            try
            {
                bool withFormat = this.chkUseFormatting.Checked;
                bool autoFitColumns = this.chkAutoFit.Checked;

                var filePath = $@"{binPath}\{selectedItem}_output.xlsx";
                var rowCount = dsOrders.Tables[0].Rows.Count;
                using (var package = new ExcelPackage())
                {
                    // Add a new worksheet to the Excel package
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(selectedItem);

                    //load simulated data from a csv file
                    EpPlusHelper.LoadExcelFromDatasetWithMapping(worksheet, dsOrders, binPath, withFormat, autoFitColumns);

                    // Save the Excel package to a file
                    var file = new FileInfo(filePath);
                    package.SaveAs(file);
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
