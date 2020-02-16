using System;
using System.Collections.Generic;
using System.Linq;

public class Solution73 
{
    public void SetZeroes(int[][] matrix) 
    {
        int rows = matrix.Length;
        if(rows == 0) return;
        int columns = matrix[0].Length;

        //It's straightforward, but don't overwrite it to zero directlly. 
        //Use a invalid number first, and have another loop to rewrite back to 0
        for(int i =0; i < rows; ++i)
        {
            for(int j =0; j <columns; ++j)
            {
                if(matrix[i][j] == 0)
                {
                    for(int k =0; k < rows; ++k)
                    {
                        if(matrix[k][j] != 0)
                            matrix[k][j] = -1000000;
                    }
                    for(int k =0; k < columns; ++k)
                    {
                        if(matrix[i][k] != 0)
                            matrix[i][k] = -1000000;
                    }
                }
            }
        }
        
        for(int i =0; i < rows; ++i)
        {
            for(int j =0; j <columns; ++j)
            {
                if(matrix[i][j] == -1000000 )
                {
                    matrix[i][j] = 0;
                }
            }
        }
        
    }
}