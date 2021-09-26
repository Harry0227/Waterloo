using System;
using System.Collections.Generic;
using System.Data;

namespace LoadDisplayData.DataSource.Implementations
{
    
    public class DataGridFromCsv : TargetDataFactory
    {
        private readonly string _dsFilePath;

        public DataGridFromCsv(string dsFilePath)
        {
            _dsFilePath = dsFilePath;
        }

        protected override DataTable GetDataTable()
        {
            var reader = new ReadCsvToDataTable();
            return reader.ToDataTableFrom(_dsFilePath);
        }

        public override object GetDataSource()
        {
            var dt = GetDataTable();
                              
            return dt;
        }
    }

    public class DataComboFromCsv : TargetDataFactory
    {

        private readonly string _dsFilePath;

        public DataComboFromCsv(string dsFilePath)
        {
            _dsFilePath = dsFilePath;
        }

        protected override DataTable GetDataTable()
        {
            var reader = new ReadCsvToDataTable();
            return reader.ToDataTableFrom(_dsFilePath);
        }

        public override object GetDataSource()
        {
            var dt = GetDataTable();
                                      
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
