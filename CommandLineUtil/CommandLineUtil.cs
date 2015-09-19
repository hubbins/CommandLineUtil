using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineUtil
{
    /// <summary>
    /// Command line utilities
    /// </summary>
    public static class CommandLineUtil
    {
        /// <summary>
        /// Get a string parameter from the command line, uses the format /name:value
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="defaultValue">Default value if parameter not specified</param>
        /// <param name="args">Command line args from Main()</param>
        /// <returns>Parameter value or default</returns>
        public static string Param(string name, string defaultValue, string[] args)
        {
            string retval = defaultValue;

            foreach (string arg in args)
            {
                if (arg.ToLower().StartsWith("/" + name.ToLower() + ":"))
                {
                    string[] tokens = arg.Split(new char[] { ':' });
                    if (tokens.Length == 2)
                        retval = tokens[1];

                    break;
                }
            }

            return retval;
        }

        /// <summary>
        /// Get an int parameter from the command line, uses the format /name:value
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="defaultValue">Default value if parameter not specified</param>
        /// <param name="args">Command line args from Main()</param>
        /// <returns>Parameter value or default</returns>
        public static int Param(string name, int defaultValue, string[] args)
        {
            int retval = defaultValue;

            foreach (string arg in args)
            {
                if (arg.ToLower().StartsWith("/" + name.ToLower() + ":"))
                {
                    string[] tokens = arg.Split(new char[] { ':' });
                    if (tokens.Length == 2)
                        int.TryParse(tokens[1], out retval);

                    break;
                }
            }

            return retval;
        }
    }
}
