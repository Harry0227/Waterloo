using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LoadDisplayData.DataSource
{
    public abstract class DataSourceFactory
    {
        protected abstract DataTable GetDataTable();

        public object GetDatasource(DataTargetType target)
        {
            var dt = GetDataTable();
            var targetDataOutput = null as object;
            switch (target)
            {
                case DataTargetType.DataGrid:
                    targetDataOutput = dt;
                    break;
                case DataTargetType.ComboBox:
                    List<IdName> list = new List<IdName>();
                    for (var i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = Convert.ToInt32(dt.Rows[i].ItemArray[0]);
                        var name = dt.Rows[i].ItemArray[1].ToString();
                        list.Add(new IdName(id, name));
                    }
                    targetDataOutput = list;
                    break;
                default:
                    break;
            }
            return targetDataOutput;
        }
    }
}
