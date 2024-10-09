using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    internal class Department
    {
        public Department()
        {

        }

        public Instrctor Instructor { get; set; }

        public double Budget { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public List<Course> Courses { get; set; }

    }
}
