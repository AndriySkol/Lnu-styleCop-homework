// <copyright file="Subject.cs" company="None">
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
    /// represents information about single object
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// represents list of groups
        /// </summary>
        private List<Group> groups;

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class
        /// </summary>
        public Subject()
        {
            this.Name = "Unknown";
            this.Lecturer = "Unknown_Lecturer";
            this.groups = new List<Group>();
        }

        /// <summary>
        /// /// Initializes a new instance of the <see cref="Subject"/> class
        /// </summary>
        /// <param name="n"> represents name</param>
        /// <param name="l">represents lecturer name</param>
        public Subject(string n, string l)
        {
            this.Name = n;
            this.Lecturer = l;
            this.groups = new List<Group>();
        }

        /// <summary>
        /// Gets or sets subject name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets subject lecturer
        /// </summary>
        public string Lecturer { get; set; }

        /// <summary>
        /// add group that studies subject
        /// </summary>
        /// <param name="g">group info object</param>
        public void AddGroup(Group g)
        {
            this.groups.Add(g);
        }

        /// <summary>
        /// output to console info about subject
        /// </summary>
        public void Print()
        {
            Console.WriteLine(this.Name + " " + this.Lecturer);
        }
    }
}
