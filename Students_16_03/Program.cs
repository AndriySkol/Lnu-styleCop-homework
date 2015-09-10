// <copyright file="Program.cs" company="None">
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
    /// starting point of the program
    /// </summary>
   public class Program
    {
       /// <summary>
       /// program entry point
       /// </summary>
       /// <param name="args">args of execution</param>
        private static void Main(string[] args)
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
