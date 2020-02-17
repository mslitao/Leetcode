using System;
using System.Collections.Generic;
using System.Linq;

public class Solution130 
{
    public void Solve(char[][] board) 
    {
        int rows = board.Length;
        if(rows == 0) return;
        int columns = board[0].Length;
        if(columns ==0) return;

        for(int i =0; i< rows; ++i)
        {
            DFSSolveBoard(board, i, 0, rows, columns, '*');
            DFSSolveBoard(board, i, columns - 1, rows, columns, '*');
        }

        for(int j =0; j< columns; ++j)
        {
            DFSSolveBoard(board, 0, j, rows, columns, '*');
            DFSSolveBoard(board, rows-1, j, rows, columns, '*');
        }

        for(int i =1; i < rows -1 ; ++ i)
        {
            for(int j = 1; j < columns -1; ++j)
            {
                DFSSolveBoard(board, i, j, rows, columns, 'X');
            }
        }

        for(int i =0; i < rows ; ++ i)
        {
            for(int j = 0; j < columns; ++j)
            {
                if(board[i][j] == '*')
                    board[i][j] = 'O';
            }
        }
    }

    public void DFSSolveBoard(char[][] board, int i, int j, int rows, int columns, char target)
    {
        if(i <0 || i>= rows || j <0 || j >= columns)
        {
            return;
        }

        if(board[i][j] == 'O')
        {
            board[i][j] = target;
            DFSSolveBoard(board, i - 1, j, rows, columns, target);
            DFSSolveBoard(board, i + 1, j, rows, columns, target);
            DFSSolveBoard(board, i, j - 1, rows, columns, target);
            DFSSolveBoard(board, i, j + 1, rows, columns, target);
        }
        
        return;
    }
}