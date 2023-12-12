namespace HW2week3
{
    internal class Book
    {

        private string BookTitle;
        private int PublicationYear;
        private string Genre;

        public Book(string BookTitle, int PublicationYear, string Genre)
        {
            this.BookTitle = BookTitle;
            this.PublicationYear = PublicationYear;
            this.Genre = Genre;
          
        }

        public string
            displayBookInfo() => $" write {this.BookTitle}  \n the publicationYear is {this.PublicationYear} \n the Genre {this.Genre}";
    }
}
