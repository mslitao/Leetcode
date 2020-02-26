using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution758
{
    public string BoldWords(string[] words, string S)
    {
        int[] datasets = new int[S.Length];
        HashSet<string> dict = new HashSet<string>();
        foreach (var word in words)
        {
            dict.Add(word);
        }

        for (int i = 0; i < S.Length; ++i)
        {
            datasets[i] = 0;
        }

        string[] window = new string[10];
        for (int i = 0; i < S.Length; ++i)
        {
            for (int k = 0; k < 10 && i + k < S.Length; ++k)
            {
                var str = S.Substring(i, k + 1);
                if (dict.Contains(str))

                    for (int index = i; index <= i + k; ++index)
                    {
                        datasets[index] = 1;
                    }
            }
        }

        StringBuilder sb = new StringBuilder();
        int start = -1; int end = -1;
        for (int i = 0; i < S.Length; ++i)
        {
            if (datasets[i] == 1)
            {
                if (start == -1)
                {
                    start = i;
                    sb.Append("<b>");
                    sb.Append(S[i]);
                }
                else
                {
                    sb.Append(S[i]);
                }
            }
            else
            {
                if (start != -1)
                {
                    sb.Append("</b>");
                    sb.Append(S[i]);
                    start = -1;
                }
                else
                {
                    sb.Append(S[i]);
                    start = -1;
                }
            }
        }
        if (start != -1)
        {
            sb.Append("</b>");
        }

        
        return sb.ToString();
    }
}