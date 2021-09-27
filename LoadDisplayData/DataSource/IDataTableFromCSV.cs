using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDisplayData.DataSource
{
    public interface IDataTableFromCSV
    {
        DataTable GetDataTableFromCSV(string filePath);
    }
}
