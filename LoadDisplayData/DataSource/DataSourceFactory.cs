using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LoadDisplayData.DataSource
{
   
    public  class DataSourceFactory
    {
             
        public static SourceItemFromCSV GetReadCsvToDataTableObj()
        {
            
            return new SourceItemFromCSV();
        }
        
    }
    
}

