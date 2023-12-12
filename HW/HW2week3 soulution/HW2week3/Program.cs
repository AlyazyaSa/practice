namespace HW2week3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Author and Book Management System!");
         
            Console.WriteLine("Enter book title  :");
            string BookTitle= Console.ReadLine();

            Console.WriteLine("Enter  genre :");
            string Genre = Console.ReadLine();

            Console.WriteLine("Enter Publication Year :");
            while (!int.TryParse(Console.ReadLine());
            int PublicationYear = Console.Read();

            Author author = new Author(BookTitle, PublicationYear, Genre);

            var choose = new List>()
            {
           new AddBook() { }
            };
          
        }
    }
}