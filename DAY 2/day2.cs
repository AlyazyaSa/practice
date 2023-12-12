using System;

namespace day_4
{
    class program
    {


        static void Main()
        {


            #region
            //1- One Dimentsional Array:
            string[] size = new string[3];
            size[0] = "Small";
            size[1] = "Medium";
            size[2] = "Large";

            Console.WriteLine("your size is : " + size[3]);
            #endregion




            #region 1
            //2-Multi Dimentsional Array:
            int[,] Id = new int[2, 2]; //2rew //2coloum
            Id[0, 0] = 33;
            Id[0, 1] = 24;
            Id[1, 0] = 39;
            Id[1, 1] = 40;
            Console.WriteLine("Id is: " + Id[2, 4]);
            #endregion


            #region 2
            //3-jagged array
            int[][] farmer = new int[2][];
            farmer[0] = new int[3] { 1, 2, 3, };
            farmer[1] = new int[2] { 1, 2 };
            #endregion
  
            #region 3
            string[] name = new namespace { "saif", "omar", "ahmed", "sara"};
            string FirstName = name[0];
            console.Writeline(FirstName);
            #endregion

             #region 4
            //array slicing mode
             int[] numbers = new int[] { 1, 2, 3, 4, 5 }
             int[] slice = number[1..5}
             console.WriteLine(slice[0]);
             int[] slice1 = numbers[..3];
             int[] slics2 = nubers[..2];
             #endregion

            #region 
            //reserve slicing
            var slice3 = numbers[2..^2];
            console.WriteLine(slice3[0]);
#endregion


             #region 
             //Binary Operator
             int x, y;
             x = 10; y = 5;
             console.WritLine($ "x + y = {x + y}");
             console.WritLine($ "x + y = {x - y}");
             console.WritLine($ "x + y = {x * y}");
             console.WritLine($ "x + y = {x / y}");
             #endregion



             #region
            int x = 4;
            string result = (x % 2 == 0) ? " x is even" : "x is odd";
            Console.WriteLine(result);
            string result(x<y);
#endregion




             #region

             //null example
             string str = null;
             str = (str == null) ? null : "youssif

             str = str ?? "youssfi";
#endregion


             #region
             string value = "9999"
             int x; = int.parse(value);
             int y = convert.ToInt32(value);
             dynamic result = (int.TryParse(value, out int z)) ? z : "error";
             #endregion













    }
}
    

}