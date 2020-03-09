/*
// QUESTION: 
// INPUT: integer array A: property --> values are increasing, and then decreasing.
# EXAMPLE: [-12, -3, 0, 4, 26, 35, 81, 400, 92, -1]
# INPUT: integer x.
# Boolean function --> True if x in A. False otherwise.
*/

/*
Solution:
1. Binary Search
2. Change based on data inputs

Time Complexity O(log(n)) n is |A|

*/
    

using System;
using System.Collections.Generic;
using System.Linq;

class Solution0309
{
    static void Main(string[] args)
    {
        for (var i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello, World");
        }
        
        
        Console.WriteLine(TestFindNumber(new List<int>(){-12, -3, 0, 4, 26, 35, 81, 400, 92, -1}, 81, true));
        Console.WriteLine(TestFindNumber(new List<int>(){-12, -3, 0, 4, 26, 35, 81, 400, 92, -1}, 82, false));
        
        // 
        Console.WriteLine(TestFindNumber(new List<int>(){-12, -3, 0, 4, 26, 35, 81, 400}, -3, true));
        
        //Corner cases:
        Console.WriteLine(TestFindNumber(new List<int>(){}, 82, false));
        
        Console.WriteLine(TestFindNumber(null, 82, false));
    }
    
    //TDD
    public static bool TestFindNumber(List<int> numbers, int target, bool expected)
    {
        Console.WriteLine(numbers == null ? "NA": string.Join(" ", numbers));
        
        var result = FindNumber(numbers, target);
       
        Console.WriteLine(string.Format("Result: {0} - Expected: {1}", result, expected));
        
        return result == expected;
    }
    
    public static bool FindNumber(List<int> numbers, int target)
    {
        if(numbers == null || numbers.Count ==0)
        {
            return false;
        }
        
        return BinarySearch(numbers, 0, numbers.Count -1, target);
    }
    
    public static bool BinarySearch(List<int> numbers, int left, int right, int target)
    {
        if(left > right ) return false;
        
        int middle = left + (right - left)/2;
        if(numbers[middle] == target)
        {
            return true;
        }
        
        else if(numbers[middle] < target)
        {
            // search for right part
            bool tagRight = BinarySearch(numbers, middle + 1, right, target);
            
            bool tagLeft = false;
            // search for left part if not being sorted fully
            if(numbers[middle] < numbers[left])
            {
                tagLeft = BinarySearch(numbers, left, middle -1, target);
            }
            
            return tagLeft || tagRight;
        }
        else
        {   
            bool tagLeft = BinarySearch(numbers, left, middle -1, target);
            
            bool tagRight = false;
            if(numbers[middle] > numbers[right])
            {
                tagRight = BinarySearch(numbers, middle +1, right, target);
            }
            
            return tagLeft || tagRight;   
        }
    }
}
