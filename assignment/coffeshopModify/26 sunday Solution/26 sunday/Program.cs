namespace _26_sunday
{
    internal class Program
    {
        static void MultiplicationTable(int n = 4)
        {
            string s = "";

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Multiplication Taple of {i} ");
                for (int j = 1; j <= 10; j++) 
                {
                  Console.WriteLine($" {i}* {j} = {i * j}");
                   
                }
            }

             
            Console.WriteLine("=================================");    


        }

        static void Main()
        {
            MultiplicationTable();
        }

    }
}  