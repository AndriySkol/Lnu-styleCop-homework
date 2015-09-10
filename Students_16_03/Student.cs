// <copyright file="Student.cs" company="None">
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
    /// represents information about single student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// </summary>
        public Student()
        {
            this.Surname = "Unknown";
            this.Name = string.Empty;
            this.Patronymic = string.Empty;
            this.Id = "0";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// </summary>
        /// <param name="s"> input surname</param>
        /// <param name="n"> input name</param>
        /// <param name="p">input Patronymic</param>
        /// <param name="i">input Id</param>
        /// <param name="y">input year</param>
        /// <param name="g">input group</param>
        public Student(string s, string n, string p, string i, byte y, Group g)
        {
            this.Surname = s;
            this.Name = n;
            this.Patronymic = p;
            this.Id = i;
            this.Year = y;
            this.Group = g;
        }

        /// <summary>
        /// Gets or sets students surname
        /// </summary>
        public string Surname { get; set; }
        
        /// <summary>
        /// Gets or sets students name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets students patronymic
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Gets or sets represents student id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets year of birth
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets student group
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// output to console information about user
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.Name + " " + this.Surname + " " + this.Patronymic + " " + this.Id + " " + this.Year.ToString());
        }
    }
}
