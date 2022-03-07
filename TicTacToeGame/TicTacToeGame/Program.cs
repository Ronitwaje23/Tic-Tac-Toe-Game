using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            char[] CreateBoard;
            TicTacToeGame obj = new TicTacToeGame();
            CreateBoard = obj.Board();
            obj.ChoosePlayer();
            obj.ShowBoard(CreateBoard);


        }
    }
}