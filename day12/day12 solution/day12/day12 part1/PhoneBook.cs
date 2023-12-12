using System.Reflection.Metadata.Ecma335;

namespace day12
{
    class PhoneBook
    {
        #region
        public static int cnt;
        // int order;
        string[] Names;
        long[] Number;
        int size;
        #endregion


        #region CONSTRUCTOR
        public PhoneBook(int size)
        {
            this.Names = new string[size];
            this.Number = new long[size];
            this.size = size;
        }
        #endregion


        public int GetSize()
        {
            return this.size;
        }

        public void AddPerson(int order, string Name, long Number)
        {
             
            //  this.order = cnt;
            this.Names[cnt] = Name;
            this.Number[cnt] = Number;
            cnt += 1;

        }

        private int[] segments = new int[4];
        public int this[AddPerson]=>
        public void GetAll()
        {
            Console.WriteLine("*===================*");
            for (int i = 0; i < size; i++)
            {
                if (this.Names[i] != null)
                    Console.WriteLine($"{i + 1} - || {this.Names[i]} {this.Number[i]}");
            }
        }

        public long GetNumbers(string name)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.Names[i] == name)
                    return this.Number[i];
            }
                return -1;
        }

        public string GetName(long number)
        {
            for (int i = 0; i < this.size; i++)
            {
                if (this.Number[i] == number)
                    return this.Names[i];
            }
            return "Try Again";
        }
    }
}