using System;
using System.Collections.Generic;
using System.Data;

namespace LoadDisplayData.DataSource.Implementations
{
    
    public class DataTableFromCsv :IDataTableFromCSV 
    {
        IDataTableFromCSV _dataTableFromCSV;

        public DataTableFromCsv()
        {
             _dataTableFromCSV = DataSourceFactory.GetReadCsvToDataTableObj();
        }

        public DataTable GetDataTableFromCSV(string dsFilePath)
        {
            return _dataTableFromCSV.GetDataTableFromCSV(dsFilePath);
        }
        
    }

    public class ListItemFromCsv : IListItemFromCSV
    {

        IListItemFromCSV _listItemFromCSV;

        public ListItemFromCsv()
        {
            _listItemFromCSV = DataSourceFactory.GetReadCsvToDataTableObj();
        }

        public List<IdName> GetListItemFromCSV(string dsFilePath)
        {

            return _listItemFromCSV.GetListItemFromCSV(dsFilePath);

        }

        

    }
}
