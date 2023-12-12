using System.ComponentModel.Design;

namespace challenge
{
    internal class Program
    {
        public static string apiURL = "https://chat.openai.com/c/565c6cd4-c013-4f82-ab56-5e30bce8610f";

        static async Task Main()
        {
            do
            {
                Console.WriteLine("Ask your quastion : (choose finished if you waant to exit)");
                string guestQuastion = Console.ReadLine();

                if (guestQuastion.ToLower() == "EXIT")
                {
                    break;
                }

                else
                {
                    string GPTAnswer = await ChatGPTAnswer(guestQuastion);
                    Console.WriteLine($"The answer of your quastion is : {GPTAnswer}");
                    Console.WriteLine("===============");
                    Console.WriteLine();
                }
            } while (true);
        }

        private static Task<string> ChatGPTAnswer(string guestQuastion)
        {
         Console.ReadLine();
        }
    }
}