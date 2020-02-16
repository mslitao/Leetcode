using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution52
{
    public int TotalNQueens(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        IList<IList<string>> results = new List<IList<string>>();

        List<List<int>> board = new List<List<int>>(n);
        for (int i = 0; i < n; ++i)
        {
            board.Add(Enumerable.Repeat(0, n).ToList());
        }

        SolveNQueens(results, board, 0, n);

        return results.Count;
    }

    public bool IsValidBoard(List<List<int>> board, int i, int j, int N)
    {
        for (int row = 0; row < N; ++row)
        {
            if (row != i && board[row][j] == 1)
            {
                return false;
            }
        }

        for (int col = 0; col < N; ++col)
        {
            if (col != j && board[i][col] == 1)
            {
                return false;
            }
        }
        int s, t;

        for (s = i + 1, t = j + 1; s >= 0 && t >= 0 && s < N && t < N; s++, t++)
        {
            if (board[s][t] == 1)
                return false;
        }
        for (s = i + 1, t = j - 1; s >= 0 && t >= 0 && s < N && t < N; s++, t--)
        {
            if (board[s][t] == 1)
                return false;
        }
        for (s = i - 1, t = j - 1; s >= 0 && t >= 0 && s < N && t < N; s--, t--)
        {
            if (board[s][t] == 1)
                return false;
        }
        for (s = i - 1, t = j + 1; s >= 0 && t >= 0 && s < N && t < N; s--, t++)
        {
            if (board[s][t] == 1)
                return false;
        }


        return true;

    }

    public void SolveNQueens(IList<IList<string>> results, List<List<int>> board, int index, int N)
    {
        if (index >= N)
        {
            List<string> res = new List<string>();
            foreach (var row in board)
            {
                var sb = new StringBuilder();
                foreach (var pos in row)
                {
                    sb.Append(pos == 1 ? "Q" : ".");
                }

                res.Add(sb.ToString());
            }
            results.Add(res);
            return;
        }

        for (int j = 0; j < N; ++j)
        {
            if (IsValidBoard(board, index, j, N))
            {
                board[index][j] = 1;
                SolveNQueens(results, board, index + 1, N);
                board[index][j] = 0;
            }
        }
    }
}