using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Lab___Tic_Tac_Toe_game
{
    internal class Board
    {
        public static int square1 = tictactoe.Program.EMPTY;

        public static int square2 = tictactoe.Program.EMPTY;

        public static int square3 = tictactoe.Program.EMPTY;

        public static int square4 = tictactoe.Program.EMPTY;

        public static int square5 = tictactoe.Program.EMPTY;

        public static int square6 = tictactoe.Program.EMPTY;

        public static int square7 = tictactoe.Program.EMPTY;

        public static int square8 = tictactoe.Program.EMPTY;

        public static int square9 = tictactoe.Program.EMPTY;


         public static void Draw()

        {

            //drawing the board   

            Console.Clear();

            Console.WriteLine($" {PrintState(square1)} | {PrintState(square2)} | {PrintState(square3)}");

            Console.WriteLine("-------------");

            Console.WriteLine($" {PrintState(square4)} | {PrintState(square5)} | {PrintState(square6)}");

            Console.WriteLine("-------------");

            Console.WriteLine($" {PrintState(square7)} | {PrintState(square8)} | {PrintState(square9)}");

        }
        public static object PrintState(int state)

        {

            if (state == 0)

                return ' ';

            else if (state == 1)

                return 'X';

            else

                return 'O';

        }
    }
}
