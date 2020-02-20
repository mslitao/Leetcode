using System;
using System.Collections.Generic;
using System.Linq;

public class Solution240
{
    public bool SearchMatrix(int[,] matrix, int target) {
        int rows = matrix.GetLength(0);
        if(rows == 0) return false;
        int columns = matrix.GetLength(1);
        if(columns ==0) return false;

        return BinarySearchMatrix(matrix, target, 0, columns -1 , rows, columns);
    }
    //Binary Search starting at the Right Top position.
    public bool BinarySearchMatrix(int[,] matrix, int target, int i, int j, int rows, int columns)
    {
        if(i <0 || i >= rows || j < 0 || j >= columns)
        {
            return false;
        }

        if(matrix[i,j] == target)
        {
            return true;
        }
        else if(matrix[i,j] > target)
        {
            return BinarySearchMatrix(matrix, target, i, j - 1, rows, columns);
        }
        else
        {
            return BinarySearchMatrix(matrix, target, i + 1, j, rows, columns);
        }
    }
}