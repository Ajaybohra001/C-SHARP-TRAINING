using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceCSharp
{
    class Class1
    {
        public enum LogTypes
        {
            Error,
            Warning=212,
            Fatal='d',
            Information
        }
        public  void WriteLog(string logMessage, LogTypes logTypes)
        {
            switch (logTypes)
            {
                case LogTypes.Fatal:
                    Console.WriteLine("Write fatal log");
                    break;
                case LogTypes.Error:
                    Console.WriteLine("Write error log ");
                    break;

            }

        }
    }
}
