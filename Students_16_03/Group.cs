using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_16_03
{
    enum Year { First, Second, Third, Fourth, Fifth};
    class Group
    {
        public string Name { get; set; }
        public Year year { get; set; }
        private List<Student> students;
        private List<Subject> subjects;
        public Group()
        {
            Name = "Unknown";
            year = 0;
            students = new List<Student>();
            subjects = new List<Subject>();
        }
        public void AddStudent(Student s)
        {
            students.Add(s);
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        public void AddSubject(Subject s)
        {
            subjects.Add(s);
        }
        public List<Subject> GetSubjects()
        {
            return subjects;
        }
        public void Print()
        {
            Console.WriteLine(Name + " " + year.ToString());
            Console.WriteLine("Subjects: ");
            foreach(Subject s in subjects)
            {
                s.Print();
            }
            Console.WriteLine("Students: ");
            foreach(Student s in students)
            {
                s.Print();
            }
        }
        public void SortByName()
        {
            students.Sort((Student s1, Student s2) =>
            {
                return s1.Surname.CompareTo(s2.Surname);
            });
        }
        public void SortByYear()
        {
            students.Sort((Student s1, Student s2) =>
            {
                return s1.Year.CompareTo(s2.Year);
            });
        }
        public void SortByID()
        {
            students.Sort((Student s1, Student s2) =>
            {
                return s1.Id.CompareTo(s2.Id);
            });
        }
    }
}
