using System;
using System.Collections.Generic;
using System.Linq;

public class Solution326
{
    public bool IsPowerOfThree(int n) 
    {
        while (n >0 && n % 3 == 0) 
        {
            n /= 3;
        }
        
        return n == 1;
    }
}