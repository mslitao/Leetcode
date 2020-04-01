using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution67
{
    public string AddBinary(string a, string b) {
        if(string.IsNullOrEmpty(a)) return b;
        if(string.IsNullOrEmpty(b)) return a;

        int m = a.Length;
        int n = b.Length;

        int i = 0; 
        int carry =0;
        List<int> results = new List<int>();
        while(i < Math.Max(m, n))
        {

            int num1 = i<m && a[m - i - 1] == '1'? 1: 0;
            int num2 = i<n && b[n - i - 1] == '1'? 1: 0;
            int res = num1 + num2 + carry;

            results.Add(res%2);
            carry = res/2;
            i++;
        }
        if(carry == 1)
        {
            results.Add(1);
        }

        results.Reverse();
        return string.Join("", results);
    }
}