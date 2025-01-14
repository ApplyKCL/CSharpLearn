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
        
        static void checkWinner(char [][] board)
        {
            for(int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    
                }
            }
            
        }
    }
}