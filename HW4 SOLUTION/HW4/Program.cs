using System.Xml.Linq;

namespace HW4
{
    internal class Program
    {

        public enum ZOO
        {
            
        }



        public class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string type { get; set; }
        }
            
         

        public class ZOOLIFE
        {

            public string Name { get; set; }                    
            public int Age { get; set; }
            public string Types { get; set; }
        }

        public ZOOLIFE(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Types= types;
        }
         public virtual void Makesoun()
        {
            Console.WriteLine("The ani,al is moveing")
        }


        static void Main(string[] args)
        {
  
        }
    }
}