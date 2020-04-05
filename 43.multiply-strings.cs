using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution43
{

    public string Multiply(string num1, string num2) {
        string res = "";
        int m = num1.Length;
        int n = num2.Length;
        int[] vals = new int[m+n];
        for (int i = m - 1; i >= 0; --i) {
            for (int j = n - 1; j >= 0; --j) {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int p1 = i + j, p2 = i + j + 1, sum = mul + vals[p2];
                vals[p1] += sum / 10;
                vals[p2] = sum % 10;
            }
        }
        foreach (int val in vals) {
            if (res!="" || val != 0) 
                res+= (char) (val + '0');
        }
        
        return res=="" ? "0" : res;
    }

    public string ReverseString(string input)
    {
        char[] charArray= input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}