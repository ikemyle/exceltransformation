using EpplusSample.Utilities;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpplusSample.UserControls
{
    public partial class FormatExcel : UserControl
    {
        private string binPath = Application.StartupPath;
        public FormatExcel()
        {
            InitializeComponent();
        }

        private void CreateExcel_Click(object sender, EventArgs e)
        {
            var fileSamplePath = $@"{binPath}\ProductList.xlsx";
            var fileSampleFormattedPath = $@"{binPath}\ProductListFormatted.xlsx";
            var excelFile = new FileInfo(fileSamplePath);
            using (var package = new ExcelPackage(excelFile))
            {
                ExcelWorkbook workbook = package.Workbook;
                var spreadSheet = workbook.Worksheets.FirstOrDefault();
                EpPlusHelper.FormattingExamples(spreadSheet);
                var file = new FileInfo(fileSampleFormattedPath);
                package.SaveAs(file);
                Process.Start(new ProcessStartInfo(fileSampleFormattedPath) { UseShellExecute = true });
            }
        }
    }
}
