using System;
using System.Security.Cryptography;

namespace jazetest
{
    internal class Program
    {

        static void PrintLine(int n = 10, string Pattern = "_")
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(Pattern);

            }
        }
    }
}