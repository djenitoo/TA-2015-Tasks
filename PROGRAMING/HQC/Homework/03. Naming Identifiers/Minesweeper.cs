namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
	{
		static void Main(string[] args)
		{
            const int MaxPoints = 35;
            
			var field = CreatePlayfield();
			var mines = PutMines();
            var championsList = new List<Player>(6);

            string playerInput;
			var currentPoints = 0;
			var boardRow = 0;
			var boardColumn = 0;

			var startGame = true;
			var isWinner = false;
            var mineIsActivated = false;

			do
			{
				if (startGame)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					PrintBoard(field);
					startGame = false;
				}

				Console.Write("Daj red i kolona : ");
				playerInput = Console.ReadLine().Trim();

				if (playerInput.Length >= 3)
				{
					if (int.TryParse(playerInput[0].ToString(), out boardRow) &&
					int.TryParse(playerInput[2].ToString(), out boardColumn) &&
						boardRow <= field.GetLength(0) && boardColumn <= field.GetLength(1))
					{
						playerInput = "turn";
					}
				}

				switch (playerInput)
				{
					case "top":
						HighScores(championsList);
						break;
					case "restart":
						field = CreatePlayfield();
						mines = PutMines();
						PrintBoard(field);
						mineIsActivated = false;
						startGame = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (mines[boardRow, boardColumn] != '*')
						{
							if (mines[boardRow, boardColumn] == '-')
							{
								PlayerMove(field, mines, boardRow, boardColumn);
								currentPoints++;
							}

							if (MaxPoints == currentPoints)
							{
								isWinner = true;
							}
							else
							{
								PrintBoard(field);
							}
						}
						else
						{
							mineIsActivated = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}

				if (mineIsActivated)
				{
					PrintBoard(mines);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", currentPoints);

					var playerName = Console.ReadLine();
					var currentPlayer = new Player(playerName, currentPoints);
					
                    if (championsList.Count < 5)
					{
						championsList.Add(currentPlayer);
					}
					else
					{
						for (int i = 0; i < championsList.Count; i++)
						{
						    if (championsList[i].PlayerPoints >= currentPlayer.PlayerPoints)
						    {
						        continue;
						    }

						    championsList.Insert(i, currentPlayer);
						    championsList.RemoveAt(championsList.Count - 1);
						    break;
						}
					}

					championsList.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    championsList.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.PlayerPoints.CompareTo(firstPlayer.PlayerPoints));
					
                    HighScores(championsList);

					field = CreatePlayfield();
					mines = PutMines();
					currentPoints = 0;
					mineIsActivated = false;
					startGame = true;
				}
				if (isWinner)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					PrintBoard(mines);
					Console.WriteLine("Daj si imeto, batka: ");

					var playerName = Console.ReadLine();
					var currentPlayer = new Player(playerName, currentPoints);
                    championsList.Add(currentPlayer);

					HighScores(championsList);
					field = CreatePlayfield();
					mines = PutMines();
					currentPoints = 0;
					isWinner = false;
					startGame = true;
				}
			}
			while (playerInput != "exit");

			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void HighScores(List<Player> championsList)
		{
			Console.WriteLine("\nTo4KI:");
			if (championsList.Count > 0)
			{
				for (int i = 0; i < championsList.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, championsList[i].Name, championsList[i].PlayerPoints);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void PlayerMove(char[,] board,
			char[,] mines, int boardRow, int boardColumn)
		{
			char countOfSurroundingMines = CountOfSurroundingMinesForPosition(mines, boardRow, boardColumn);
			mines[boardRow, boardColumn] = countOfSurroundingMines;
			board[boardRow, boardColumn] = countOfSurroundingMines;
		}

		private static void PrintBoard(char[,] board)
		{
			int boardRow = board.GetLength(0);
			int boardColumn = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < boardRow; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < boardColumn; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreatePlayfield()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PutMines()
		{
			var boardRows = 5;
			var boardColums = 10;
			var board = new char[boardRows, boardColums];

			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColums; j++)
				{
					board[i, j] = '-';
				}
			}

			var createCurrentRow = new List<int>();
			
            while (createCurrentRow.Count < 15)
			{
				Random random = new Random();
				int newNumber = random.Next(50);
				
                if (!createCurrentRow.Contains(newNumber))
				{
					createCurrentRow.Add(newNumber);
				}
			}

			foreach (var number in createCurrentRow)
			{
				int divided = (number / boardColums);
				int reminder = (number % boardColums);
				
                if (reminder == 0 && number != 0)
				{
					divided--;
					reminder = boardColums;
				}
				else
				{
					reminder++;
				}

				board[divided, reminder - 1] = '*';
			}

			return board;
		}

		private static void CalculateSurroundingMines(char[,] playfield)
		{
			var row = playfield.GetLength(0);
			var col = playfield.GetLength(1);

			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
				{
					if (playfield[i, j] != '*')
					{
						var countOfSurroundingMinesToString = CountOfSurroundingMinesForPosition(playfield, i, j);
						playfield[i, j] = countOfSurroundingMinesToString;
					}
				}
			}
		}

		private static char CountOfSurroundingMinesForPosition(char[,] playfield, int row, int col)
		{
			var countOfSurroundigMines = 0;
			var rows = playfield.GetLength(0);
			var cols = playfield.GetLength(1);

			if (row - 1 >= 0)
			{
				if (playfield[row - 1, col] == '*')
				{ 
					countOfSurroundigMines++; 
				}
			}
			if (row + 1 < rows)
			{
				if (playfield[row + 1, col] == '*')
				{ 
					countOfSurroundigMines++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (playfield[row, col - 1] == '*')
				{ 
					countOfSurroundigMines++;
				}
			}
			if (col + 1 < cols)
			{
				if (playfield[row, col + 1] == '*')
				{ 
					countOfSurroundigMines++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (playfield[row - 1, col - 1] == '*')
				{ 
					countOfSurroundigMines++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (playfield[row - 1, col + 1] == '*')
				{ 
					countOfSurroundigMines++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (playfield[row + 1, col - 1] == '*')
				{ 
					countOfSurroundigMines++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (playfield[row + 1, col + 1] == '*')
				{ 
					countOfSurroundigMines++; 
				}
			}

			return char.Parse(countOfSurroundigMines.ToString());
		}
	}
}
