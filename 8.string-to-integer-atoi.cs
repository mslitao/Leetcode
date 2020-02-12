using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution8
{
    public int MyAtoi(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return 0;
        }

        int result = 0;
        int n = 1;
        str = str.Trim();
        for (int i = 0; i < str.Length; ++i)
        {
            if (i == 0)
            {
                if(str[i] == '-')
                {
                    n = -1;
                    continue;
                }
                if (str[i] == '+')
                {
                    n = 1;
                    continue;
                }
            }
            if (str[i] >= '0' && str[i] <= '9')
            {
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && str[i] - '0' > 7))
                {
                    if (n == 1) return int.MaxValue;
                    else return int.MinValue;
                }

                result = result * 10 + str[i] - '0';
            }
            else
            {
                break;
            }
        }

        if (result > int.MaxValue)
        {
            return 0;
        }

        return result * n;
    }
}