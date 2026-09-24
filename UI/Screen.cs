using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.UI
{
    public class Screen
    {
        public Screen()
        {
            
        }

        public void MainScreen()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++ TIC TAC TOE GAME V.1 ++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("     1. Play");
            Console.WriteLine("     0. Exit");
        }

        public void PlayerScreen()
        {
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++ PLAYERS REGISTER ++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
        }
    }
}