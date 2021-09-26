using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LoadDisplayData.DataSource
{
   
    public abstract class TargetDataFactory
    {
        protected abstract DataTable GetDataTable();
        
        public virtual object GetDataSource()
        {
            var dt = GetDataTable();
            return dt;
        }
        
    }
    
}

