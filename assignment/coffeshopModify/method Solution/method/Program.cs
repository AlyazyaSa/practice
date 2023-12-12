namespace method
{
     class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            //caller
            //var age =18;

            // d1.Dosomthing(out age);

            var numString = "123456s";
            int number;

   
            if (!int.TryParse(numString, out number))
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine($"you provided a valid number {number}");
            }
            Console.ReadKey();  
        }
     }

    public class Demo
    {

        public void Dosomthing(ref int age)
        {
            age = age + 4; 
        }  
      
    }
}

