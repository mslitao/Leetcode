using System;
using System.Collections.Generic;
using System.Linq;

public class NumMatrix {

    int[,] sumMap = null;
    int m = -1;
    int n = -1;
    public NumMatrix(int[][] matrix) {
        if(matrix == null) return;
        m = matrix.Length;
        if(m == 0) return;
        n = matrix[0].Length;
        if(n == 0) return;

        this.sumMap = new int[m + 1, n + 1];
        for(int i =0; i<m; ++i)
            for(int j =0; j< n; ++ j)
            {
                this.sumMap[i+1, j+1] = this.sumMap[i+1, j] + this.sumMap[i,j+1] - this.sumMap[i, j] + matrix[i][j];
            }
        
        /*for(int i =0; i<=m; ++i)
        {
            for(int j =0; j<= n; ++ j)
            {
                Console.Write(sumMap[i, j]);
                Console.Write("|");
            }
            Console.WriteLine();
        }*/
        
        return;
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        if(sumMap == null) return 0;

        if(row1 <0 || row1 >= m || col2 <0 || col2>= n) return 0;

        return this.sumMap[row2 + 1, col2 + 1] -
               this.sumMap[row1, col2 + 1] -
               this.sumMap[row2 + 1, col1] + 
               this.sumMap[row1, col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */