namespace day11
{
    internal class Hman
    {
       // int cnt;
        private int id;
        private string name;
        public int age;
        public string Adress;
        private string Email;

        public Hman(int id, string name, int age, string adress, string email)
        {
            this.name = name;
            // this.age = ValidateAgw = email(age) ? age : 0;
            this.age = age;
            this.Adress = adress;
            this.Email = email;

        }
        public int Getid()
        {
            return this.id; //or anouther way as : public int Getid()=> this.id;
        }


        public string GetEmail()
        {
            return this.Email;
        }

        public void SetEmail(string Email)
        {
            this.Email = Email;
        }

    }
}