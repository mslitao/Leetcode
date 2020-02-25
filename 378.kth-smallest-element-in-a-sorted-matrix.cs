using System;
using System.Collections.Generic;
using System.Linq;

public class Solution378
{
    public int KthSmallest(int[][] matrix, int k) 
    {
        int n = matrix.Length;
        int[] columnMap = new int[n];
        Array.Fill(columnMap, 0);
        List<int> nums = new List<int>();
        for(int i =0; i < k; ++i)
        {
            int minVal = int.MaxValue;
            int minRow = -1;
            for(int j =0; j < n; ++j)
            {
                if(columnMap[j] < n && matrix[j][columnMap[j]] < minVal)
                {
                    minVal = matrix[j][columnMap[j]];
                    minRow = j;
                }
                
            }
            columnMap[minRow] =  columnMap[minRow] + 1;
            nums.Add(minVal);
        }

        return nums.Last();
    }

    //Another option is to use BFS (Queue)
}