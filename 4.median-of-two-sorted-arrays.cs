//4. Median of Two Sorted Arrays
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution4 {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var A = nums1;
        var B = nums2;
        int m = nums1.Length;
        int n = nums2.Length;
        if (m > n)
        { 
            // to ensure m<=n
            int[] temp = A; A = B; B = temp;
            int tmp = m; m = n; n = tmp;
        }
        
        int iMin = 0, iMax = m, halfLen = (m + n + 1) / 2;
        
        while (iMin <= iMax)
        {
            int i = (iMin + iMax) / 2;
            int j = halfLen - i;
            if (i < iMax && B[j - 1] > A[i])
            {
                iMin = iMin + 1; // i is too small
            }
            else if (i > iMin && A[i - 1] > B[j])
            {
                iMax = iMax - 1; // i is too big
            }
            else
            { // i is perfect
                int maxLeft = 0;
                if (i == 0) { maxLeft = B[j - 1]; }
                else if (j == 0) { maxLeft = A[i - 1]; }
                else { maxLeft = Math.Max(A[i - 1], B[j - 1]); }
                
                if ((m + n) % 2 == 1) { return maxLeft; }

                int minRight = 0;
                if (i == m) { minRight = B[j]; }
                else if (j == n) { minRight = A[i]; }
                else { minRight = Math.Min(B[j], A[i]); }

                return (maxLeft + minRight) / 2.0;
            }
        }
        
        return 0.0;
    }

    public double FindMedianSortedArraysV2(int[] nums1, int[] nums2) {
        int m = nums1.Length, n = nums2.Length;
        int left = (m + n + 1) / 2, right = (m + n + 2) / 2;
        return (FindKthInSortedArray(nums1, m,  0, nums2, n,  0, left) + FindKthInSortedArray(nums1, m, 0, nums2, n,  0, right)) / 2.0;
    }

    // the only partition trick is to devide it by k instead of by each size.
    public int FindKthInSortedArray(int[] nums1, int m,  int i, int[] nums2, int n, int j, int k) {
        if (i >= m) return nums2[j + k - 1];
        if (j >= n) return nums1[i + k - 1];
        if (k == 1) return Math.Min(nums1[i], nums2[j]);
        
        // to make the too short one will not being filtered out.
        int midVal1 = (i + k / 2 - 1 < m) ? nums1[i + k / 2 - 1] : int.MaxValue;
        int midVal2 = (j + k / 2 - 1 < n) ? nums2[j + k / 2 - 1] : int.MaxValue;

        // everytime, try to weed out or filter out k/2
        // The process is to filter out k/2 from the smaller part. 
        if (midVal1 < midVal2) {
            return FindKthInSortedArray(nums1, m, i + k / 2, nums2, n, j, k - k / 2);
        } else {
            return FindKthInSortedArray(nums1, m, i, nums2, n,  j + k / 2, k - k / 2);
        }
    }
}