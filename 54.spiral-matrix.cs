using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution54
{
    public IList<int> SpiralOrder(int[][] matrix) {
        int height = matrix.Length;
        int width = height>0? matrix[0].Length: 0;

        int left =0;
        int right = width-1;
        int top =0;
        int bottom = height -1;
        IList<int> results = new List<int> ();
        int x =0; int y=0;
        while(right >= left && bottom >= top && width >0 && height > 0)
        {
            y = left; 
            x = top;
            while(y< left+width)
            {
                results.Add(matrix[x][y]);
                y++;
            }
            y = left + width -1;
            x = top + 1;
            while(x<top + height)
            {
                results.Add(matrix[x][y]);
                x++;
            }
            x=top+height -1;
            y=left+width -2;
            while(y>= left && x> top)
            {
                results.Add(matrix[x][y]);
                y--;
            }
            y=left;
            x= top+height-2;
            if(width > 1)
            {
                while(x> top)
                {
                    results.Add(matrix[x][y]);
                    x--;
                }
            }

            left ++;
            right--;
            bottom--;
            top++;
            width = width -2;
            height = height -2;
        }

        return results;
    }
}