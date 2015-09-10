using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_16_03
{
    class Reader
    {
        private List<Group> groups;
        private List<Subject> subjects;
        private Dictionary<string, List<Subject>> students;
        public Reader()
        {
            groups = new List<Group>();
            subjects = new List<Subject>();
            students = new Dictionary<string, List<Subject>>();
        }
        public List<Group> GetGroups()
        {
            return groups;
        }
        public List<Subject> GetSubjects()
        {
            return subjects;
        }
        public void Read()
        {
            System.IO.StreamReader input = new System.IO.StreamReader("Input.txt");
            System.IO.StreamReader sub = new System.IO.StreamReader("Subjects.txt");
            while (!input.EndOfStream)
            {
                Group gr = new Group();
                gr.Name = input.ReadLine();
                gr.year = (Year)int.Parse(input.ReadLine());
                int quantity = int.Parse(input.ReadLine());
                for (int i = 0; i < quantity; i++)
                {
                    Student s = new Student();
                    s.group = gr;
                    string[] line = input.ReadLine().Split(' ');
                    s.Surname = line[0];
                    s.Name = line[1];
                    s.Patronymic = line[2];
                    s.Id = line[3];
                    s.Year = int.Parse(line[4]);
                    gr.AddStudent(s);
                }
                groups.Add(gr);
                input.ReadLine();
            }
            while(!sub.EndOfStream)
            {
                Subject sb = new Subject();
                string[] line = sub.ReadLine().Split(' ');
                sb.Name = line[0];
                sb.Lecturer = line[1];
                int counter = int.Parse(line[2]);
                for (int i = 0; i < counter; i++)
                {
                    foreach(Group gr in groups)
                    {
                        if(gr.Name == line[3+i])
                        {
                            gr.AddSubject(sb);
                            sb.AddGroup(gr);
                        }
                    }
                }
                subjects.Add(sb);
            }
        }
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
                foreach (Group g in groups)
                {
                    g.SortByName();
                }
            }
            if (responce == 'y')
            {
                foreach (Group g in groups)
                {
                    g.SortByYear();
                }
            }
            if (responce == 'i')
            {
                foreach (Group g in groups)
                {
                    g.SortByID();
                }
            }
            foreach(Group g in groups)
            {
                g.Print();
            }
        }
        public void FormDictionary()
        {
            foreach(Group g in groups)
            {
                foreach(Student s in g.GetStudents())
                {
                    students.Add(s.Id, g.GetSubjects());
                }
            }
        }
        public void FindByKey()
        {
            Console.WriteLine("Enter student's ID");
            string key = Console.ReadLine();
            List<Subject> ls = new List<Subject>();
            if(students.TryGetValue(key, out ls))
            {
                Console.WriteLine("ID: " + key);
                Console.WriteLine("SUBJECTS: ");
                foreach(Subject s in ls)
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
