using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class TicTacToeGame
    {
        public static char[] TicTacToeBoard;

        public static void startplay()
        {

            Console.WriteLine("game starting");
            Console.WriteLine("==================");
            Console.WriteLine("||  |    |   ||");
            Console.WriteLine("||  |    |   ||");
            Console.WriteLine("||  |    |   ||");
            Console.WriteLine("==================");

            TicTacToeBoard = new char[10] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

            TicTacToeBoard = TicTacToeBoard.Skip(1).ToArray();
            Console.ReadLine();

        }
    }
}
