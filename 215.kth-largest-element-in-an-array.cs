using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution215
{
    public int FindKthLargest(int[] nums, int k) {
        QuickSort(nums, 0, nums.Length -1);

        //Console.WriteLine(string.Join('-', nums));
        return nums[nums.Length - k];
    }

    public void QuickSort(int[] nums, int start, int end)
    {
        int left = start;
        int right = end;
        if(left < right)
        {
            int middle = QuickSortPartion(nums, start, end);

            if(middle > 0)
            {
                QuickSort(nums, start, middle);
            }

            if(middle < end -1)
            {
                QuickSort(nums, middle + 1, end);
            }
        }
    }

    public int QuickSortPartion(int[] nums, int start, int end)
    {
        int pivot = nums[start];
        int left = start; 
        int right = end;
        while(true)
        {
            while(nums[left] < pivot)
            {
                left ++;
            }
            while(nums[right] >= pivot && right >start)
            {
                right --;
            }

            if (left < right)
            {
                swap(nums, left, right);
            }
            else
            {
                return right;
            }
        }
    }
    
    public void swap(int[] nums, int i , int j)
    {
        var tmp = nums[i];
        nums[i] =nums[j];
        nums[j]= tmp;
    }
}