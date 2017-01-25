using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kpo4281.Utility
{
    public class AppConfigUtility
    {
        public string AppSettings(string name)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[name] ?? "Not Found";
            return result;

        }
        
    }
}
