using System;
using System.Linq;

namespace _16.PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[8, 8];

            for (int row = 0; row < 8; row++)
            {
                string currentRow = Console.ReadLine();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            char[] letters = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
            int whitePawRow = 0;
            int whitePawCol = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] == 'w')
                    {
                        whitePawRow = i;
                        whitePawCol = j;
                        break;
                    }
                }
            }

            int blackPawRow = 0;
            int blackPawCol = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (matrix[i, j] == 'b')
                    {
                        blackPawRow = i;
                        blackPawCol = j;
                        break;
                    }
                }
            }

            switch (whitePawRow)
            {
                case 0:
                    whitePawRow = 'a';
                    break;
            }

            while (true)
            {


                if (whitePawRow == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {letters[whitePawCol]}{8-whitePawRow}.");
                    break;
                }

                if (blackPawRow == 7)
                {
                    
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {letters[blackPawCol]}{Math.Abs(blackPawRow - 8)}.");

                    break;
                }
               
                if (IsSafe(matrix, whitePawRow - 1, whitePawCol + 1))
                {
                    if (matrix[whitePawRow - 1, whitePawCol + 1] == 'b')
                    {
                        matrix[whitePawRow, whitePawCol] = '-';
                        matrix[whitePawRow - 1, whitePawCol + 1] = 'w';
                        whitePawRow--;
                        whitePawCol++;
                        Console.WriteLine($"Game over! White capture on {letters[whitePawCol]}{8 - whitePawRow}.");
                        break;

                    }
                }

                if (IsSafe(matrix, whitePawRow - 1, whitePawCol - 1))
                {
                    if (matrix[whitePawRow - 1, whitePawCol - 1] == 'b')
                    {
                        matrix[whitePawRow, whitePawCol] = '-';
                        matrix[whitePawRow - 1, whitePawCol - 1] = 'w';
                        whitePawRow--;
                        whitePawCol--;
                        Console.WriteLine($"Game over! White capture on {letters[whitePawCol]}{8-whitePawRow}.");
                        break;
                    }
                }
                matrix[whitePawRow, whitePawCol] = '-';
                matrix[whitePawRow - 1, whitePawCol] = 'w';
                whitePawRow--;
              

                if (IsSafe(matrix, blackPawRow + 1, blackPawCol - 1))
                {
                    if (matrix[blackPawRow + 1, blackPawCol - 1] == 'w')
                    {
                        matrix[blackPawRow, blackPawCol] = '-';
                        matrix[blackPawRow + 1, blackPawCol - 1] = 'b';
                        blackPawRow++;
                        blackPawCol--;
                        Console.WriteLine($"Game over! Black capture on {letters[blackPawCol]}{Math.Abs(blackPawRow - 8)}.");
                        break;
                    }
                }

                if (IsSafe(matrix, blackPawRow + 1, blackPawCol + 1))
                {
                    if (matrix[blackPawRow + 1, blackPawCol + 1] == 'w')
                    {
                        matrix[blackPawRow, blackPawCol] = '-';
                        matrix[blackPawRow + 1, blackPawCol + 1] = 'b';
                        blackPawRow++;
                        blackPawCol++;
                        Console.WriteLine($"Game over! Black capture on {letters[blackPawCol]}{Math.Abs(blackPawRow - 8)}.");
                        break;
                    }
                }


                matrix[blackPawRow, blackPawCol] = '-';
                matrix[blackPawRow + 1, blackPawCol] = 'b';
                blackPawRow++;

            }

        }

        public static bool IsSafe(char[,] matrix, int row, int col)
        {
            if (row < 0 || col < 0)
            {
                return false;
            }

            if (row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}
