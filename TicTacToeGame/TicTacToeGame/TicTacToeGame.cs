using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class TicTacToeGame
    {
        public static char[] TicTacToeBoard = new char[10];
        public static char player;
        public static char computer;

        public static void startplay()
        {

            Console.WriteLine("game starting");
            Console.WriteLine("==================");
            Console.WriteLine("||  |    |   ||");
            Console.WriteLine("||  |    |   ||");
            Console.WriteLine("||  |    |   ||");
            Console.WriteLine("==================");

            for (int i = 1; i < TicTacToeBoard.Length; i++)
            {
                TicTacToeBoard[i] = ' ';
            }
            Console.ReadLine();

        }
        public static void GetPlayerInput()
        {
            Console.Write("Choose What Symbol You Want \"X\" or \"O\" : ");
            player = Convert.ToChar(Console.ReadLine());
            if (player == 'X' || player == 'x')
            {
                computer = 'O';
            }
            else if (player == 'O' || player == 'o')
            {
                computer = 'X';
            }
            else
            {
                Console.WriteLine("Wrong Input Try Again");
                GetPlayerInput();
            }
            Console.WriteLine("Player Chose : " + player);
            Console.WriteLine("Computer Chose : " + computer);
        }
    }
}
