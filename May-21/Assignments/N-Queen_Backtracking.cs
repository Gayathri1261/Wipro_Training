using System;

class NQueensSolver
{
    static void SolveNQueens(int n)
    {
        int[] board = new int[n]; // board[i] = column position of queen in row i
        PlaceQueens(board, 0, n);
    }

    static void PlaceQueens(int[] board, int row, int n)
    {
        if (row == n)
        {
            PrintBoard(board, n);
            Console.WriteLine();
            return;
        }
        for (int col = 0; col < n; col++)
        {
            if (IsSafe(board, row, col))
            {
                board[row] = col;
                PlaceQueens(board, row + 1, n);
            }
        }
    }
    static bool IsSafe(int[] board, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            if (board[i] == col || Math.Abs(board[i] - col) == Math.Abs(i - row))
                return false;
        }
        return true;
    }

    static void PrintBoard(int[] board, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(board[i] == j ? "Q " : "_ ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Enter the value of N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nSolutions for {n}-Queens Problem:\n");
        SolveNQueens(n);
    }
}
