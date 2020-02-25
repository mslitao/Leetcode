using System;
using System.Collections.Generic;
using System.Linq;

public class Solution416
{
    // The problem here is that each number can have only 2 possibility 
    // either belongs to subset 1, either belongs to subset 2.
    // if SUM(subset1) == SUM(subset2)
    // We can make subset 1 a postive sets.
    // And subset 2 a megatove sets.
    public bool CanPartition(int[] nums) {
        HashSet<int> subDiffs = new HashSet<int>();
        subDiffs.Add(0);

        foreach(int num in nums)
        {
            var newDiffs = new HashSet<int>();
            foreach(var diff in subDiffs)
            {
                newDiffs.Add(diff+ num);
                newDiffs.Add(diff- num);
            }

            subDiffs = newDiffs;
        }

        return subDiffs.Contains(0); 
    }
}