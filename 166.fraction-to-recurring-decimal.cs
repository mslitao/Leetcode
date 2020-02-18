using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution166
{
    public string FractionToDecimal(int numerator, int denominator) {
        int sign = Math.Sign(numerator) * Math.Sign(denominator);
        if(sign == 0) return "0";


        StringBuilder sb = new StringBuilder();
        ulong num = (ulong) Math.Abs((long)numerator);
        ulong den = (ulong) Math.Abs((long)denominator);
        sb.Append(num/den);

        if(num % den != 0)
        {
            num = num % den;
            sb.Append(".");

            Dictionary<ulong, int> modMap = new Dictionary<ulong, int>();
            while(true)
            {
                ulong mod = num % den;
                if(mod==0)
                    break;
                
                if(modMap.ContainsKey(mod))
                {
                    sb.Insert(modMap[mod], "(");
                    sb.Append(")");
                    break;
                }
                else
                {
                    modMap.Add(mod, sb.Length);
                }

                
                num *= 10;
                sb.Append(num / den);
                num = num % den;
            }
        }
        return ((sign < 0) ? "-" : string.Empty) + sb.ToString();
    }
}