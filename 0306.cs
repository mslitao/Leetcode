/*Q: Given an array, print the Next Greater Element for every element. 
The Next greater Element for an element x is the first greater element on the right side of x in array. 
Elements for which no greater element exist, consider next greater element as -1.

Xi<  Xj j< i

Solution 1: use 


for i
    for j i+1 
    
Solution 2:
1. set with the end of the arrary i: n-1 to 0
2. upadte numbders i-1 to 0,  
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution0306
{

    public List<int> FindNextGreaterElement(List<int> numbers)
    {
        if(numbers == null || numbers.Count ==0) return numbers;
        int[] results = new int[numbers.Count];
        Array.Fill(results, -1);
        
        for(int i =0; i < results.Length -1 ; ++i)
            for(int j = i + 1; i < results.Length; ++j)
            {
                if(numbers[j]> numbers[i])
                {
                    results[i] = numbers[j];
                    break;
                }
            }
            
        return results.ToList();
    }


    // Using the Stack
    // 1 2 1 4 3 6 2 2
    // 1
    public List<int> FindNextGreaterElementUsingStack(List<int> numbers)
    {
        if(numbers == null || numbers.Count ==0) return numbers;
        int[] results = new int[numbers.Count];
        Array.Fill(results, -1);
        
        // Stack contains the index of each numbers
        Stack<int> stack = new Stack<int>();
        for(int i =0; i < results.Length ; ++i)
        {
            Stack<int> tmp = new Stack<int>();
            while(stack.Any())
            {
                var index = stack.Pop();
                // If the historic nunber or nunber in the stack is less than the current number
                // Update the index
                if(numbers[index] < numbers[i])
                {
                    results[index] = numbers[i];
                }
                else
                {
                    tmp.Push(index);
                }
            }
            stack = tmp;
            
            stack.Push(i);
        }
            
        return results.ToList();
    }
}
