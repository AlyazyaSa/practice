namespace day12Section2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Human p1 = new Human();
            p1.Name = "Name1";
            p1.SSd = 555;
            p1.boolHasJob= true;
            p1.Describe();
            Human p2 = new Human(2222, "Name2", false);
            p2.Describe();

            Employee Ep = new Employee();
            Ep.Name = "noraPerson";
            Ep.SSd = 2222;
            Ep.boolHasJob = true;
            Ep.wage = 5;
            Ep.workhoures = 5;
            Ep.EmpPrint();
            //8/
            Employee Ep2 = new Employee(4444, "Emp2", true, false, "manager", "MIS", 4, 3, 9);
            Ep2.Equals();

            Student student = new Student();
            student.Name = "54321";
            student.boolHasJob= false;

            student.qualificstion = "B";
            student.Grade = 5;
            student.StudingHourse = 40;
            student.StudentInf();

            Student student2=new Student(33, "student2", false,"dep".true.3.20);


        }
    }
}