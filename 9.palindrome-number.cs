using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution9
{
    public bool IsPalindrome(int x) 
    {
        if (x < 0)
        {
            return false;
        }
        
        if (x == 0)
            return true;
        
        if (x % 10 == 0)
            return false;

        int r = 0;

        while (x != 0)
        {
            int tail = x % 10;
            r = r * 10 + tail;

            if (r == x )
            {
                return true;
            }
            
            x = x / 10;

            if (r == x)
            {
                return true;
            }

            if (r > x)
            {
                return false;
            }
                
        }

        return false;
    }

    public bool IsPalindrome2(int x) 
    {
        if (x < 0) return false;
        if (x == 0) return true;
        if (x % 10 == 0)  return false;

        return x == ReverseInteger(x);
    }

    public int ReverseInteger(int x) {
        long res = 0;
        while(x != 0)
        {
            res = (x % 10) + (res * 10);
            if(res > Int32.MaxValue || res < Int32.MinValue) return int.MaxValue;
            x /= 10;
        }
        return (int)res;
    }
}