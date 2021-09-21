
using System.Data;

namespace LoadDisplayData.DataSource.Implementations
{
    public class DataTableFromCsv : DataSourceFactory
    {

        private readonly string _dsFilePath;
        public DataTableFromCsv(string dsFilePath)
        {
            _dsFilePath = dsFilePath;
        }

        protected override DataTable GetDataTable()
        {
            var reader = new ReadCsvToDataTable();
            return reader.ToDataTableFrom(_dsFilePath);
        }

    }
}
