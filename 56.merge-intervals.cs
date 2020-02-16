using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution56
{
    // Sort the intervals is the key to solve this problem
    
    public int[][] Merge(int[][] intervals) {
        if(intervals == null) return null;
        int rows = intervals.Length;
        if(rows == 0) return intervals;
        int columns = intervals[0].Length;
        if(columns == 0) return intervals;

        Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));
        
        var start = intervals[0][0];
        var end = intervals[0][1];
        List<int[]> results = new List<int[]>();

        for(int i =1; i < rows; ++i)
        {
            // If the current interval's start is beyond the previous window end. 
            // Save the previous window and kick off new one.
            if(intervals[i][0] > end)
            {
                results.Add(new int[]{start, end});

                start = intervals[i][0];
                end = intervals[i][1];
            }
            // Otherwise, extend the end and continue.
            else
            {
                end = Math.Max(end, intervals[i][1]);
            }
        }
        // Be remember to save the last one after the loop.
        results.Add(new int[]{start, end});

        return results.ToArray();
    }
}