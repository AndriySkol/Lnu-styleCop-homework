using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_16_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader r = new Reader();
            r.Read();
            r.Sort();
            Console.ReadLine();
            Console.ReadLine();
            r.FormDictionary();
            r.FindByKey();
            Console.ReadLine();
        }
    }
}
