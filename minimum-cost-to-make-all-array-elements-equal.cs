//https://www.geeksforgeeks.org/minimum-cost-to-make-all-array-elements-equal/
using System;
using System.Collections.Generic;
using System.Linq;


// To execute C#, please define "static void Main" on a class
// named Solution.

public class Solution0309_3
{
    public static int MinCost(List<int> numbers)
    {
        if(numbers == null || numbers.Count <= 1) return 0;

        int odds = 0;
        int evens =0;
        foreach(var num in numbers)
        {
            if(num % 2 ==0) evens ++;
            else odds ++;
        }

        return Math.Min(odds, evens);
    }
}