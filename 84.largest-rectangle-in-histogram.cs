using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution84
{
    public int LargestRectangleArea(int[] heights) {
        int maxArea = 0;
        if(heights == null || heights.Length ==0) return maxArea;

        for(int i =0; i < heights.Length; ++i)
        {
            //This can save a lot of effort looking backward for the area computing.
            if(i + 1< heights.Length && heights[i]<= heights[i +1])
            {
                continue;
            }

            //last one or the height will start decrease from next one.
            int j = i;
            int min = heights[i];
            while(j>=0)
            {
                min = Math.Min(min, heights[j]);
                int area = (i - j + 1) * min;
                if(area>maxArea) maxArea = area;
                j--;
            }
            
        }

        return maxArea;
    }
}