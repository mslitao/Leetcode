using System;
using System.Collections.Generic;

public class Solution29
{
    public int Divide(int dividend, int divisor) {
        if (divisor == 0) return int.MaxValue;
        // get the negative or positive number first.
        int sign = dividend > 0 ^ divisor > 0 ? -1 : 1;


        long m = Math.Abs((long)dividend), n = Math.Abs((long)divisor), count = 0;
        
        for (m -= n; m >= 0; m -= n){
            count++;
            if (m == 0) break;
            for (int subCount = 1; m - (n << subCount) >= 0; subCount++){
                m -= n << subCount;
                count += (int)Math.Pow(2, subCount);
            }
        }
        return count*sign > int.MaxValue ? int.MaxValue : (int)count*sign;
    }
}