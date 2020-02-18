using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution204
{
    public int CountPrimes(int n) 
    {
        if(n < 2) return 0;
        bool[] nonPrime = new bool[n];
        for(int i = 2; i <= Math.Sqrt(n); i++)
            if(!nonPrime[i-1])
                for(int j = i * i; j <= n; j += i)
                    nonPrime[j-1] = true;
        int result = 0;
        for(int k = 2; k < n; k++)
            result += nonPrime[k-1] ? 0 : 1;
        return result;
    }
}