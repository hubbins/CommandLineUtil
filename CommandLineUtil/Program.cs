using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usage: CommandLineHack /int:intvalue /string:stringvalue  (parameters are optional)");

            int intValue = CommandLineUtil.Param("int", 10, args);
            string stringValue = CommandLineUtil.Param("string", "test", args);
            Console.WriteLine(intValue + " " + stringValue);
        }
    }
}
