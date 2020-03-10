using System;
using System.Collections.Generic;
using System.Linq;


// To execute C#, please define "static void Main" on a class
// named Solution.

public class Solution0309_2
{
    static void Main(string[] args)
    {
        TestFindMax(new List<int>{1,2,3,4,5}, 5);
        TestFindMax(new List<int>{1,2,3,4,5, 2,1}, 5);
        
        TestFindMax(new List<int>{}, -1);
        TestFindMax(null, -1);
    }
    
    public static void TestFindMax(List<int> numbers, int expected)
    {
        var result = FindMax(numbers);
        
        Console.Write("Input:");
        Console.WriteLine(numbers == null ? "NA":string.Join(" ", numbers));
        Console.WriteLine(string.Format("RESULT: {0} vs EXPECTED: {1}", result, expected));
    }
    
    public static int FindMax(List<int> numbers)
    {
        if(numbers == null || numbers.Count == 0)
            return -1;
        
        var index = FindMax(numbers, 0, numbers.Count-1);
        
        return numbers[index];
    }
    
    public static int FindMax(List<int> numbers, int left, int right)
    {
        if(left == right)
        {
            return left;
        }

        if(right == left + 1)
        {
            return numbers[left] > numbers[right]? left: right;
        }

        int middle = left + (right - left)/2;
        if(numbers[middle] > numbers[middle - 1] && numbers[middle] > numbers[middle + 1])
        {
            return middle;
        }
        else if(numbers[middle] > numbers[middle - 1] && numbers[middle] < numbers[middle + 1])
        {
            return FindMax(numbers, middle + 1, right);
        }
        else
        {
            return FindMax(numbers, left, middle -1);
        }
    }
}

