using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12Section2
{
    public class Student : Human
    {
        public string qualificstion;
        public bool intern;
        public int Grade;
        public int StudingHourse;

        public Student()
        { }

        public Student(int SSd, string Name, bool HasJob, string qualification, bool intern, int Grade, int StudingHourse) : base(SSd, Name, HasJob)
        {
            qualification = qualification;
            intern = intern;
            Grade = Grade;
            StudingHourse = StudingHourse;
        }

        public void StudentInf()
        {
            Console.WriteLine("*********************** Student class************");
            Console.WriteLine($" {SSd, {Name} , {boolHasJob} , {qualificstion} , {intern} , {Grade} , {StudingHourse}");
            Console.WriteLine("*************************************");
        }
    }
 } 