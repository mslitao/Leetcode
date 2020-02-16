using System;
using System.Collections.Generic;
using System.Linq;

public class Solution74 {
    // Treat this as a binary search with the root of the top right position.
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int rows = matrix.Length;
        if(rows == 0) return false;
        int columns = matrix[0].Length;
        if(columns ==0) return false;

        return BinarySearchMatrix(matrix, target, 0, columns -1 , rows, columns);
    }

    public bool BinarySearchMatrix(int[][] matrix, int target, int i, int j, int rows, int columns)
    {
        // return false if outside of the boundary
        if(i <0 || i >= rows || j < 0 || j >= columns)
        {
            return false;
        }

        if(matrix[i][j] == target)
        {
            return true;
        }
        else if(matrix[i][j] > target)
        {
            return BinarySearchMatrix(matrix, target, i, j - 1, rows, columns);
        }
        else
        {
            return BinarySearchMatrix(matrix, target, i + 1, j, rows, columns);
        }
    }
}