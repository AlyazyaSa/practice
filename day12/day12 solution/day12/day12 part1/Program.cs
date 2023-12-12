namespace day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PhoneBook myPhone = new PhoneBook(5);
            // myPhone.AddPerson(0, "jaze", 456789876543);
            // myPhone.AddPerson( 1,"saif", 450008888543);
            // myPhone.AddPerson( 3,"omr",  456789876543);
            // myPhone.GetAll();
            //Console.WriteLine(PhoneBook.cnt);

            myPhone.AddPerson(0, "jaze Saif", 456789876543);
            Console.WriteLine(myPhone["jaze"]);
            myPhone["jaze"] = 456789876543;
            myPhone.GetAll();
        }
    }
}