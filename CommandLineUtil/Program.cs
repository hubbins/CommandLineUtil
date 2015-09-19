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
            if (CommandLineUtil.Param("?", args))
            {
                Console.WriteLine("Usage: CommandLineUtil /int:intvalue /string:stringvalue  (parameters are optional)");
                return;
            }

            int intValue = CommandLineUtil.Param("int", 10, args);
            string stringValue = CommandLineUtil.Param("string", "test", args);
            Console.WriteLine(intValue + " " + stringValue);
        }
    }
}
