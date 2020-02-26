using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution739
{
    public int[] DailyTemperatures(int[] T) {
        List<List<int>> temperatureDates = new List<List<int>>();
        for(int i = 30; i <=100; ++i)
        {
            temperatureDates.Add(new List<int>());
        }

        int[] results = new int[T.Length];
        Array.Fill(results, 0);
        for(int i =0; i < T.Length; ++i)
        {
            var temp = T[i];
            for(int t = 30; t< temp; ++t)
            {
                var dates = temperatureDates[t-30];
                var newDates = new List<int>();
                var diff = temp - t;
                foreach(var dt in dates)
                {
                    results[dt] = i - dt;
                }
                temperatureDates[t-30] = new List<int>();
            }

            var tempDates = temperatureDates[temp-30];
            tempDates.Add(i);
            temperatureDates[temp-30] = tempDates;
        }

        return results;
    }
}