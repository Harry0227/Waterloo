using System.Data;
using System.IO;

namespace LoadDisplayData.DataSource
{
    class ReadCsvToDataTable
    {
        public DataTable ToDataTableFrom(string filePath)
        {
            var rows = File.ReadAllLines(filePath);

            var dt = new DataTable();

            if (rows.Length > 0)
            {
                foreach (string columnName in rows[0].Split(','))
                {
                    dt.Columns.Add(columnName);
                }

                //skip the first line which contains column names.
                for (var i = 1; i < rows.Length; i++)
                {
                    var rowValues = rows[i].Split(',');
                    if (!string.IsNullOrEmpty(string.Concat(rowValues)))
                    {
                        var dr = dt.NewRow();
                        dr.ItemArray = rowValues;
                        dt.Rows.Add(dr);
                    }
                }
            }

            return dt;
        }
    }

}
