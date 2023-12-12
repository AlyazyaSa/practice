using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Assignmet1week3
{
    class Game
    {
        public void start()
        {
         
            SetCursorPosition(4, 2);
            Write("x");

            string[,] grid = {
              {"=","=","="," ", " ", "=", "=" },
              { "="," ","="," ", "=", " ", "x"},
              { "="," ","="," ", "=", " ", "="},
              { "="," ","="," ", "=", " ", "="},
              { "="," ","="," ", "=", " ", "="},
              { "="," ","="," ", "=", " ", "="},
           };

            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            for (int z = 0; z< rows; z++)
            {
                for (int x = 0; x< cols; x++)
                {
                    string element = grid[z, x];
                    SetCursorPosition(x, z);
                    Write(element);
                }
            }
           

            WriteLine("\n Press any key to exit..");
            ReadKey(true); 
        }
    }
}
