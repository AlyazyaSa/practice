namespace day_3_solution
{
    internal class Program
    {
        static void Main(string[] args)

        {
            #region  p1
            // indexof
            int[] numbers = { 1, 2, 3, 4, 4, 5 };
            int index = Array.IndexOf(numbers, 3);
            Console.WriteLine(index);
#endregion





            #region p2


            //sort for name example
            string[] names = { "jaz", "saif", "tamim", "mohammed" };
            Array.Sort(names);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            #endregion




            #region p3
            //reverse
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            Array.Reverse(numbers1);
            foreach (int number in numbers1)
            {

                Console.WriteLine(number);

            }



            #region p4
            // for copr array frome anouthere array
            int[] source = { 1, 2, 3, 4, 5, };
            int[] destination = new int[3];
            Array.Copy(source, 1, destination, 0, 3);
            foreach (int number in destination)
            {
                Console.WriteLine(number);
            }
            #endregion




            #region p5
            // use for change size 
            int[] numbers3 = { 1, 2, 3 };
            Array.Resize(ref numbers3, 5);
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }
            #endregion


        }
    }
}