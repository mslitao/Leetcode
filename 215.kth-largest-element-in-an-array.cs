using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution215
{
    public void swap(int[] nums, int i , int j)
    {
        var tmp = nums[i];
        nums[i] =nums[j];
        nums[j]= tmp;
    }
    
    public int FindKthLargest_2ndTry(int[] nums, int k) {
        int left =0;
        int right = nums.Length - 1;
        while(true)
        {
            int pos = Partition(nums, left, right);
            if(pos == k - 1) return nums[pos];
            else if (pos > k -1)  right = pos -1;
            else left = pos + 1;
        }
    }

    public int Partition(int[] nums, int left, int right)
    {
        int pivot = nums[left];
        int l = left + 1;
        int r = right;
        while (l <= r) {
            if (nums[l] < pivot && nums[r] > pivot) {
                swap(nums, l++, r--);
            }
            if (nums[l] >= pivot) ++l;
            if (nums[r] <= pivot) --r;
        }
        swap(nums, left, r);
        return r;
    }


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
    
    
}