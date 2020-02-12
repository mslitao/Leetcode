using System;
using System.Collections.Generic;
using System.Linq;

public class Solution11 
{
    //This question is easier to set 2 pointer 
    // left start from 0
    // right start from length - 1
    // Trying to move to the middle.
    public int MaxArea(int[] height)
    {
        if (height.Length < 2)
        {
            return 0;
        }

        int i = 0;
        int j = height.Length - 1;
        int maxArea = 0;
        while (j > i)
        {
            int area = Math.Min(height[i], height[j]) * (j - i);

            if (area > maxArea)
                maxArea = area;
            
            // Everytime, only move the short one.
            if (height[i] < height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }
            
        return maxArea;
    }
}