using System;
using System.Collections.Generic;
using System.Linq;


public class Solution415 
{
    public string AddStrings(string num1, string num2) {
        int m = num1.Length;
        int n = num2.Length;
        int carry = 0;

        List<char> results = new List<char>();
        for(int i =0; i < m || i < n; ++ i)
        {
            int num = carry + (i < m?  num1[m - i -1] -'0': 0) + (i < n?  num2[n - i -1] -'0': 0);
            carry = num / 2;
            results.Add( (char)('0' + num%2));
        }
        
        if(carry == 1)
        {
            results.Add('1');
        }

        results.Reverse();
        return string.Join("", results);
    }
}