using System.Security.Cryptography.X509Certificates;

namespace oop
{
    internal class Program
    {
       static double  CalculateS( double loggedhourse , double salary)
        {
            salary = 700;
            double  Tax = 0.3;
            double taxamount = salary * Tax;
            double totalsalary = salary - taxamount;
            return totalsalary;

        }



        static void Main( string[] args)
        {

      
            Console.WriteLine("WELCOME TO YOUR OUR SYSTEM :");

            Employee emp = new Employee();

            Console.WriteLine("First Name : ");
            emp.FName=Console.ReadLine();

            Console.WriteLine("Last Name : ");
            emp.FName = Console.ReadLine();

            Console.WriteLine("your ID : ");
            emp.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("wage : ");
            emp.wage =double.Parse(Console.ReadLine());

            Console.WriteLine("LoggedHours : ");
            emp.LoggedHours =double.Parse(Console.ReadLine());

            Console.WriteLine($" first namr : {emp.FName} \n {CalculateS(emp.wage, emp.LoggedHours)}");  

        }
        
    }
    
}