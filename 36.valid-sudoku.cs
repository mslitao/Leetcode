using System;
using System.Collections.Generic;
using System.Linq;

public class Solution36
{
    public bool IsValidSudoku(char[][] board) {
        for(int i =0; i < 9; ++i)
        {
            int[] values = new int[10];
            for(int j =0; j< 9; ++j)
            {
                int index = board[i][j] - '0';
                
                if(index <1 || index >9) continue;
                if(values[index] == 1)
                {
                    return false;
                }
                values[index] = 1;
            }
        }

        for(int i =0; i < 9; ++i)
        {
            int[] values = new int[10];
            for(int j =0; j< 9; ++j)
            {
                int index = board[j][i] - '0';
                if(index <1 || index >9) continue;
                if(values[index] == 1)
                {
                    return false;
                }
                values[index] = 1;
            }
        }

        for(int x = 0; x < 9; x = x +3)
            for(int y = 0; y < 9; y = y +3)
            {
                int[] values = new int[10];
                
                for(int i =0; i < 3; ++i)
                {
                    for(int j =0; j< 3; ++j)
                    {
                        int index = board[x+i][y+j] - '0';
                        if(index <1 || index >9) continue;
                        if(values[index] == 1)
                        {
                            return false;
                        }
                        values[index] = 1;
                    }
                }
            }
        

        return true;
    }
}