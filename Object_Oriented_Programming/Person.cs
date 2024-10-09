using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public abstract class Person
    {
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            }
        }
        private decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;  
            }
            private set
            {
                salary = value;
            }
        }
        private List<string> addresses;
        public List<string> AddressList
        {
            get
            {
                return addresses;
            }
            private set
            {
                addresses = value;
            }
        }

        public Person(int age, decimal salary, List<string> addresses)
        {

        }

        public abstract int CalcuateAge();

        public virtual decimal CalcuateSalary()
        {
            return 0;
        }


       
    }
}
