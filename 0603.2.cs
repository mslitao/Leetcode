using System;
using System.Collections.Generic;
using System.Linq;

Code Samples
/*

Given an array and a target number *efficiently* test
whether there is an uninterrupted sequence of elements from
the array that sums to the target.
 
[2,1,1,5,6], 1 => True
[2,1,1,5,6], 8 => False 
[2,1,1,5,6], 9 => True
[2,1,1,5,6], 10 => False
[2,1,1,5,6], 14 => False
*/

/*
Input: array of intergers, number 
Output: True or False
Goal: SubSequence which has sum of to the target number
Corner: empty list-> False? 

Solution:
BF: N^3 check all the sum of range SUM(arr[i,.. j])  
N^3: i, j (start end) n^2 , perform sum is n 

Better solution:
N^2, Memorized way to do the sum
Sum[n,n] 


improved solution
left subsequence, target subsequence, right subsequence
 
 SUM(Arr) - SUM(Arr.left) - SUM(Arr.right) == target
 i, j
 sum(n -1)- sum(i) - (sum(n-1) - sum(j)) = sum[j] - sum[i] 
 
[2,1,1,5,6]
 2, 
 sum(i) = sum(i-1) + arr[i]
 sum

*/

public bool CheckSumOfSubSequenceEqualToTarget(List<int> inputs, int target)
{
    if(inputs == null || inputs.Length == 0) 
        return false;
    
    // Todo: remove the list  (no need to use the whole list with n elements)
    int[] sum = new int[inputs.Length + 1];
    sum[0] = 0;
    
    Hashset<int> sumSets = new Hashset<int>();
    sumSets.Add(0);
    
    for(int i = 0; i < inputs.Length; ++ i)
    {
        sum[i + 1] = sum[i] + inputs[i];
        
        if(sumSets.Contains(sum[i + 1] - target))
        {
            return true;
        }
        
        sumSets.Add(sum[i + 1]);
    }
    
    return false;
}


public bool TestCheckSumOfSubSequenceEqualToTarget(List<int> inputs, int target, bool expected)
{
    var result = CheckSumOfSubSequenceEqualToTarget(inputs, target);
    
    return expected == result;
}    



public void Test()
{
    // Single number
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {2,1,1,5,6}, 1, true);
    
    
    // range in the between
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {2,1,1,5,6}, 8, false);
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {2,1,1,5,6}, 9, true);
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {2,1,1,5,6}, 10, false);
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {2,1,1,5,6}, 14, false);
    
    // all the numbers
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {2,1,1,5,6}, 15, true);
    
    // Corner cases of null or empty array
    TestCheckSumOfSubSequenceEqualToTarget(new List<int>(), 15, false);
    TestCheckSumOfSubSequenceEqualToTarget(null, 15, false);
    
    // egative numbers
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {-2, 2,1,1,5,6}, 0, true);
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {1, -2, 2,1,1,5,6}, 0, true);
    TestCheckSumOfSubSequenceEqualToTarget(new List<int> {1, -1}, 0, true);
}
