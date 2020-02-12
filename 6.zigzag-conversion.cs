using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution6
{
    public string Convert(string s, int numRows) {
        List<StringBuilder> strList = new List<StringBuilder>();
        int i = 0;
        for (i = 0; i < numRows; ++i)
        {
            strList.Add(new StringBuilder());
        }
        int n = s.Length;
        i = 0;
        while (i < n)
        {
            for (int j = 0; j < numRows && i < n; j++)
                strList[j].Append(s[i++]);
            for (int j = numRows - 2; j >= 1 && i < n; j--)
                strList[j].Append(s[i++]);
        }
        
        string zigzag = string.Empty ;
        foreach (var str in strList)
        {
            zigzag += str.ToString();
        }

        return zigzag;
    }
}