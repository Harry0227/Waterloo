using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LoadDisplayData
{
    class ResourceManager
    {

        /// <summary>
        /// Read the resource file and return the string of specified culture
        /// </summary>
        /// <param name="data">String Data to be read</param>
        /// <param name="cultureInfo">Type of Culture</param>
        /// <returns></returns>
        public static string GetString(string data, CultureInfo cultureInfo)
        {
            return Resources.CommonResource.ResourceManager.GetString(data, cultureInfo);
        }

    }
}
