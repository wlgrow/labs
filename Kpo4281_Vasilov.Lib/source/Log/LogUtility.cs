using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kpo4281.Vasilov.Lib
{
    public static class LogUtility
    {
        public static void ErrorLog(string message)
        {
            File.AppendAllText("error.log", message);
        }
    }
}
