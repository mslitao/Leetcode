using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution68
{
    public IList<string> FullJustify(string[] words, int maxWidth) 
    {
        IList<string> results = new List<string>();
        List<string> items = new List<string>();
        StringBuilder sb = new StringBuilder();
        
        int i =0;
        while(i< words.Length)
        {
            var size = words[i].Length;
            items.Add(words[i]);

            while(i + 1 < words.Length && size + 1 + words[i+1].Length <= maxWidth)
            {
                i++;
                size = size + 1+ words[i].Length;
                items.Add(words[i]);
            }
            i++;
                
            if(i == words.Length)
            {
                sb.Append(string.Join(' ', items));
                for(int j =size; j < maxWidth; ++j)
                {
                    sb.Append(' ');
                }
                results.Add(sb.ToString());
                break;
            }

            var str = "";
            int left = 0;
            if(items.Count == 1)
            {
                for(int j =0; j< maxWidth - size; ++j) 
                str +=' ';
            }
            else
            {
                int cnt = (maxWidth - size + items.Count - 1) / (items.Count - 1);
                left = (maxWidth - size + items.Count - 1) % (items.Count - 1);
                    
                for(int j =0; j<cnt; ++j) str +=' ';
            }

            for(int j =0; j < items.Count; ++j)
            {
                if(j < items.Count -1 || items.Count == 1)
                {
                    sb.Append(items[j]);
                    sb.Append(str);

                    if(j < left)
                    {
                        sb.Append(' ');
                    }
                }
                else
                {
                    sb.Append(items[j]);
                }
            }
            results.Add(sb.ToString());
            sb = sb.Clear();
            items.Clear();
        }

        return results;
    }
}