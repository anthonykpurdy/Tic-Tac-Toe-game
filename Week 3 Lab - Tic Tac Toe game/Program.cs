using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace tictactoe

{

    class Program

    {

        const int EMPTY = 0;

        const int X = 1;

        const int O = 2;

        static int square1 = EMPTY;

        static int square2 = EMPTY;

        static int square3 = EMPTY;

        static int square4 = EMPTY;

        static int square5 = EMPTY;

        static int square6 = EMPTY;

        static int square7 = EMPTY;

        static int square8 = EMPTY;

        static int square9 = EMPTY;

        static bool iswinner = false;

        static void Main(string[] args)

        {

            while (iswinner == false)
            {
                TicTacToe();
            }

            Console.ReadLine();

        }

        static void TicTacToe()
        {

            while (true)

            {

                DrawBoard();

                //get user choice   

                while (true) // player choice
                {
                    try // catching inproper inputs
                    {
                        Console.WriteLine("Select a square (1-9)");

                        int selectedsquare = int.Parse(Console.ReadLine());

                        //update that sleected square to an x   

                        if (selectedsquare == 1 && square1 == EMPTY)
                        {
                            square1 = X;
                            break;
                        }
                        else if (selectedsquare == 2 && square2 == EMPTY)
                        {
                            square2 = X;
                            break;
                        }
                        else if (selectedsquare == 3 && square3 == EMPTY)
                        {
                            square3 = X;
                            break;
                        }
                        else if (selectedsquare == 4 && square4 == EMPTY)
                        {
                            square4 = X;
                            break;
                        }
                        else if (selectedsquare == 5 && square5 == EMPTY)
                        {
                            square5 = X;
                            break;
                        }
                        else if (selectedsquare == 6 && square6 == EMPTY)
                        {
                            square6 = X;
                            break;
                        }
                        else if (selectedsquare == 7 && square7 == EMPTY)
                        {
                            square7 = X;
                            break;
                        }
                        else if (selectedsquare == 8 && square8 == EMPTY)
                        {
                            square8 = X;
                            break;
                        }
                        else if (selectedsquare == 9 && square9 == EMPTY)
                        {
                            square9 = X;
                            break;
                        }
                        else if (selectedsquare > 9 || selectedsquare < 1)
                        {

                        }
                        else // checking if the input was valid
                        {
                            Console.WriteLine("Select an empty square");

                        }
                    }
                    catch (SystemException ex)
                    {
                        Console.WriteLine("Please enter an integer");
                    }
                }
                DrawBoard();

                // Test if the player won   
                if (

                  (square1 == X && square2 == X && square3 == X) ||

                  (square4 == X && square5 == X && square6 == X) ||

                  (square7 == X && square8 == X && square9 == X) ||

                  (square1 == X && square4 == X && square7 == X) ||

                  (square2 == X && square5 == X && square8 == X) ||

                  (square3 == X && square6 == X && square9 == X) ||

                  (square1 == X && square5 == X && square9 == X) ||

                  (square3 == X && square5 == X && square7 == X))

                {

                    Console.WriteLine("\nPlayer wins!");
                    iswinner = true;
                    break;

                }

                if (
                  square1 != EMPTY && square2 != EMPTY && square3 != EMPTY && square4 != EMPTY &&
                  square5 != EMPTY && square6 != EMPTY && square7 != EMPTY && square8 != EMPTY && square9 != EMPTY)
                {
                    DrawBoard();
                    Console.WriteLine("\nIt's a tie");
                    Console.WriteLine("\nPress ENTER to restart");
                    Console.ReadKey();
                    stateclear();
                    break;
                }

                while (true) // computer choice

                {

                    // Set one of the squares to 'O'   

                    Random random = new Random();

                    int randomSquare = random.Next(1, 10);

                    if (randomSquare == 1 && square1 == EMPTY)

                    {

                        square1 = O;

                        break;

                    }

                    if (randomSquare == 2 && square2 == EMPTY)

                    {

                        square2 = O;

                        break;

                    }

                    if (randomSquare == 3 && square3 == EMPTY)

                    {

                        square3 = O;

                        break;

                    }

                    if (randomSquare == 4 && square4 == EMPTY)

                    {

                        square4 = O;

                        break;

                    }

                    if (randomSquare == 5 && square5 == EMPTY)

                    {

                        square5 = O;

                        break;

                    }

                    if (randomSquare == 6 && square6 == EMPTY)

                    {

                        square6 = O;

                        break;

                    }

                    if (randomSquare == 7 && square7 == EMPTY)

                    {

                        square7 = O;

                        break;

                    }

                    if (randomSquare == 8 && square8 == EMPTY)

                    {

                        square8 = O;

                        break;

                    }

                    if (randomSquare == 9 && square9 == EMPTY)

                    {

                        square9 = O;

                        break;

                    }

                }

                if (

                  (square1 == O && square2 == O && square3 == O) ||

                  (square4 == O && square5 == O && square6 == O) ||

                  (square7 == O && square8 == O && square9 == O) ||

                  (square1 == O && square4 == O && square7 == O) ||

                  (square2 == O && square5 == O && square8 == O) ||

                  (square3 == O && square6 == O && square9 == O) ||

                  (square1 == O && square5 == O && square9 == O) ||

                  (square3 == O && square5 == O && square7 == O))

                {
                    DrawBoard();
                    Console.WriteLine("\nComputer wins!");

                    iswinner = true;
                    break;

                }

                if (
                  square1 != EMPTY && square2 != EMPTY && square3 != EMPTY && square4 != EMPTY &&
                  square5 != EMPTY && square6 != EMPTY && square7 != EMPTY && square8 != EMPTY && square9 != EMPTY)
                {
                    DrawBoard();
                    Console.WriteLine("\nIt's a tie");
                    Console.WriteLine("\nPress ENTER to restart");
                    Console.ReadKey();
                    stateclear();
                    break;
                }

            }

        }

        static void DrawBoard()

        {

            //drawing the board   

            Console.Clear();

            Console.WriteLine($" {PrintState(square1)} | {PrintState(square2)} | {PrintState(square3)}");

            Console.WriteLine("-------------");

            Console.WriteLine($" {PrintState(square4)} | {PrintState(square5)} | {PrintState(square6)}");

            Console.WriteLine("-------------");

            Console.WriteLine($" {PrintState(square7)} | {PrintState(square8)} | {PrintState(square9)}");

        }

        static void stateclear()
        {
            square1 = EMPTY;
            square2 = EMPTY;
            square3 = EMPTY;
            square4 = EMPTY;
            square5 = EMPTY;
            square6 = EMPTY;
            square7 = EMPTY;
            square8 = EMPTY;
            square9 = EMPTY;
        }
        private static object PrintState(int state)

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