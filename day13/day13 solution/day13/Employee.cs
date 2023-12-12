
namespace day13
{
    internal class Employee : People
    {
        string role;
        int WorkingHours;
        double wage;

        public Employee(int Id, string Name, int Age, int SSN, string Address,string role, int WoringHourse, double wage) : base(Id,  Name,  Age,  SSN,  Address)
        {
            this.role = role;
            this.WorkingHours = WoringHourse;
            this.wage = wage;
        }

        public override string ToString()
        {
            return base.ToString() + $"your position is {this.role} , {this.WorkingHours}, {this.wage}";
        }

     //public override calculatesalary()
        //{
        //    base.calculatesalary("");
      //  }

    }
}
