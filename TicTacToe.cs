//Filename: TicTacToe.cs
//Created By: Chris Pendleton
//Date: 11/14/2013

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            string topLeft = "1", topCenter = "2", topRight = "3", centerLeft = "4", centerCenter = "5", centerRight = "6", bottomLeft = "7", bottomCenter = "8", bottomRight = "9";
            string inputString = "Y";
            string playerOne;
            int playerSwitch = 0;
            string playerTwo;

            //Gathers player names and verifies the user actually input something for a player name
            Console.WriteLine("Let's play Tic-Tac-Toe!!!");
            Console.WriteLine();
            Console.WriteLine("Enter a name for Player 1: ");
            Console.WriteLine();
            playerOne = Console.ReadLine();
            while (playerOne == "")
            {
                Console.WriteLine("Please enter a valid name for Player 1: ");
                Console.WriteLine();
                playerOne = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Enter a name for Player 2: ");
            Console.WriteLine();
            playerTwo = Console.ReadLine();
            while (playerTwo == "")
            {
                Console.Write("Please enter a valid name for Player 2: ");
                Console.WriteLine();
                playerTwo = Console.ReadLine();
            }

            //Prints a gameboard for players to see a visual representation of the game
            Console.Clear();
            Console.WriteLine("Alright, {0} and {1}! Let's play!!!", playerOne, playerTwo);

            //This is the beginning of the game code
            do
            {
                do
                {
                    //Display the gameboard
                    Console.WriteLine();
                    Console.WriteLine(topLeft + " | " + topCenter + " | " + topRight);
                    Console.WriteLine("---------");
                    Console.WriteLine(centerLeft + " | " + centerCenter + " | " + centerRight);
                    Console.WriteLine("---------");
                    Console.WriteLine(bottomLeft + " | " + bottomCenter + " | " + bottomRight);
                    Console.WriteLine();
                    //Display player's turn
                    if (playerSwitch == 0)
                        Console.WriteLine("Select a cell, {0}: ", playerOne);
                    else if (playerSwitch == 1)
                        Console.WriteLine("Select a cell, {0}: ", playerTwo);
                    Console.WriteLine();
                    inputString = Console.ReadLine();
                    Console.Clear();
                    //Switch to handle player input. Print "X" for player 1 and "O" for player 2 in selected cell, or display invalid input error to player if input is not a number from 1-9
                    switch (inputString)
                    {
                        case "1":
                            if (topLeft == "1")
                            {
                                if (playerSwitch == 0)
                                {
                                    topLeft = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    topLeft = "O";
                                    playerSwitch--;
                                }
                            }
                            else
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        case "2":
                            if (topCenter == "2")
                            {
                                if (playerSwitch == 0)
                                {
                                    topCenter = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    topCenter = "O";
                                    playerSwitch--;
                                }
                            }
                            else
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        case "3":
                            if (topRight == "3")
                            {
                                if (playerSwitch == 0)
                                {
                                    topRight = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    topRight = "O";
                                    playerSwitch--;
                                }
                            }
                            else
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        case "4":
                            if (centerLeft == "4")
                            {
                                if (playerSwitch == 0)
                                {
                                    centerLeft = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    centerLeft = "O";
                                    playerSwitch--;
                                }
                            }
                            else
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        case "5":
                            if (centerCenter == "5")
                            {
                                if (playerSwitch == 0)
                                {
                                    centerCenter = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    centerCenter = "O";
                                    playerSwitch--;
                                }
                            }
                            else Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        case "6":
                            if (centerRight == "6")
                            {
                                if (playerSwitch == 0)
                                {
                                    centerRight = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    centerRight = "O";
                                    playerSwitch--;
                                }
                            }
                            else
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        case "7":
                            if (bottomLeft == "7")
                            {
                                if (playerSwitch == 0)
                                {
                                    bottomLeft = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    bottomLeft = "O";
                                    playerSwitch--;
                                }
                            }
                            else if (bottomLeft != "7")
                            {
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            }
                            break;
                        case "8":
                            if (bottomCenter == "8")
                            {
                                if (playerSwitch == 0)
                                {
                                    bottomCenter = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    bottomCenter = "O";
                                    playerSwitch--;
                                }
                            }
                            else
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        case "9":
                            if (bottomRight == "9")
                            {
                                if (playerSwitch == 0)
                                {
                                    bottomRight = "X";
                                    playerSwitch++;
                                }
                                else
                                {
                                    bottomRight = "O";
                                    playerSwitch--;
                                }
                            }
                            else if (bottomRight == "X" || bottomRight == "O")
                                Console.WriteLine("That cell has already been selected. Please try again.");
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("Please enter a number from 1 to 9.");
                            Console.WriteLine();
                            break;
                    }
                    //Read for and display winner when one is available by reading for 3 cells in a row to have the same values
                    if ((topLeft == topCenter && topLeft == topRight) || (topLeft == centerLeft && topLeft == bottomLeft) || (topLeft == centerCenter && topLeft == bottomRight) || (topCenter == centerCenter && topCenter == bottomCenter) || (topRight == centerCenter && topRight == bottomLeft) || (topRight == centerRight && topRight == bottomRight) || (centerLeft == centerCenter && centerLeft == centerRight) || (bottomLeft == bottomCenter && bottomLeft == bottomRight))
                    {
                        Console.WriteLine();
                        Console.WriteLine(topLeft + " | " + topCenter + " | " + topRight);
                        Console.WriteLine("---------");
                        Console.WriteLine(centerLeft + " | " + centerCenter + " | " + centerRight);
                        Console.WriteLine("---------");
                        Console.WriteLine(bottomLeft + " | " + bottomCenter + " | " + bottomRight);
                        Console.WriteLine();
                        if (playerSwitch == 0)
                        {
                            Console.WriteLine("{0} wins!!!", playerTwo);
                            break;
                        }
                        else if (playerSwitch == 1)
                        {
                            Console.WriteLine("{0} wins!!!", playerOne);
                            break;
                        }
                    }
                    //Read for a draw and display a message indentifying when a draw has occurred (All cells are filled and no three in a row match)
                    else if (((topLeft == "X" || topLeft == "O") && (centerCenter == "X" || centerCenter == "O") && (centerRight == "X" || centerRight == "O") && (bottomLeft == "X" || bottomLeft == "O") && (bottomCenter == "X" || bottomCenter == "O") && (bottomRight == "X" || bottomRight == "O")))
                    {
                        //Display draw gameboard for visual representation of draw scenario
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(topLeft + " | " + topCenter + " | " + topRight);
                        Console.WriteLine("---------");
                        Console.WriteLine(centerLeft + " | " + centerCenter + " | " + centerRight);
                        Console.WriteLine("---------");
                        Console.WriteLine(bottomLeft + " | " + bottomCenter + " | " + bottomRight);
                        Console.WriteLine();
                        Console.WriteLine("It's a draw!!!");
                        break;
                    }
                    //Continues playing game as long as 3 cells in a row are not the same value
                } while (!(topLeft == topCenter && topLeft == topRight) || (topLeft == centerLeft && topLeft == bottomLeft) || (topLeft == centerCenter && topLeft == bottomRight) || (topCenter == centerCenter && topCenter == bottomCenter) || (topRight == centerCenter && topRight == bottomLeft) || (topRight == centerRight && topRight == bottomRight) || (centerLeft == centerCenter && centerLeft == centerRight) || (bottomLeft == bottomCenter && bottomLeft == bottomRight));
                //Reset game cells and playerSwitch and prompt user to play again. This resets the whole game in case the user wants to play again.
                topLeft = "1";
                topCenter = "2";
                topRight = "3";
                centerLeft = "4";
                centerCenter = "5";
                centerRight = "6";
                bottomLeft = "7";
                bottomCenter = "8";
                bottomRight = "9";
                playerSwitch = 0;
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? Y/N");
                Console.WriteLine();
                inputString = Console.ReadLine();
                Console.Clear();
                //Switch to handle user input when prompted to play again
                switch (inputString)
                {
                    case "N":
                        break;
                    case "n":
                        inputString = "N";
                        break;
                    case "Y":

                        break;
                    case "y":
                        inputString = "Y";
                        break;
                    default:
                        do
                        {
                            //Handler for invalid input when user is prompted to play again after a winner or draw is determined
                            Console.WriteLine("Would you like to play again? Please enter Y for 'Yes' or N for 'No': ");
                            Console.WriteLine();
                            inputString = Console.ReadLine();
                            Console.Clear();
                        } while (inputString != "Y" && inputString != "y" & inputString != "n" && inputString != "N");
                        break;
                } while (inputString != "Y" && inputString != "y" & inputString != "n" && inputString != "N") ;
            } while (inputString == "Y" || inputString == "y");
        }
    }
}
