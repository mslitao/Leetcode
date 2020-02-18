using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution189 
{
    public void Rotate(int[] nums, int k) {
        int[] a = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            a[(i + k) % nums.Length] = nums[i];
        }
        for (int i = 0; i < nums.Length; i++) {
            nums[i] = a[i];
        }
    }
}