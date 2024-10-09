using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public abstract class Student : Person
    {
        public Student(int age, decimal salary, List<string> addresses) : base(age, salary, addresses)
        {

        }
        public List<string> Courses { get; set; }
        public decimal GPA { get; set; }

        public Dictionary<string, decimal> GradeToCourse { get; set; }

        public abstract decimal CalculateGPA(Dictionary<string, decimal> GradeToCourse);
        public enum Grade
        {
            A, B, C, D, E, F
        }

        public override decimal CalcuateSalary()
        {
            return 0;
        }
    }
}
