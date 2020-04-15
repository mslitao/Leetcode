using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution85
{
    public int MaximalRectangle(char[][] matrix) {
        if(matrix == null) return 0;
        int m = matrix.Length;
        if(m == 0) return 0;
        int n = matrix[0].Length;
        if(n == 0) return 0;

        int[,] dpleft = new int[m ,n ];
        for(int i = 0; i < m; ++i)
            for(int j = 0; j < n; ++j)
            {
                if(matrix[i][j] =='0')  dpleft[i, j] = 0;
                else dpleft[i, j] = (j ==0? 0: dpleft[i, j -1]) + 1;
            }

        int result = 0;
        for(int i = 0; i < m; ++i)
            for(int j = 0; j<n; ++j)
            {
                if(matrix[i][j] == '0') 
                {
                    continue;
                }
                else
                {
                    int width = int.MaxValue;
                    int height = 0;
                    int area = 0;
                    for(int k = i; k >=0; k--)
                    {
                        height ++;
                        width = Math.Min(width, dpleft[k, j]);
                        if(width == 0) break;

                        area = Math.Max(area, height * width);
                    }
                    
                    result = Math.Max(result, area);
                }
            }

        return result;
    }
}