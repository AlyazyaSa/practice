using System.ComponentModel.DataAnnotations;

namespace WazeGame
{
    internal class Program
    {
        public class WazeGame
        {
            private char[,] Waze;
            private int personB;
            private int personC;

            public WazeGame(char[,] wazeLevel)
            {
                Waze = wazeLevel;
                personB = -1;
                personC = -1;
            }

            public void startgame()
            {
                Console.WriteLine("Welcome to the Maze Escape Challenge!");
                Console.WriteLine("Generated Maze:");


                if (personB == -1 || personC == -1)
                {
                    Console.WriteLine("Starting point not found in the maze.");
                    return;
                }

                while (true)
                {


                    Console.WriteLine("FOR MOVE USE W, A, S, D . Your goal is to reach the Exit (E) !");
                    Console.WriteLine($"Current Position: ({personB + 1}, {personC + 1})");
                    Console.WriteLine("Enter your move (U/L/D/R):");
                    char move = Console.ReadKey().KeyChar;

                    while (true)
                    {
                        if (!Move(move))
                        {
                            Console.WriteLine("Invalid move. Try again.");

                        }

                        if (IsGameWon())
                        {
                            Console.WriteLine("Congratulations! You've reached the Exit (E)!\");
                            break;
                        }
                    }

            }
        }
    }