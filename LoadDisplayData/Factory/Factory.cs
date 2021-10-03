using LoadDisplayData.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDisplayData.Factory
{
    public static class Factory
    {
        public static IDataSource CreateDataTableDataSource()
        {
            return new DataTableDataSource();
        }

        public static IDataSource CreateListItemDataSource()
        {
            return new ListItemDataSource();
        }
    }
}
