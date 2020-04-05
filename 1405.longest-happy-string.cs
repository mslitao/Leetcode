using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1405
{
    public string LongestDiverseString(int a, int b, int c) {
        StringBuilder sb = new StringBuilder();
        
        Dictionary<char, int> map = new Dictionary<char, int>();
        if(a > 0) map.Add('a', a);
        if(b > 0) map.Add('b', b);
        if(c > 0) map.Add('c', c);

        var lastC = ' ';
        while( a + b + c > 0)
        {
            int cnt = 0;
            char ch = ' ';
            if(lastC != 'a' && a > cnt)
            {
                cnt = a;
                ch = 'a';
            }
            if(lastC != 'b' && b > cnt)
            {
                cnt = b;
                ch = 'b';
            }

            if(lastC != 'c' && c > cnt)
            {
                cnt = c;
                ch = 'c';
            }
            
            if(cnt ==0) break;
            sb.Append(ch);
            if(ch == 'a') a--;
            if(ch == 'b') b--;
            if(ch == 'c') c--;
            lastC = ch;
        }

        char leftChar = ' ';
        int leftCnt = 0;
        if(a > 0)
        {
            leftChar = 'a';
            leftCnt =a;
        }
        if(b > 0)
        {
            leftChar = 'b';
            leftCnt =b;
        }

        if(c > 0)
        {
            leftChar = 'c';
            leftCnt =c;
        }
        int len = sb.Length;
        for(int i = 0; i < len && leftCnt > 0; ++i)
        {
            if(sb[i] == leftChar)
            {
                sb.Insert(i,leftChar);
                leftCnt --;
                i ++;
                len ++;
            }
        }

        return sb.ToString();
    }
}