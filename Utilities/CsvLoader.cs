using CsvHelper;
using System.Data;
using System.Globalization;
using System.IO;
namespace EpplusSample.Utilities
{
    public class CsvLoader
    {
        public static DataSet LoadCsv(string path)
        {
            var dataset = new DataSet();
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Do any configuration to `CsvReader` before creating CsvDataReader.
                using (var dr = new CsvDataReader(csv))
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    dataset.Tables.Add(dt);
                    dataset.DataSetName= Path.GetFileNameWithoutExtension(path);
                }
            }
            return dataset;
        }
    }
}
