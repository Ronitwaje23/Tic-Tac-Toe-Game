using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class TicTacToeGame
    {
        public char[] Board()
        {
            char[] CreateBoard = new char[10];
            for (int i = 1; i < CreateBoard.Length; i++)
            {
                CreateBoard[i] = ' ';
            }
            Console.WriteLine("Board Initialized");
            return CreateBoard;
        }
        public char ChoosePlayer()
        {
            char[] choice = new char[] { 'X', 'O' };
            Console.WriteLine("Choose X or O ");
            char playerChoice = char.Parse(Console.ReadLine());
            if (playerChoice == choice[0])
            {
                playerChoice = choice[0];
            }
            else
            {
                playerChoice = choice[1];
            }
            return playerChoice;
        }
        public void ShowBoard(char[] createBoard)

        {

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[1], createBoard[2], createBoard[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[4], createBoard[5], createBoard[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[7], createBoard[8], createBoard[9]);
            Console.WriteLine("     |     |      ");
        }

    }



}