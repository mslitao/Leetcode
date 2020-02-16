using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution51
{
    public IList<IList<string>> SolveNQueens(int n) 
    {
        int step = 0;

        List<int> current = new List<int>();
        for(int i =0; i<=n; ++i){
            current.Add(-1);
        }

        IList<IList<string>> solutions = new List<IList<string>>();
        
        BackTrackNQueens(current, step, n, solutions);

        return solutions;
    }

    public bool IsValidNQueen(List<int> current, int step)
    {
        if(step <= 1) return true;

        for(int i =1; i < step; i++)
        {
            if(current[i-1] == current[step -1])
            {
                return false;
            }
            else if (current[i -1] - i == current[step -1] - step )
            {
                return false;
            }
            else if (current[i -1] + i == current[step -1] + step )
            {
                return false;
            }
        }

        return true;
    }

    public void BackTrackNQueens(List<int> current, int step, int n, IList<IList<string>> solutions)
    {
        if(step == n)
        {
            if(IsValidNQueen(current, step))
            {
                List<string> result = new List<string>();
                for(int i =0; i<n; i++)
                {
                    StringBuilder sb = new StringBuilder();
                     for(int j =0; j<n; j++)
                     {
                         if(j ==current[i])
                         {
                             sb.Append("Q");
                         }
                         else
                         {
                             sb.Append(".");
                         }
                     }
                     result.Add(sb.ToString());
                }
                solutions.Add(result);
            }

            return;
        }
        else if(IsValidNQueen(current, step) )
        {
            for(int i =0; i < n; ++i)
            {
                current[step]= i;
                BackTrackNQueens(current, step +1, n, solutions);
                current[step]= -1;
            }
        }
        else 
        {
            return;
        }
    }
}