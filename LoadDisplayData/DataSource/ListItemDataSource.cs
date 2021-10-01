using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadDisplayData.DataSource
{
    public class ListItemDataSource : IDataSource
    {
        public object GetDataSource(string filePath)
        {
            var dt = DataTableFromCSV.GetDataTableFromCSV(filePath);

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
