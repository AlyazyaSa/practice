using System.Security.Cryptography.X509Certificates;

namespace Day14
{
    #region Permissions
    //[Flags]
    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Executw = 8
    //}
    #endregion

    #region  Enum Parsing example
    enum FlowerColor
    {

            red,
            white,
            black,
            yellow,
            Orange


    }
    #endregion

    internal class Program
    {

        #region enum int and string
        //enum Gender
        //{
        //    Male,
        //    Female,
        // }
        //enum month
        //{
        //     jan,
        //     fep,
        //     mar,
        //     april,
        //     may,
        //     june,
        //     july,
        //     aug,
        //     sep,
        //     oct,
        //     nov,
        //     dec


        //}
        #endregion

    
        static void Main(string[] args)
        {
            #region Enum
            //string FlowerColor = "black";
            //Console.WriteLine((int)Enum.Parse(typeof(FlowerColor), FlowerColor));
            //if (Enum.TryParse(FlowerColor, out FlowerColor color))
            //{ 
            //    Console.WriteLine(color);
            //}
            //Permissions myPermission = (Permissions.Read | Permissions.write) // Permissions.delet | Permissions.Exexute  (1)
            //Console.WriteLine(myPermission);

            //Month month = Month.june;         (2)
            //Console.WriteLine($" This month is : {month}");
            //Console.WriteLine(month);

            //Gender gender = Gender.Male;      (3)
            //Console.WriteLine(Gender.Male);
            #endregion

           
        }
    }
}