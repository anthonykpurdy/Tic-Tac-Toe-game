using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Week_3_Lab___Tic_Tac_Toe_game;

namespace tictactoe

{

    public class Program

    {

        public const int EMPTY = 0;

        public const int X = 1;

        public const int O = 2;

        

        

        static void Main(string[] args)

        {
            Board board = new Board();
            Player player = new Player();
            Player computer = new Player();
            Referee referee = new Referee();

            while (true)
            {
                Board.Draw();

                player.ChooseMove(board);
                if (referee.DetectWin(board, X, "Player"))
                    break;

                if (referee.DetectTie(board))
                    break;

                computer.MakeMove(board, O);
                if (referee.DetectWin(board, O, "Computer"))
                    break;

            }

            Console.ReadLine();
                

        }  

    }

}