using System;

namespace C7P5
{
    class Program
    {
        static void Main()
        {
            char [][] board = GetBoard(10);
            printBoard(board);
            int round = 0;
            while (round < 10 * 10)
            {
                Console.WriteLine("Enter row and column");
                string input = Console.ReadLine();
                int row = input[0] - '0';
                int col = input[1] - '0';
                if (board[row][col] == '*')
                {
                    if(round % 2 == 0)
                    {
                        board[row][col] = 'O';
                    }
                    else
                    {
                        board[row][col] = 'X';
                    }

                    if (checkWinner(board))
                    {
                        printBoard(board);
                        break;
                    }
                    round++;
                }
                else
                {
                    Console.WriteLine("Already marked");
                }
                printBoard(board);
            }
        }
        static char [][] GetBoard(int n)
        {
            char [][] board = new char [n][];
            for (int i = 0; i < n; i++)
            {
                board[i] = new char [n];
            }

            foreach (char [] row in board)
            {
                for(int i = 0; i < row.Length; i++)
                {
                    row[i] = '*';
                }
                
            }

            return board;
        }
        static void printBoard(char [][] board)
        {
            Console.Write("  ");
            for(int i = 0; i < board.Length; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            int index = 0;
            foreach (char [] row in board)
            {
                Console.Write(index++ + " ");
                foreach (char cell in row)
                {
                    Console.Write(cell + " ");
                }
                Console.WriteLine();
            }
        }
        
        static bool checkWinner(char [][] board)
        {
            for(int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if(j + 4 < board[i].Length && board[i][j] == 'X' && board[i][j + 1] == 'X' && board[i][j + 2] == 'X' && board[i][j + 3] == 'X' && board[i][j + 4] == 'X')
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    if(j + 4 < board[i].Length && board[i][j] == 'O' && board[i][j + 1] == 'O' && board[i][j + 2] == 'O' && board[i][j + 3] == 'O' && board[i][j + 4] == 'O')
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    if(i + 4 < board.Length && board[i][j] == 'X' && board[i + 1][j] == 'X' && board[i + 2][j] == 'X' && board[i + 3][j] == 'X' && board[i + 4][j] == 'X')
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    if(j+4 < board.Length && board[i][j] == 'O' && board[i + 1][j] == 'O' && board[i + 2][j] == 'O' && board[i + 3][j] == 'O' && board[i + 4][j] == 'O')
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                    if(i + 4 < board.Length && j + 4 < board[i].Length && board[i][j] == 'X' && board[i + 1][j + 1] == 'X' && board[i + 2][j + 2] == 'X' && board[i + 3][j + 3] == 'X' && board[i + 4][j + 4] == 'X')
                    {
                        Console.WriteLine("X wins");
                        return true;
                    }
                    if(i + 4 < board.Length && j + 4 < board[i].Length && board[i][j] == 'O' && board[i + 1][j + 1] == 'O' && board[i + 2][j + 2] == 'O' && board[i + 3][j + 3] == 'O' && board[i + 4][j + 4] == 'O')
                    {
                        Console.WriteLine("O wins");
                        return true;
                    }
                }
            }

            return false;
        }
    }
}