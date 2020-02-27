using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution912
{
    public IList<int> SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);

        return nums.ToList();
    }

    public void Merge(int[] nums, int l1, int r1, int l2, int r2)
    {
        
        int[] nums1 = new int[r1 - l1 + 1];
        int[] nums2 = new int[r2 - l2 + 1];

        //Console.WriteLine(nums1.Length);
        //Console.WriteLine(nums2.Length);
        
        int i1 = 0;
        for(int i =l1; i <= r1; ++i)
        {
            nums1[i1++] = nums[i];
        }
        int i2 = 0;
        for(int i =l2; i <= r2; ++i)
        {
            nums2[i2++] = nums[i];
        }
        
        i1--;
        i2--;
        int k = r2;
        while(i1 >=0 && i2>=0)
        {
            if(nums1[i1] >= nums2[i2])
            {
                nums[k--] = nums1[i1--];
            }
            else
            {
                nums[k--] = nums2[i2--];
            }
        }

        while(i1 >=0)
        {
            nums[k--] = nums1[i1--];
        }

        while(i2 >=0)
        {
            nums[k--] = nums2[i2--];
        }
    }
    
    public void MergeSort(int[] nums, int left, int right)
    {
        if(left < right)
        {
            int middle = left + (right - left) /2;
            //Console.ReadKey();


            //Console.WriteLine(string.Format("{0}-{1}-{2}", left, middle, right));
            MergeSort(nums, left, middle);
            MergeSort(nums, middle + 1, right);

            Merge(nums, left, middle, middle + 1, right);
        }
    }
}