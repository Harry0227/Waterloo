using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDisplayData.DataSource
{
    public class DataTableDataSource : IDataSource
    {
                
        public object GetDataSource(string filePath)
        {
            return DataTableFromCSV.GetDataTableFromCSV(filePath);
        }
    }
}
