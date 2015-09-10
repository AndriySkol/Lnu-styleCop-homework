// <copyright file="Reader.cs" company="None">
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
    /// provides loading information from txt file
    /// </summary>
    public class Reader
    {
        /// <summary>
        /// inner list of groups
        /// </summary>
        private List<Group> groups;

        /// <summary>
        /// inner list of subjects
        /// </summary>
        private List<Subject> subjects;

        /// <summary>
        /// dictionary that connects student ids and subjects they study
        /// </summary>
        private Dictionary<string, List<Subject>> students;

        /// <summary>
        /// Initializes a new instance of the <see cref="Reader"/> class
        /// </summary>
        public Reader()
        {
            this.groups = new List<Group>();
            this.subjects = new List<Subject>();
            this.students = new Dictionary<string, List<Subject>>();
        }

        /// <summary>
        /// Get groups loaded by reader
        /// </summary>
        /// <returns>list of group objects</returns>
        public List<Group> GetGroups()
        {
            return this.groups;
        }

        /// <summary>
        /// returns subject loaded by reader
        /// </summary>
        /// <returns>list of Subject objects</returns>
        public List<Subject> GetSubjects()
        {
            return this.subjects;
        }

        /// <summary>
        /// command reader to start loading data
        /// </summary>
        public void Read()
        {
            System.IO.StreamReader input = new System.IO.StreamReader("Input.txt");
            System.IO.StreamReader sub = new System.IO.StreamReader("Subjects.txt");
            while (!input.EndOfStream)
            {
                Group gr = new Group();
                gr.Name = input.ReadLine();
                gr.Year = (Year)int.Parse(input.ReadLine());
                int quantity = int.Parse(input.ReadLine());
                for (int i = 0; i < quantity; i++)
                {
                    Student s = new Student();
                    s.Group = gr;
                    string[] line = input.ReadLine().Split(' ');
                    s.Surname = line[0];
                    s.Name = line[1];
                    s.Patronymic = line[2];
                    s.Id = line[3];
                    s.Year = int.Parse(line[4]);
                    gr.AddStudent(s);
                }

                this.groups.Add(gr);
                input.ReadLine();
            }

            while (!sub.EndOfStream)
            {
                Subject sb = new Subject();
                string[] line = sub.ReadLine().Split(' ');
                sb.Name = line[0];
                sb.Lecturer = line[1];
                int counter = int.Parse(line[2]);
                for (int i = 0; i < counter; i++)
                {
                    foreach (Group gr in this.groups)
                    {
                        if (gr.Name == line[3 + i])
                        {
                            gr.AddSubject(sb);
                            sb.AddGroup(gr);
                        }
                    }
                }

                this.subjects.Add(sb);
            }
        }

        /// <summary>
        /// command reader to ask user to enter the information about the 
        /// preferred sorting criteria and sort data
        /// </summary>
        public void Sort()
        {
            char responce;
            Console.WriteLine("Press s to sort by surname");
            Console.WriteLine("Press y to sort by year");
            Console.WriteLine("Press i to sort by id");
            responce = (char)Console.Read();
            while (responce != 's' && responce != 'y' && responce != 'i')
            {
                Console.WriteLine("Bad responce, try again");
                responce = (char)Console.Read();
            }

            if (responce == 's')
            {
                foreach (Group g in this.groups)
                {
                    g.SortByName();
                }
            }

            if (responce == 'y')
            {
                foreach (Group g in this.groups)
                {
                    g.SortByYear();
                }
            }

            if (responce == 'i')
            {
                foreach (Group g in this.groups)
                {
                    g.SortByID();
                }
            }

            foreach (Group g in this.groups)
            {
                g.Print();
            }
        }

        /// <summary>
        /// command reader to fill dictionary with data
        /// </summary>
        public void FormDictionary()
        {
            foreach (Group g in this.groups)
            {
                foreach (Student s in g.GetStudents())
                {
                    this.students.Add(s.Id, g.GetSubjects());
                }
            }
        }
        
        /// <summary>
        /// command reader to ask user to input student id
        /// use it to find his subjects and output info to console
        /// </summary>
        public void FindByKey()
        {
            Console.WriteLine("Enter student's ID");
            string key = Console.ReadLine();
            List<Subject> ls = new List<Subject>();
            if (this.students.TryGetValue(key, out ls))
            {
                Console.WriteLine("ID: " + key);
                Console.WriteLine("SUBJECTS: ");
                foreach (Subject s in ls)
                {
                    s.Print();
                }
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
    }
}
