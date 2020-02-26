using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution867
{
    public int[][] Transpose(int[][] A) {
        // col in A becomes row in transpose
        int[][] transpose = new int[A[0].Length][];
        
        for(int i = 0; i<A[0].Length; i++)
        {
            // row in A becomes col in transpose
            transpose[i] = new int[A.Length];
            for(int j = 0; j<A.Length; j++)
            {
                transpose[i][j] = A[j][i];
            }
        }
        
        return transpose;
    }
}