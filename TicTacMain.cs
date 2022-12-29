using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacSharp
{
    /// <summary>
    /// Main class entry point for the TicTacSharp program
    /// Contains the main method for runtime execution/logic of this program
    /// </summary>
    internal class TicTacSharp
    {
        /// <summary>
        /// Entry point of the program.
        /// Starts by spawning in a board object, then building two player objects, and finally playing the game
        /// </summary>
        /// <param name="args">Arguments for the main entry point of this application. None are needed for this process</param>
        public static void Main(string[] args)
        {
            // Store an int value for the board size (bonus points if you figure out how to do it using the "args" variable.
            int DesiredBoardSize = 5;

            // Build a new TicTacBoard, generate a board string from it, and print it out
            var GameBoard = new TicTacBoard();
            string GameBoardString = GameBoard.GenerateGameBoard(DesiredBoardSize);

            // Print the board string out to the console (The Readline is used to keep the console window open when the program is done)
            Console.WriteLine(GameBoardString);
            Console.ReadLine();
        }
    }
}
