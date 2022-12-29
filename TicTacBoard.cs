using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacSharp
{
    /// <summary>
    /// Class object that represents a tic tac board instance
    /// Contains methods to spawn a board, draw a board, and make moves on a board
    /// </summary>
    internal class TicTacBoard
    {
        #region Custom Events
        #endregion // Custom Events

        #region Fields
        #endregion // Fields

        #region Properties
        #endregion // Properties

        #region Structs and Classes

        /* Old/Og Big Board Class Code
        public class BigBoard
        {


            private void BigBoard = ((" %c | %c | %c | %c ")
                                     (___ | ___ | ___ | ___)
                                     (" %c | %c | %c | %c ")
                                     (___ | ___ | ___ | ___)
                                     (" %c | %c | %c | %c ")
                                     (___ | ___ | ___ | ___)
                                     (" %c | %c | %c | %c "))

            private void SmallBoard = ((" %c | %c | %c | %c ")
                                        (___ | ___ | ___ | ___)
                                        (" %c | %c | %c | %c ")
                                        (___ | ___ | ___ | ___)
                                        (" %c | %c | %c | %c "))

            bool _BigBoard = true;
        }
        */

        #endregion // Structs and Classes

        // ------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Default CTOR for the TicTacBoard type. This does not do anything special really other than spawn an instance of the TicTacBoard type
        /// </summary>
        public TicTacBoard()
        {
            // Nothing has to happen in here
            // Yet...
        }

        // ------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Generates a new board at the szie value given
        /// </summary>
        /// <param name="BoardSize">Size of the X or Y axis of the board to generate</param>
        /// <returns>A string holding the board content at this point</returns>
        public string GenerateGameBoard(int BoardSize)
        {
            // If Input value is 5 for BoardSize:
            //  [ 0, 0, 0, 0, 0 ]
            //  [ 0, 0, 0, 0, 0 ]
            //  [ 0, 0, 0, 0, 0 ]
            //  [ 0, 0, 0, 0, 0 ]
            //  [ 0, 0, 0, 0, 0 ]

            // Build an empty 2D array of board space values that hold if a plyaer has populated it or not
            int[][] BoardSpaces = Enumerable.Repeat(Enumerable.Repeat(0, BoardSize).ToArray(), BoardSize).ToArray();

            // Loop all of the values in the board array. Rows are Y index. Columns are X Index (yes backwards)
            // After each loop of the X index values (Column values), store thw whole row string value in the variable below.
            string GameBoardString = string.Empty;
            for (int YIndex = 0; YIndex < BoardSize; YIndex++)
            {
                // Store the current row of values in the array at our Y Index value to loop them later on
                int[] CurrentRowValues = BoardSpaces[YIndex];

                // Loop all of the column values for the board at the current row index
                // Store the content for each row in this variable.
                // So for row 0, you want to end up storing this assuming the board size is 5
                // (Think about how you'd get the leading | value for the row string
                // | 0 | 0 | 0 | 0 | 0 |
                string CurrentRowString = string.Empty;
                for (int XIndex = 0; XIndex < BoardSize; XIndex++)
                {
                    // Build the string for each of the spaces and put it all together
                    // Hint: Take the X index value of the array named CurrentRowValues
                    // Hint: Take each value and add a '|' after it.                   
                }

                // Once you build the value for the current row, add it to the GameBoardString variable and move on to the next looop
                // Hint: Remember this has to print out ROWS of things. Think about how to make a new line in the console
            }

            // Once you're done building all the row values as strings, you could just return the value of BoardContentSplit
            // However, I'm an asshole and want you to build a top line of +---------+ and a bottom line of +---------+ based on the board size
            // Hint: Look back at this enumerable call I used up on the definition of BoardSpaces. Something like Enumerable.Repeat(-, BoardSize).
            // Hint: Enumerable.Repeat does not return a string but rather a collection. Think about how to join a collection of strings in C#.
            string BoardPaddingLine = string.Empty;

            // Once you've built the padding line and inserted it at the top and bottom of the board content, retun the built string value
            // You can print it out to the console here, or you can print it out from the Main method of TicTacMain
            return GameBoardString;
        }
    }
}
