
namespace day13
{
    internal class People : creature , IMove
    {
        public int Id;
        public string Name;
        public int Age;
        public int SSN;
        public string Address;
        public void Travel()
        {
            Console.WriteLine("Iam Travelling");
        }

        public void Play()
        {
            Console.WriteLine("Iam playing");
        }

        public void cook()
        {
            Console.WriteLine("Iam cooking");
        }

        public People(int Id, string Name, int Age, int SSN, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.SSN = SSN;
            this.Address = Address;

        }

        public override string ToString()
        {
   
            return $"+your Id is :  {this.Id}, yor Name is {this.Name}, the age {this.age}, The SSN :{this.SSN}, and adress {this.Address} ";
        }

        //  public virtual void CalculateSalary()
        //   {
        // Console.WriteLine("your salary is calculated according to :");
        // }
        


        //interface :


    }
}
