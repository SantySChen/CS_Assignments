using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public abstract class Instrctor : Person
    {
        public Instrctor(int age, decimal salary, List<string> addresses) : base(age, salary, addresses)
        {

        }

        private string department;
        public string Department
        {
            get
            {
                return department;
            }
            private set
            {
                department = value;
            }
        }
        public DateTime JoinDate { get; set; }
        public bool IsHeadOfDepartment { get; set; }

        public abstract decimal SalaryBonus(DateTime joinDate);

        public override decimal CalcuateSalary()
        {
            return 0;
        }

    }
}
