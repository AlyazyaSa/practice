using System.Diagnostics;
using System.Transactions;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            #region q1

            //Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Entere your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age is: " + age);
            #endregion

            #region q2
            //2- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.WriteLine("Entere your num:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num is: " + x);

            string result = (x % 3 == 0) && (x % 4 == 0) ? "yes" : "no";
            Console.WriteLine(result);
            #endregion

            #region q3
            //3- Write a program that allows the user to insert 2 integers then print the max.
            Console.WriteLine("Entere your Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y is: " + y);
            string output = (y % 35 == 0) && (y % 5 == 0) ? "yes" : "no";
            Console.WriteLine(output);
            #endregion

            #region q6
            //6- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            int f = 10;
            string outcome = (f % 3 == 0) ? "even" : "odd";
            Console.WriteLine(outcome);
            #endregion

            #region q8   
            int[] numbers = new int[] { 13, 14, 15, 16, 17, 18, 19 }
           int[] slice = number[12..20}
        console.WriteLine(slice[0]); 
           
           #endregion 

            #region 15
         
        string firstChoice = "positive";
        string secondChoice = "negative";
        string thirdChoice = "zero";
        console.Writeline
        Console.WriteLine(s1 == s2 == s3);
        #endregion

        #region q8
        Console.WriteLine("5:");
        int[] numbers = new int[] { 1, 2, 3, 4, 5 }


        int[] slice = number[1..4}
    console.WriteLine(slice[0]);
        #endregion

            #region 19
          
            int[] numbers = { 1, 2, 3, 4, 4, 5 };
    int index = Array.IndexOf(numbers, 4);
    Console.WriteLine(index);
            #endregion

          
            #region 21
            // for copr array frome anouthere array
            int[] source = { 1, 2, 3, 4, 5, };
            int[] destination = new int[3];
            Array.Copy(source, 1, destination, 0, 3);
            foreach (int number in destination)
            {
                Console.WriteLine(number);
            }
#endregion


            #region
            //1- One Dimentsional Array:
            int[] grade = new int[3];
size[0] = "90% : Graede A" +
size[1] = "80% : Grade B" +
size[2] = "70% : Grade C"
size[3] = "60% : Grade D"
size[4] = "70% : Grade E"


     }
}  
}  
         
     
