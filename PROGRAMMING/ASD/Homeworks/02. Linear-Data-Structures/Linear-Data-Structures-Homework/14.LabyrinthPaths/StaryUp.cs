using System;

namespace _14.LabyrinthPaths
{
    class StaryUp
    {
        static void Main(string[] args) //thanks to dentia and Pip3r4o
        {
            var labyrinth = new string[,]
            {
                {"0", "0", "0", "x", "0", "x"},
                {"0", "x", "0", "x", "0", "x"},
                {"0", "*", "x", "0", "x", "0"},
                {"0", "x", "0", "0", "0", "0"},
                {"0", "0", "0", "x", "x", "0"},
                {"0", "0", "0", "x", "0", "x"}
            };

            MarkPaths(2,1,labyrinth,0);

            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == "0")
                    {
                        labyrinth[i, j] = "u";
                    }

                    Console.Write(labyrinth[i,j] + "  ");
                }

                Console.WriteLine();
            }

        }

        static void MarkPaths(int row, int col, string[,] labyrinth, int count)
        {
            if (col < 0 || col >= labyrinth.GetLength(1))
            {
                return;
            }
            if (row < 0 || row >= labyrinth.GetLength(1))
            {
                return;
            }
            if (labyrinth[row, col] == "x")
            {
                return;
            }
            if (labyrinth[row,col] != "*" && labyrinth[row,col] != "0" && count + 1 > int.Parse(labyrinth[row,col]))
            {
                return;
            }
            if (labyrinth[row, col] != "*")
            {
                count++;
                labyrinth[row, col] = count.ToString();
            }
            
            MarkPaths(row, col + 1, labyrinth, count);
            MarkPaths(row - 1, col, labyrinth, count);
            MarkPaths(row + 1, col, labyrinth, count);
            MarkPaths(row, col - 1, labyrinth, count);
        }
    }
}
