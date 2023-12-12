using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12Section2
{
    internal class Employee : Human //calaculate salary
    {
        public string role;
        public int workhoures;
        public string wage;
        public string department;
    }

        public Employee() { }

        public Employee(int SSd, string Name, bool boolHasJob, int age, bool Married, string department, int workhoures, string wage ):base(SSd, Name, boolHasJob)
        {
            department = department;
            workhoures = workhoures;
            wage = wage;
            department = department;
        }
        
        public double CalculateSalary()
        {
            string wage=this.wage;
            int salary=workhoures*wage;
            double SalaryAfterswage = salary * .3;
            return salary - SalaryAfterswage;
        }
        public void EmpPrint()
        {
            Console.WriteLine("***********************************Employee class****************")
            Console.Write($" {SSd} , {Name} , {boolHasJob} ,{department}, {workhoures}, {wage}");
            Console.WriteLine(this.CalculateSalary());
        }
        }
    }
