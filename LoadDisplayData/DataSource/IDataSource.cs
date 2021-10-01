using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDisplayData.DataSource
{
    public interface IDataSource
    {
        object GetDataSource(string filePath);
    }
}
