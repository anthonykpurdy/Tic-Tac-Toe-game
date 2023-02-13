using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_3_Lab___Tic_Tac_Toe_game;

namespace Week_3_Lab___Tic_Tac_Toe_game
{
    internal class Referee
    {


        public bool DetectWin(Board board, int side, string name) {


            if (

              (Board.square1 == side && Board.square2 == side && Board.square3 == side) ||

              (Board.square4 == side && Board.square5 == side && Board.square6 == side) ||

              (Board.square7 == side && Board.square8 == side && Board.square9 == side) ||

              (Board.square1 == side && Board.square4 == side && Board.square7 == side) ||

              (Board.square2 == side && Board.square5 == side && Board.square8 == side) ||

              (Board.square3 == side && Board.square6 == side && Board.square9 == side) ||

              (Board.square1 == side && Board.square5 == side && Board.square9 == side) ||

              (Board.square3 == side && Board.square5 == side && Board.square7 == side))

            {
                Board.Draw();
                Console.WriteLine($"\n{name} wins!");
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DetectTie(Board board)
        {
            if (
            Board.square1 != tictactoe.Program.EMPTY && Board.square2 != tictactoe.Program.EMPTY && Board.square3 != tictactoe.Program.EMPTY && Board.square4 != tictactoe.Program.EMPTY &&
            Board.square5 != tictactoe.Program.EMPTY && Board.square6 != tictactoe.Program.EMPTY && Board.square7 != tictactoe.Program.EMPTY && Board.square8 != tictactoe.Program.EMPTY && Board.square9 != tictactoe.Program.EMPTY)
            {
                Board.Draw();
                Console.WriteLine("\nIt's a tie");
                return true;
            }
            return false;
        }

    }
}

