namespace oopconstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date();
            d1.Day = 01;
            d1.Month = 01;
            d1.Year = 0001;
            Console.WriteLine(d1.GetDate());
        }

    }
    public class Date
    {
        public int Day;
        public int Month;
        public int Year;
  
        public string GetDate()
        {
            return $" {Day.ToString().PadLeft(2, '0')}/{Month.ToString().PadLeft(2, '0')}/{Year.ToString().PadLeft(4, '0')}";
        }
    }
}