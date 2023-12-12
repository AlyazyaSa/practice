namespace HW2week3
{
    internal class Author
    {
        private string name;
        private int BirthYear;
        private string Nationality;

        public Author(string name, int BirthYear, string Nationality)
        {
            this.name = name;
            this.BirthYear = BirthYear;
            this.Nationality = Nationality;

        }

        Public Author
                 displayAuthorInfo() => $" your {this.name}  \n the year of birth {this.BirthYear} \n and {this.Nationality}";
        }
    }
