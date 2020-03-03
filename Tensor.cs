/*
Given a tensor of shape [n_0, n_1, …, n_{m-1}], which has \prod_{i}n_i terms. For a term with global index j, write a piece of code to get its m-dimensional index [i_0, i_1, …, i_{m-1}]. 
e.g., 
For a tensor of shape [3,2], 
j -> 2-dim [i_0, i_1] 
0->[0,0] 0+0
1->[1,0] 1+0
2->[2,0] 2+0
3->[0,1] 0+3
4->[1,1] 1+3
5->[2,1] 2+3

def get_dim_index(j, shape):
*/

// Entry point name must be "Solution"
using System;
using System.Collections.Generic;
using System.Linq;

public static class Solution0303
{
    private static void Main()
    {
        Console.WriteLine("Hello, world!");
        // Tests 
        TestGetDimIndex(new List<int>(){3, 2}, 0, null);
        TestGetDimIndex(new List<int>(){3, 2}, 1, null);
        TestGetDimIndex(new List<int>(){3, 2}, 2, null);
        TestGetDimIndex(new List<int>(){3, 2}, 3, null);
        TestGetDimIndex(new List<int>(){3, 2}, 4, null);
        TestGetDimIndex(new List<int>(){3, 2}, 5, null);
        
        
        // test for corner cases
        
    }
    
    public static bool TestGetDimIndex(List<int> inputs, int j, List<int> expected)
    {
       
        var results = GetDimIndex(inputs, j);
        
        Console.WriteLine(String.Format("{0}, {1}", String.Join("-", inputs), j));
        Console.WriteLine(String.Join("-", results));
        
        return true;
    }
    
    
    public static int[] GetDimIndex(List<int> Dims, int j)
    {
        if(Dims ==null || Dims.Count ==0 || j < 0) return null;
        
        int[] results = new int[Dims.Count];
        //Array.Set(result, 0);
        
        int left = j;
        for(int i = 0; i < Dims.Count && left > 0; i ++)
        {
            if(Dims[i] <=0)  return null;
            
            var num1 = left % Dims[i];
            results[i] = num1;
            left = left / Dims[i];
        }
        
        if(left >0) return null;
        else return results;
    }
}
 