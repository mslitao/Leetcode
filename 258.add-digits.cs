using System;
using System.Collections.Generic;
using System.Linq;

public class Solution258
{
    public int AddDigits(int num) {
        if(num < 10)
            return num;
        
        if(num % 9 == 0)
            return 9;
        
        return num % 9;
    }
}