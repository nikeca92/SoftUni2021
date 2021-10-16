using System;

namespace _11.TheBattleofTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] field = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                var chars = Console.ReadLine().ToCharArray();
                field[row] = chars;
            }

            var heroRow = 0;
            var heroCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'A')
                    {
                        heroRow = i;
                        heroCol = j;
                        break;
                    }
                }
            }

            while (true)
            {
                var commandLine = Console.ReadLine().Split();
                var command = commandLine[0];
                var orcRow = int.Parse(commandLine[1]);
                var orcCol = int.Parse(commandLine[2]);
                field[orcRow][orcCol] = 'O';
                field[heroRow][heroCol] = '-';
                armor--;
                if (command == "up" && heroRow - 1 >=0)
                {
                    heroRow--;
                }
                if (command == "down" && heroRow +1 < rows)
                {
                    heroRow++;
                }
                if (command == "left" && heroCol - 1 >=0 )
                {
                    heroCol--;
                }
                if (command == "right" && heroCol +1 < field[heroRow].Length)
                {
                    heroCol++;
                }


                if (field[heroRow][heroCol] == 'O')
                {
                    armor -= 2;
                }

                if (field[heroRow][heroCol] == 'M')
                {
                    field[heroRow][heroCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }

                if (armor <= 0)
                {
                    field[heroRow][heroCol] = 'X';
                    Console.WriteLine($"The army was defeated at {heroRow};{heroCol}.");
                    break;
                }
                field[heroRow][heroCol] = 'A';

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }

                Console.WriteLine();
            }

        }
    }
}
