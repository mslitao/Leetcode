using System;
using System.Collections.Generic;
using System.Linq;

public class Solution79
{
    public bool Exist(char[][] board, string word) {
        if(string.IsNullOrEmpty(word)) return false;
        int columns = board.Length;
        if(columns == 0) return false;
        int rows = columns>0?board[0].Length:0;
        if(rows == 0 ) return false;
        
        HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();
        
        for(int i =0; i < columns; ++i)
            for(int j =0; j< rows;++j)
            {
                if (board[i][j] == word[0] && DFSExist(board, word, 0, i, j, visited, columns, rows))
                {
                    return true;
                }
            }

        return false;
    }

    public bool DFSExist(char[][] board, string word, int pos, int x, int y, HashSet<Tuple<int, int>> visited, int columns, int rows)
    {
        pos ++;
        if(pos == word.Length)
            return true;
        
        visited.Add(Tuple.Create(x, y));
        if(!visited.Contains(Tuple.Create(x-1, y)) && x > 0 && board[x-1][y] == word[pos] 
            && DFSExist(board, word, pos , x-1, y , visited, columns, rows))
            return true;
        if(!visited.Contains(Tuple.Create(x+1, y)) && x + 1< columns  && board[x+1][y] == word[pos] 
            && DFSExist(board, word, pos , x+1, y , visited, columns, rows))
            return true;
        if(!visited.Contains(Tuple.Create(x, y-1)) && y - 1>=0 && board[x][y - 1] == word[pos] 
            && DFSExist(board, word, pos , x, y -1 , visited, columns, rows))
            return true;
        if(!visited.Contains(Tuple.Create(x, y + 1)) && y + 1 < rows && board[x][y +1] == word[pos] 
            && DFSExist(board, word, pos , x, y + 1 , visited, columns, rows))
            return true;

        visited.Remove(Tuple.Create(x, y));
        return false;
    }
}