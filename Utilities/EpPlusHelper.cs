using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.Spreadsheet;
using EpplusSample.Models;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using OfficeOpenXml.FormulaParsing.Utilities;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpplusSample.Utilities
{
    public class EpPlusHelper
    {
        private static MapColumnCollection mapColumns = new MapColumnCollection();

        public static void LoadExcelFromDatasetWithMapping(ExcelWorksheet ws, DataSet ds, string mapPath, bool withFormat, bool autoFit)
        {
            try
            {
                if (ws == null || ds == null)
                {
                    throw new ArgumentException("Worksheet or the dataset are invalid");
                }
                var dbTable = ds.Tables[0];
                var mapRules = mapColumns.GetRulesFromFile(mapPath, ds.DataSetName);
                for (var i = 0; i < dbTable.Columns.Count; i++)
                {
                    var dbKey = dbTable.Columns[i].ColumnName;
                    var keyFinder = mapRules.MapRules.FirstOrDefault(r => r.DbName == dbKey);
                    ws.Cells[1, i + 1].Value = keyFinder != null ? keyFinder.DisplayName : dbKey;
                    ws.Cells[1, i + 1].Style.Font.Bold = true;
                }

                for (var row = 1; row < dbTable.Rows.Count; row++)
                {
                    for (var col = 0; col < dbTable.Columns.Count; col++)
                    {
                        var dbKey = dbTable.Columns[col].ColumnName;
                        var keyFinder = mapRules.MapRules.FirstOrDefault(r => r.DbName == dbKey);
                        //populate as it is when column map is missing or data type is a string

                        if (keyFinder == null || keyFinder.DataType == "string")
                        {
                            ws.Cells[row + 1, col + 1].Value = dbTable.Rows[row][col].ToString();
                        }
                        else
                        {
                            switch (keyFinder.DataType)
                            {
                                case "int":
                                    int colOutputInt = 0;
                                    if (int.TryParse(dbTable.Rows[row][col].ToString(), out colOutputInt))
                                        ws.Cells[row + 1, col + 1].Value = colOutputInt;
                                    break;
                                case "decimal":
                                    decimal colOutput = 0;
                                    if (decimal.TryParse(dbTable.Rows[row][col].ToString(), out colOutput))
                                        ws.Cells[row + 1, col + 1].Value = colOutput;
                                    break;
                                case "date":
                                case "datetime":
                                    DateTime colOutputDateTime;
                                    if (DateTime.TryParse(dbTable.Rows[row][col].ToString(), out colOutputDateTime))
                                        ws.SetValue(row + 1, col + 1, colOutputDateTime);
                                    ws.Cells[row + 1, col + 1].Style.Numberformat.Format = keyFinder.Format;
                                    break;

                            }
                        }
                        if (withFormat)
                            FormatReturn(keyFinder, dbTable.Rows[row][col], ws.Cells[row + 1, col + 1], dbTable.Rows[row]);
                    }
                }
                if (autoFit)
                    ws.Cells.AutoFitColumns();
            }
            catch
            {
                throw;
            }
        }
        public static void FormattingExamples(ExcelWorksheet ws)
        {
            //Formatting header
            // Select only the header cells
            var headerCells = ws.Cells[1, 1, 1, ws.Dimension.Columns];
            // Set their text to bold, italic and underline.
            headerCells.Style.Font.Bold = true;
            headerCells.Style.Font.Italic = true;
            headerCells.Style.Font.UnderLine = true;
            headerCells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;

            // Set their foreground color (text color) to White.
            headerCells.Style.Font.Color.SetColor(System.Drawing.Color.White);


            // Set their background color to DarkOrange.
            headerCells.Style.Fill.PatternType = ExcelFillStyle.Solid;
            headerCells.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkOrange);

            //Formatting rows
            for (var row = 2; row <= ws.Dimension.End.Row; row++)
            {
                if (ws.Cells[row, 15].Value.ToString() == "1")
                {
                    ws.Row(row).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    ws.Row(row).Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Red);
                    ws.Row(row).Style.Font.Color.SetColor(System.Drawing.Color.White);
                }
                else
                {
                    // Apply a striping effect to all rows by alternating white & gray background color
                    if (row % 2 != 0)
                    {
                        ws.Row(row).Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        ws.Row(row).Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }
                }
                //add formula
                ws.Cells[row, 16].Formula = $"=L{row}*K{row}";
                ////number with 2 decimal places
                ws.Cells[row, 16].Style.Numberformat.Format = "0.00";


                var idCol = ws.SelectedRange[row, 1];
                var prodCol = ws.SelectedRange[row, 2];
                //how to set range value
                idCol.AddComment($"This is product {prodCol.Value.ToString()}", "Mihail");

            }
            ////number with 2 decimal places and thousand separator and money symbol
            ws.Cells[2, 11, 6, 11].Style.Numberformat.Format = "€#,##0.00";
            ws.Cells[7, 11, ws.Dimension.End.Row, 11].Style.Numberformat.Format = "$#,##0.00";

            //sum formula
            var cellSum = ws.Cells[ws.Dimension.End.Row + 1, 16, ws.Dimension.End.Row + 1, 16];
            cellSum.Formula = $"=SUM(P2:P{ws.Dimension.End.Row})";
            cellSum.Style.Font.Bold = true;
            cellSum.Style.Font.Size = 12;
            cellSum.Style.Numberformat.Format = "$#,##0.00";

            //Formatting columns
            var col4 = ws.Cells[2, 6, ws.Dimension.End.Row, 6];
            col4.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            col4.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            col4.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.RosyBrown);

            var col3 = ws.Cells[2, 3, 6, 3];
            col3.Style.Numberformat.Format = "MM-ddd-YYYY";
            col3.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            col3.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            col3.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Beige);

            var col13 = ws.Cells[2, 13, ws.Dimension.End.Row, 13];
            col13.Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
            col13.Style.Font.Bold = true;


            //Formattings cells
            //one cell
            var cell = ws.Cells["E5:E5"];
            cell.Style.Font.Bold = true;
            cell.Style.Font.Color.SetColor(System.Drawing.Color.Blue);

            //two cells
            var twoCells = ws.Cells["E6:E7"];
            twoCells.Style.Font.Bold = true;
            twoCells.Style.Font.Color.SetColor(System.Drawing.Color.Purple);

            ws.View.FreezePanes(1, 3);
            //format freeze column color
            for (var i = 1; i < 3; i++)
            {
                ws.Column(i).Style.Fill.PatternType = ExcelFillStyle.Solid;
                ws.Column(i).Style.Fill.BackgroundColor.SetColor(ColorTranslator.FromHtml("#FF00CC"));
            }


            //autofit all
            ws.Cells.AutoFitColumns();

            ////integer (not really needed unless you need to round numbers, Excel will use default cell properties)
            //ws.Cells["B2:B3"].Style.Numberformat.Format = "0";

            ////integer without displaying the number 0 in the cell
            //ws.Cells["B3:B4"].Style.Numberformat.Format = "#";

            ////number with 1 decimal place
            //ws.Cells["B4:B5"].Style.Numberformat.Format = "0.0";

            ////number with 2 decimal places
            //ws.Cells["B5:B6"].Style.Numberformat.Format = "0.00";

            ////number with 2 decimal places and thousand separator
            //ws.Cells["B6:B7"].Style.Numberformat.Format = "#,##0.00";

            ////number with 2 decimal places and thousand separator and money symbol
            //ws.Cells["B7:B8"].Style.Numberformat.Format = "€#,##0.00";

            ////percentage (1 = 100%, 0.01 = 1%)
            //ws.Cells["B8:B9"].Style.Numberformat.Format = "0%";

            ////accounting number format
            //ws.Cells["B9:B10"].Style.Numberformat.Format = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \"-\"??_-;_-@_-";
        }

        #region Privates
        private static void FormatReturn(Maprule keyFinder, object value, ExcelRange cells, DataRow dr)
        {
            var origValue = value;
            if (keyFinder.Rules.Length == 0) return;
            foreach (var rule in keyFinder.Rules)
            {
                if (keyFinder.DbName != rule.Val)
                {
                    value = dr[rule.Val];
                }


                switch (rule.Operand)
                {
                    case "EQ":
                        if (rule.Compare == value.ToString())
                        {
                            if (rule.Action.Backgorund != null)
                            {
                                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                                cells.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromName(rule.Action.Backgorund));
                            }
                        }
                        break;
                    case "LT":
                    case "GT":
                        switch (keyFinder.DataType)
                        {
                            case "date":
                            case "datetime":
                                DateTime dt;
                                if (DateTime.TryParse(value.ToString(), out dt))
                                {
                                    if (rule.AddToValue != null)
                                    {
                                        int addVal;
                                        if (int.TryParse(rule.AddToValue, out addVal))
                                        {
                                            switch (rule.Unit)
                                            {
                                                case "d":
                                                    dt = dt.AddDays(addVal);
                                                    break;
                                                case "M":
                                                    dt = dt.AddMonths(addVal);
                                                    break;
                                                case "y":
                                                    dt = dt.AddYears(addVal);
                                                    break;
                                            }
                                            DateTime compareDate = DateTime.Today;
                                            if (rule.Compare == null)
                                            {
                                                DateTime.TryParse(origValue.ToString(), out compareDate);
                                            }
                                            bool ruleCompare = false;
                                            if (rule.Operand == "LT")
                                            {
                                                ruleCompare = compareDate < dt;
                                            }
                                            else
                                            {
                                                ruleCompare = compareDate > dt;
                                            }
                                            if (ruleCompare)
                                            {
                                                RuleCompare(cells, rule);
                                            }
                                        }
                                    }
                                }
                                break;
                            case "decimal":
                                decimal dec;
                                if (decimal.TryParse(value.ToString(), out dec))
                                {
                                    bool ruleCompare = false;
                                    if (rule.Operand == "LT")
                                    {
                                        ruleCompare = dec < decimal.Parse(rule.Compare);
                                    }
                                    else
                                    {
                                        ruleCompare = dec > decimal.Parse(rule.Compare);
                                    }
                                    if (ruleCompare)
                                    {
                                        RuleCompare(cells, rule);
                                    }
                                }
                                break;
                        }
                        break;
                }

            }
        }

        private static void RuleCompare(ExcelRange cells, Models.Rule rule)
        {
            if (rule.Action.Backgorund != null)
            {
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromName(rule.Action.Backgorund));
            }
            if (rule.Action.ForeColor != null)
            {
                cells.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cells.Style.Font.Color.SetColor(System.Drawing.Color.FromName(rule.Action.ForeColor));
            }
        }
        #endregion
    }
}
