using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace LoadDisplayData.DataSource
{
    public class SourceItemFromCSV : IDataTableFromCSV,IListItemFromCSV
    {
        public SourceItemFromCSV()
        {

        }

        public DataTable GetDataTableFromCSV(string filePath)
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

        public List<IdName> GetListItemFromCSV(string filePath)
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

           
            List<IdName> list = new List<IdName>();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                var id = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                var name = dt.Rows[i].ItemArray[1].ToString();
                list.Add(new IdName(id, name));
            }

            return list;
           
        }
    }

}
