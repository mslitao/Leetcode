using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution7
{
    public int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int tail = x % 10;
            int newResult = result * 10 + tail;
            if ((newResult - tail) / 10 != result)
            { return 0; }
            result = newResult;
            x = x / 10;
        }

        return result;
    }

    // Cannot work on big numbers
    public int Reverse2(int x)
    {
        if(x > -10  && x <10) return x;

        int sign = x> 0? 1: -1;
        char[] chars = (x*sign).ToString().ToCharArray();
        Array.Reverse(chars);

        return int.Parse(new string(chars).TrimStart('0')) * sign;
    }

    public int Reverse3(int x) {
        long res = 0;
        while(x != 0)
        {
            res = (x % 10) + (res * 10);
            if(res > Int32.MaxValue || res < Int32.MinValue) return 0;
            x /= 10;
        }
        return (int)res;
    }
}