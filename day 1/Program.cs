namespace day_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first code
            Console.WriteLine("Hello, This is first code!");
            #endregion

            #region
            int age;
            age = 23;
            Console.WriteLine("age");
            #endregion

            #region p.2
            string name = "My name is JAZ";
            Console.WriteLine(name);
            #endregion

            #region p.3
            string firstName = "Jaz";
            string secondName = "Saif";
            Console.WriteLine($"your full Name is {firstName} {secondName}");
            #endregion

            #region p.4
            // DyNAMIC Keyword
            dynamic test = "see here";
            test = 7;
            test = 0m;
            test = 0u;
            test = 0l;
            test = 0ul;
            #endregion

            #region p.5
            //Comparison Operators
            int x = 5;
            int y = 10;

            Console.WriteLine($"The result is {x == y} {x > y} {x < y}");
            #endregion

            #region p.6
            //Xor is a logical operator
            bool x = true;
            bool y = false;
            Console.WriteLine(x ^ y);
            #endregion


            #region p.7
            //short circle logical operator & -| 
            //is better for use than ( XOR logical operator) 
            int x = 10;
            string result = (x % 3 == 0) ? "devisible" : "not divisiable";
            Console.WriteLine(result);
            #endregion

            #region p.8
            //reference type operatiom
            string s1 = "hello";
            string s2 = "hi";
            Console.WriteLine(s1 == s2);
            #endregion

            #region p.9
            //Ternary operator
            int x = 5;
            int y = 5;
      
            string result = (x < y) ? "x is less than y" : "x is greater than or equal to y";
            Console.WriteLine(result);
            #endregion


        }
    }
}