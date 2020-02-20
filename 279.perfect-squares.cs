using System;
using System.Collections.Generic;
using System.Linq;

public class Solution279
{
    public int NumSquares(int n) {
        var squares = GetAllSquares(n);
        
        if(squares.Count == 0)
            return 0;

        this.minCount  = n;
        
        NumSquaresDP(n, 0, 0, squares, squares.Count -1);

        return this.minCount;
    }
    int minCount;
    public void NumSquaresDP(int n, int sum, int cnt, List<int> squares, int index)
    {
        if(sum == n )
        {
            if(cnt < minCount)
            {
                this.minCount = cnt;
                return;
            }
            
        }

        if(sum> n || cnt > this.minCount)
        {
            return;
        }

        NumSquaresDP(n, sum +squares[index], cnt+1, squares, index);

        if(index >= 1)
            NumSquaresDP(n, sum, cnt, squares, index-1);
    }

    public List<int> GetAllSquares(int n)
    {
        List<int> squares = new List<int>();
        for(int i =0; i< n; ++i)
        {
            if(i*i >n)
                break;
            else
                squares.Add(i*i);
        }

        return squares;
    }
}