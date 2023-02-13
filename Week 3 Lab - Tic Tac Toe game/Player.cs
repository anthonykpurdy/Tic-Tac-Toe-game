using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Lab___Tic_Tac_Toe_game
{
    internal class Player
    {
        public void ChooseMove(Board board)
        {
            while (true)
            {

                try // catching inproper inputs
                {
                    Console.WriteLine("Select a square (1-9)");

                    int selectedsquare = int.Parse(Console.ReadLine());

                    //update that sleected square to an X   

                    if (selectedsquare == 1 && Board.square1 == tictactoe.Program.EMPTY)
                    {
                        Board.square1 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 2 && Board.square2 == tictactoe.Program.EMPTY)
                    {
                        Board.square2 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 3 && Board.square3 == tictactoe.Program.EMPTY)
                    {
                        Board.square3 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 4 && Board.square4 == tictactoe.Program.EMPTY)
                    {
                        Board.square4 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 5 && Board.square5 == tictactoe.Program.EMPTY)
                    {
                        Board.square5 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 6 && Board.square6 == tictactoe.Program.EMPTY)
                    {
                        Board.square6 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 7 && Board.square7 == tictactoe.Program.EMPTY)
                    {
                        Board.square7 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 8 && Board.square8 == tictactoe.Program.EMPTY)
                    {
                        Board.square8 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare == 9 && Board.square9 == tictactoe.Program.EMPTY)
                    {
                        Board.square9 = tictactoe.Program.X;
                        break;

                    }
                    else if (selectedsquare > 9 || selectedsquare < 1)
                    {

                    }
                    else // checking if the input was valid
                    {
                        Console.WriteLine("Select an tictactoe.Program.EMPTY square");

                    }
                }
                catch (SystemException ex)
                {
                    Console.WriteLine("Please enter an integer");
                }
            }
        }
        public void MakeMove(Board board, int side)
        {
            Random random = new Random();
            while (true)
            {
                int randomSquare = random.Next(1, 10);

                if (randomSquare == 1 && Board.square1 == tictactoe.Program.EMPTY)

                {

                    Board.square1 = side;
                    break;
                }

                if (randomSquare == 2 && Board.square2 == tictactoe.Program.EMPTY)

                {

                    Board.square2 = side;
                    break;
                }

                if (randomSquare == 3 && Board.square3 == tictactoe.Program.EMPTY)

                {

                    Board.square3 = side;
                    break;
                }

                if (randomSquare == 4 && Board.square4 == tictactoe.Program.EMPTY)

                {

                    Board.square4 = side;
                    break;
                }

                if (randomSquare == 5 && Board.square5 == tictactoe.Program.EMPTY)

                {

                    Board.square5 = side;
                    break;
                }

                if (randomSquare == 6 && Board.square6 == tictactoe.Program.EMPTY)

                {

                    Board.square6 = side;
                    break;
                }

                if (randomSquare == 7 && Board.square7 == tictactoe.Program.EMPTY)

                {

                    Board.square7 = side;
                    break;
                }

                if (randomSquare == 8 && Board.square8 == tictactoe.Program.EMPTY)

                {

                    Board.square8 = side;
                    break;
                }
                if (randomSquare == 9 && Board.square9 == tictactoe.Program.EMPTY)

                {
                    Board.square9 = side;
                    break;
                }
            }

        }
    }
}

