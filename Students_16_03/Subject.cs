using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_16_03
{
    class Subject
    {
        public string Name { get; set; }
        public string Lecturer { get; set; }
        private List<Group> groups;
        public Subject()
        {
            Name = "Unknown";
            Lecturer = "Unknown_Lecturer";
            groups = new List<Group>();
        }
        public Subject(string n, string l)
        {
            Name = n;
            Lecturer = l;
            groups = new List<Group>();
        }
        public void AddGroup(Group g)
        {
            groups.Add(g);
        }
        public void Print()
        {
            Console.WriteLine(Name + " " + Lecturer);
        }
    }
}
