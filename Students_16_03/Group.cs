// <copyright file="Group.cs" company="None">
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
    /// Represents the year of studying in the university
    /// </summary>
    public enum Year
    {
        /// <summary>
        /// represents first year
        /// </summary>
        First, 

        /// <summary>
        /// represents second year
        /// </summary>
        Second, 

        /// <summary>
        /// represents third year
        /// </summary>
        Third, 

        /// <summary>
        /// represents fourth year
        /// </summary>
        Fourth, 

        /// <summary>
        /// represents fifth year
        /// </summary>
        Fifth
    }

    /// <summary>
    /// represents a Group of students
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Represents the list of students of the Group
        /// </summary>
        private List<Student> students;

        /// <summary>
        /// represents the list of subjects students of the Group are studying
        /// </summary>
        private List<Subject> subjects;

        /// <summary>
        ///  Initializes a new instance of the <see cref="Group"/> class.
        /// </summary>
        public Group()
        {
            this.Name = "Unknown";
            this.Year = 0;
            this.students = new List<Student>();
            this.subjects = new List<Subject>();
        }

        /// <summary>
        /// Gets or sets name of a Group
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the year of starting studying
        /// </summary>
        public Year Year { get; set; }

        /// <summary>
        /// add a student to the Group (inner list of students)
        /// </summary>
        /// <param name="s">
        /// represents student object
        /// </param>
        public void AddStudent(Student s)
        {
            this.students.Add(s);
        }

        /// <summary>
        /// returns the list of students studying in the Group
        /// </summary>
        /// <returns>
        /// List of student objects
        /// </returns>
        public List<Student> GetStudents()
        {
            return this.students;
        }

        /// <summary>
        /// add subjects students of the Group are studying
        /// </summary>
        /// <param name="s">
        /// represents subject object
        /// </param>
        public void AddSubject(Subject s)
        {
            this.subjects.Add(s);
        }

        /// <summary>
        /// return all subjects students of the Group are studying
        /// </summary>
        /// <returns> 
        /// returns list of subject objects
        /// </returns>
        public List<Subject> GetSubjects()
        {
            return this.subjects;
        }

        /// <summary>
        /// shows on console the name of Group, 
        /// list of subjects and list of students
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.Name + " " + this.Year.ToString());
            Console.WriteLine("Subjects: ");
            foreach (Subject s in this.subjects)
            {
                s.Print();
            }

            Console.WriteLine("Students: ");
            foreach (Student s in this.students)
            {
                s.Print();
            }
        }

        /// <summary>
        /// sorts the inner list of students by their names
        /// </summary>
        public void SortByName()
        {
            this.students.Sort((Student s1, Student s2) =>
            {
                return s1.Surname.CompareTo(s2.Surname);
            });
        }

        /// <summary>
        /// sorts the list of students by the year of birth
        /// </summary>
        public void SortByYear()
        {
            this.students.Sort((Student s1, Student s2) =>
            {
                return s1.Year.CompareTo(s2.Year);
            });
        }

        /// <summary>
        /// sorts the list of students by id
        /// </summary>
        public void SortByID()
        {
            this.students.Sort((Student s1, Student s2) =>
            {
                return s1.Id.CompareTo(s2.Id);
            });
        }
    }
}
