using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_16_03
{
    class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Id { get; set; }
        public int Year { get; set; }
        public Group group { get; set; }
        public Student()
        {
            Surname = "Unknown";
            Name = "";
            Patronymic = "";
            Id = "0";
        }
        public Student(string s, string n, string p, string i, byte y, Group g)
        {
            Surname = s;
            Name = n;
            Patronymic = p;
            Id = i;
            Year = y;
            group = g;
        }
        public void Print()
        {
            Console.WriteLine(Name + " " + Surname + " " + Patronymic + " " + Id + " " + Year.ToString());
        }
    }
}
