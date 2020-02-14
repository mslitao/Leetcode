using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution48 {
    // Swap function for the 2d matrix
    public void Swap(int[,] matrix, int i1, int j1, int i2, int j2)
    {
        var tmp = matrix[i1, j1];
        matrix[i1, j1] = matrix[i2, j2];
        matrix[i2, j2] = tmp;

    }

    public void Rotate(int[,] matrix) 
    {
        // get rows and columns.
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows / 2; ++i)
        {
            for (int j = 0; j < columns; ++j)
            {
                var i1 = rows - i -1;

                Swap(matrix, i, j, i1, j);
            }
        }

        for (int i = 0; i < rows; ++i)
        {
            for (int j = i; j < columns; ++j)
            {
                Swap(matrix, i, j, j, i);
            }
        }
    }
}