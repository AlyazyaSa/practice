using System.Security.Cryptography.X509Certificates;

namespace Day15
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[]
            {
                new Employee { Id=123,   Name="ASMA" , Gender="F",   TotalSalary=70000m},
                new Employee { Id = 456, Name = "jaz", Gender = "F", TotalSalary = 80000m },
                new Employee { Id = 789, Name = "omr", Gender = "M", TotalSalary = 90000m },
                new Employee { Id = 101112, Name = "zez", Gender = "M", TotalSalary = 100000m },

            };


            var report = new Report();
            {
            reports reports = new Report();
            reports.ProcessEmployee(employee, " Sales >=$60,000" ,)
            reports.ProcessEmployee(employee, "Sales >=$60,000" ,);
            reports.ProcessEmployee(employee, " Sales | $60,000");
        }

        }
    }
}