using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace day12Section2
{
    internal class Human
    {
        public int SSd;
        public string Name;
        public bool boolHasJob;
        public int age;
        public bool Married;


        public Person() { }
        public Human(int SSd, string Name, bool boolHasJob, bool Married)
        {
            this.SSd = SSd;
            this.Name = Name;
            this.boolHasJob = boolHasJob;
        }
                
    
        public void Describe()
        {
            Console.WriteLine($"{SSd} , {Name} , {boolHasJob} ");
        }
    }
}
