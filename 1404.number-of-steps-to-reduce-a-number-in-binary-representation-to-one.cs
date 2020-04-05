using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1404
{
    public int NumSteps(string s) {
        if(string.IsNullOrEmpty(s)) return 0;

        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        s = new string(charArray);
        
        int step = 0;
        while(true)
        {
            if(s== "1")
            {
                break;
            }
            
            step ++;
            if(s == "0")
            {
                break;
            }

            if(s.StartsWith('0'))
            {
                s =DevideTwo(s);
            }
            else
            {
                s = AddOne(s);
            }
        }

        return step;
    }

    public string AddOne(string input)
    {
        int carry = 1;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < input.Length; ++i)
        {
            int num = (input[i] == '1'? 1:0) + carry;
            carry = num/2;
            sb.Append(num%2  == 1 ? '1' : '0');
        }
        if(carry == 1) sb.Append('1');

        return sb.ToString();
    }

    public string DevideTwo(string input)
    {
        return input.Substring(1);
    }
}