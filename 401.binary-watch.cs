using System;
using System.Collections.Generic;
using System.Linq;

public class Solution401
{
    public IList<string> ReadBinaryWatch(int num) 
    {
        HashSet<string> results = new HashSet<string>();
        if(num < 0 || num > 10) return results.ToList();
        if(num == 0)
        {
            results.Add("0:00");
            return results.ToList();
        }

        int[] digits = new int[] {-1, -2, -4, -8, 1, 2, 4, 8, 16, 32};
        List<int> selected = new List<int>();
        
        BackTrackReadBinaryWatch(0, 10, num, selected, digits, results);

        return results.ToList();
    }

    public void BackTrackReadBinaryWatch(int current, int size, int num, List<int> selected,  int[] digits, HashSet<string> results)
    {
        if(selected.Count == num)
        {
            var hour = 0;
            var mins = 0;
            foreach(var s in selected)
            {
                if(s < 0)
                {
                    hour -= s;
                }
                else
                {
                    mins += s;
                }
            }
            
            if(hour <= 11 && mins <= 59)
                results.Add(string.Format("{0}:{1}",
                                      hour.ToString(), 
                                      mins< 10 ? "0" + mins.ToString() : mins.ToString()));
            
            return;
        }

        for(int i =  current; i < size;  i++)
        {
            selected.Add(digits[i]);
            BackTrackReadBinaryWatch(i + 1, size, num, selected, digits, results);
            selected.Remove(digits[i]);
        }
    }
}