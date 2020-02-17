
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution120 
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        if (triangle == null || triangle.Count ==0)
        {
            return 0;
        }

        List<List<int>> paths = new List<List<int>>();

        for (int i = 0; i < triangle.Count; ++i)
        {
            List<int> tmp = new List<int>();
            for (int j = 0; j < triangle[i].Count; ++j)
            {

                if (i == 0)
                {
                    tmp.Add(triangle[i][j]);
                }
                else
                {
                    int left = j - 1 < 0 ? int.MaxValue : paths[i - 1][j - 1];
                    int right = j  >= triangle[i-1].Count ? int.MaxValue : paths[i - 1][j];

                    tmp.Add(triangle[i][j] + Math.Min(left, right));
                }
            }

            paths.Add(tmp);
        }

        int minval = int.MaxValue;
        for (int j = 0; j < paths[paths.Count - 1].Count; j++)
        {
            if (paths[paths.Count - 1][j] < minval)
                minval = paths[paths.Count - 1][j];
        }
        return minval;
    }

    // Can also be solved by dp/
    public int MinimumTotal2(IList<IList<int>> triangle) 
    {
        if (triangle == null)
            return 0;
        else if (triangle[0] == null)
            return 0;
        else if (triangle.Count == 1)
            return triangle[0][0];
        
        List<List<int>> temp = new List<List<int>>();
        int min = int.MaxValue;
        
        temp.Add(new List<int>());
        temp[0].Add(triangle[0][0]);
        
        for (int i = 1; i <= triangle.Count - 1; i++)
        {
            temp.Add(new List<int>());
            
            temp[i].Add(temp[i - 1][0] + triangle[i][0]); 
        
            if (triangle.Count > 2)
                for (int j = 1; j <= triangle[i].Count - 2; j++)
                    temp[i].Add(Math.Min(temp[i - 1][j - 1] + triangle[i][j],
                                         temp[i - 1][j] + triangle[i][j]));
            
            temp[i].Add(temp[i - 1][temp[i - 1].Count - 1] + triangle[i][triangle[i].Count - 1]);
        }
        
        foreach (var item in temp[temp.Count - 1])
            min = Math.Min(min, item);
        
        return min;
    }
}