
namespace oop
{
    internal class Employee
    {
        public string FName;
        public string LName;
        public double wage;
        public double LoggedHours;
        public double salary;
        public int Id;

        public Employee()
        {

        }
      public Employee(string _fName, string _lName , int _age)
        {
            Id += 1;
            FName= _fName;
            LName= _lName;  
            wage= _age;
        }
    }

}
