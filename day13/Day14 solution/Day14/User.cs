using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Money { get; set; }


        public static double operator +
        public User(string Name, int Age, int Money)
        {
            this.Name = Name;
            this.Age = Age;
            this.Money = Money;
        }

        public static double operetor + (User A, User b)
        {
            int sum
        }

    }
}
