

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution482
{
    public string LicenseKeyFormatting(string S, int K)
    {
         if (K == 1)
        {
            var sb = new StringBuilder();
            foreach(char c in S)
            {
                if (c != '-')
                {
                    sb.Append('-');
                    sb.Append(Char.ToUpper(c));
                }
            }

            return sb.ToString().Substring(1);
        }

        List<string> items = S.Split('-').ToList();
        var result = string.Empty;
        var tmp = "";
        for (int i = items.Count - 1; i >= 0; --i)
        {
            var str = items[i] + tmp;
            if (str.Length < K)
            {
                tmp = str;
                continue;
            }

            
            while (str.Length >= K)
            {
                var trunk = str.Substring(str.Length - K);
                result = trunk + "-" + result; 
                str = str.Substring(0, str.Length - K);
            }

            tmp = str;
        }

        result = tmp + "-" + result;
        return result.Trim('-').ToUpper();
    }
}