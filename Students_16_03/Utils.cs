// <copyright file="Utils.cs" company="None">
//     Company copyright tag.
// </copyright>

namespace Students_16_03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// represents an set of useful methods for parameters input
    /// from console and their automatic validation
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// represents output text to ask user to enter integer
        /// </summary>
        public const string IntAction = "Enter int";

        /// <summary>
        /// represents output text to ask user to enter boolean
        /// </summary>
        public const string BoolAction = "Enter bool";

        /// <summary>
        /// represents output text to ask user to enter double
        /// </summary>
        public const string DoubleAction = "Enter double";

        /// <summary>
        /// represents output text to ask user to enter char
        /// </summary>
        public const string CharAction = "Enter char";

        /// <summary>
        /// represents output text to ask user to enter string
        /// </summary>
        public const string StringAction = "Enter string";

        /// <summary>
        /// represents output text to inform user about error
        /// </summary>
        public const string Error = "Error";

        /// <summary>
        /// ask user to input integer validate it and return
        /// </summary>
        /// <returns>integer value</returns>
        public static int ReadInt()
        {
            int a;
            Console.WriteLine("Enter int value");
            string read = Console.ReadLine();
            bool good = int.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = int.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        /// ask user to input integer validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <returns>integer value</returns>
        public static int ReadInt(string msg = IntAction)
        {
            int a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = int.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = int.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input integer validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <param name="error">message to inform user about error</param>
        /// <returns>returns integer</returns>
        public static int ReadInt(string msg = IntAction, string error = Error)
        {
            int a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = int.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine(error);
                read = Console.ReadLine();
                good = int.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input boolean validate it and return
        /// </summary>
        /// <returns>boolean value</returns>
        public static bool ReadBool()
        {
            bool a;
            Console.WriteLine("Enter bool value");
            string read = Console.ReadLine();
            bool good = bool.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = bool.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input boolean validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <returns>boolean value</returns>
        public static bool ReadBool(string msg = BoolAction)
        {
            bool a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = bool.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = bool.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input boolean validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <param name="error">message to inform user about error</param>
        /// <returns>boolean value</returns>
        public static bool ReadBool(string msg = BoolAction, string error = Error)
        {
            bool a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = bool.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine(error);
                read = Console.ReadLine();
                good = bool.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        /// ask user to input double validate it and return
        /// </summary>
        /// <returns>double value</returns>
        public static double ReadDouble()
        {
            double a;
            Console.WriteLine("Enter double value");
            string read = Console.ReadLine();
            bool good = double.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = double.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input double validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <returns>double value</returns>
        public static double ReadDouble(string msg = DoubleAction)
        {
            double a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = double.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = double.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input double validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <param name="error">message to inform user about error</param>
        /// <returns>double value</returns>
        public static double ReadDouble(string msg = DoubleAction, string error = Error)
        {
            double a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = double.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine(error);
                read = Console.ReadLine();
                good = double.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        /// ask user to input char validate it and return
        /// </summary>
        /// <returns>char value</returns>
        public static char ReadChar()
        {
            char a;
            Console.WriteLine("Enter char value");
            string read = Console.ReadLine();
            bool good = char.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = char.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input char validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <returns>char value</returns>
        public static char ReadChar(string msg = CharAction)
        {
            char a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = char.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine("Invalid value, enter again");
                read = Console.ReadLine();
                good = char.TryParse(read, out a);
            }

            return a;
        }

        /// <summary>
        ///  ask user to input char validate it and return
        /// </summary>
        /// <param name="msg">message that will ask user to input data</param>
        /// <param name="error">message to inform user about error</param>
        /// <returns>char value</returns>
        public static double ReadChar(string msg = CharAction, string error = Error)
        {
            char a;
            Console.WriteLine(msg);
            string read = Console.ReadLine();
            bool good = char.TryParse(read, out a);
            while (!good)
            {
                Console.WriteLine(error);
                read = Console.ReadLine();
                good = char.TryParse(read, out a);
            }

            return a;
        }
    }
}
