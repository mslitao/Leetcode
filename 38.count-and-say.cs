using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution38
{
    public string CountAndSay(int n) {
        string str = "1";
        for(int i =1; i <n; ++i)
        {
            StringBuilder sb = new StringBuilder();
            char c = str[0];
            int cnt = 1;
            for(int k =1; k < str.Length ; ++ k)
            {
                if(str[k] != c && c != ' ')
                {
                    sb.Append(cnt.ToString());
                    sb.Append(c);
                    c = str[k];
                    cnt = 1;
                }
                else if(str[k] == c)
                {
                    cnt ++;
                }
            }
            if(cnt > 0)
            {
                sb.Append(cnt.ToString());
                sb.Append(c);
            }
            str = sb.ToString();
        }

        return str;
    }
}