/*

Given a list of integers, find out the length of the longest consecutive elements sequence.

[11, 4, 20, 1, 3, 2] - 4 [1, 2, 3,4 ]

[11, 4, 20, 1, 3, 2, 2] - 5 [1, 2, 2, 3,4 ]

// Input list of int, output is int
// Ask the input data 
// max: n
// min: 1


// Step 1: Put all the values into Hashset<int>
// O(1) to access one value
// Step 2: iterate the list start with one number. O(n)
        Looking for the both left and right neightbors in the hashset
        Stop if I cannot find any consecutive elements on each side
        Remove the visited elment in the hashset<int>
        

// more for hashset

1. Hash Function: ()
2. 

*/ 

using System;
using System.Collections.Generic;



class Solution20200221
{
    static void Main(string[] args)
    {
        Console.WriteLine(TestFunc(null, 0, true));
        Console.WriteLine(TestFunc(new List<int>(){}, 0, true));
        
        Console.WriteLine(TestFunc(new List<int>(){1}, 1, true));
        Console.WriteLine(TestFunc(new List<int>(){1, 2}, 2, true));
        Console.WriteLine(TestFunc(new List<int>(){1, 2, 2}, 3, true));
        
        Console.WriteLine(TestFunc(new List<int>(){1, 3}, 1, true));
        Console.WriteLine(TestFunc(new List<int>(){1, 3, 3}, 2, true));
        
        
        Console.WriteLine(TestFunc(new List<int>(){11, 4, 20, 1, 3, 2}, 4, true));
        Console.WriteLine(TestFunc(new List<int>(){11, 4, 20, 1, 3, 2, 2, 1}, 6, true));
        Console.WriteLine(TestFunc(new List<int>(){11, 4, 20, 1, 3, 2, 5, 6}, 6, true));
        Console.WriteLine(TestFunc(new List<int>(){11, 4, 20, 1, 3, 2, 5, 6, 8}, 6, true));
        
        Console.WriteLine(TestFunc(new List<int>(){11, -1, -2, 4, 20, 0, 1, 3, 2, 5, 6, 8}, 9, true));
        // need to add test for both left and right
         Console.WriteLine(TestFunc(new List<int>(){11, -1, -2, 4, 20, 0, 1,1, 3, 2, 5, 6, 8}, 10, true));
    }
    
    public static bool TestFunc(List<int> inputs, int expected, bool enableLogging = false)
    {
        var result = GetLengthOfConsecutiveElements(inputs);
        if(enableLogging)
        {
            Console.WriteLine(inputs==null? "NULL": string.Join('-', inputs));
            Console.WriteLine(string.Format("Result: {0}, Expected: {1}", result, expected));
        }
        
        return result == expected;
    }
    
    /// Ask for comments needed or not? 
    // Time Complexity is O(n)
    // Space Complexity is O(n) 
    // n here is the length of nums n = |nums|
    /// Input is a list of integers
    /// Output is a length (integer)
    public static int GetLengthOfConsecutiveElements(List<int> nums)
    {
        // Exceptions (Make it production wise)
        int result = 0;
        if(nums== null || nums.Count == 0) return result;
        
        // Step 1: Put all the numbers into the Hashset
        //HashSet<int> hashset = new HashSet<int>();
        // key is the number, the value is the count or duplicates of the number.
        Dictionary<int, int> map = new Dictionary<int, int>(); // Better meaningful name to replace the comments. 
        // Hashset to Dictionary 
        // 
        foreach(var num in nums)
        {
            if(!map.ContainsKey(num))
            {
                map.Add(num, 1);
            }
            else
            {
                map[num] = map[num] + 1;
            }
        }
        
        // Step 2: Iterate the list to find the left and right neigbors
        foreach(var num in nums)
        {
            // Skip the number if already being visited before.
            if(!map.ContainsKey(num))
            {
                continue;
            }
            
            int cnt = map[num];
            // Remove the number in the hashset
            map.Remove(num);
            
            int left = num;
            int right = num;
            // Try to find the left and right boundary of the elements
            while(map.ContainsKey(left - 1))
            {
                left --;
                cnt += map[left];
                map.Remove(left);
            }
            
            while(map.ContainsKey(right + 1))
            {
                right++;
                cnt += map[right];
                map.Remove(right);
            }
            
            // Check the length and update this to the result if longer.
            result = Math.Max(result, cnt);
        }
        
        // Step 3: return the results.
        return result;
    }
}