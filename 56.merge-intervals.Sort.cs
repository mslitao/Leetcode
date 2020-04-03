using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution56_2
{
    public class Interval {
       public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }
    
    void QuickSortIntervalsByBegining(IList<Interval> intervals, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(intervals, low, high);
            QuickSortIntervalsByBegining(intervals, low, p - 1);
            QuickSortIntervalsByBegining(intervals, p + 1, high);
        }
    }

    void Swap(IList<Interval> intervals, int i, int j)
    {
        var temp = intervals[i];
        intervals[i] = intervals[j];
        intervals[j] = temp;
    }

    int Partition(IList<Interval> intervals, int low, int high)
    {
        int val = intervals[low].start;
        Swap(intervals, low, high);
        int i = low;
        int j = high;
        while (i < j)
        {
            while (i < j && intervals[i].start <= val) i++;
            while (i < j && intervals[j].start >= val) j--;
            Swap(intervals, i, j);
        }

        Swap(intervals, i, high);
        return i;
    }
    public IList<Interval> Merge(IList<Interval> intervals)
    {
        QuickSortIntervalsByBegining(intervals, 0, intervals.Count -1);

        IList<Interval> results = new List<Interval>();
        int start = -1;
        int end = -1;
        foreach (var interval in intervals)
        {
            if (start == -1)
            {
                start = interval.start;
                end = interval.end;
            }
            else if (interval.start <= end)
            {
                if (interval.end > end)
                {
                    end = interval.end;
                }
            }
            else if (interval.start > end)
            {
                var item = new Interval(start, end);
                results.Add(item);
                start = interval.start;
                end = interval.end;
            }
        }

        if (start != -1)
        {
            var item = new Interval(start, end);
            results.Add(item);
        }


        return results;
    }
}