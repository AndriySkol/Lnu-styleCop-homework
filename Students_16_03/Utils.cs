using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_16_03
{
    class Utils
    {
        public const string intaction = "Enter int";
        public const string boolaction = "Enter bool";
        public const string doubleaction = "Enter double";
        public const string charaction = "Enter char";
        public const string stringaction = "Enter string";
        public const string error = "Error";
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
        public static int ReadInt(string msg = intaction)
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
        public static int ReadInt(string msg = intaction, string error = error)
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
        public static bool ReadBool(string msg = boolaction)
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
        public static bool ReadBool(string msg = boolaction, string error = error)
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
        public static double ReadDouble(string msg = doubleaction)
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
        public static double ReadDouble(string msg = doubleaction, string error = error)
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
        public static char ReadChar(string msg = charaction)
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
        public static double ReadChar(string msg = charaction, string error = error)
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
