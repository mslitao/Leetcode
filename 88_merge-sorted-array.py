from typing import List


class Solution:
    def merge2(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        i = m - 1
        j = n - 1
        k = m + n - 1
        while i >=0 and j >=0:
            if nums1[i] >= nums2[j]:
                nums1[k] = nums1[i]
                k -= 1
                i -= 1
            else:
                nums1[k] = nums2[j]
                k -= 1
                j -= 1
        while j >=0:
            nums1[k] = nums2[j]
            j -=1
            k -=1
        
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int) -> None:
        """
        Do not return anything, modify nums1 in-place instead.
        """
        i = j = 0
        idx = 0
        k = 0
        k1 = 0
        while idx < m + n:
            # print(idx)
            if k >0 and k1 < k:
                if j > n or nums2[k1] <= nums2[j]:
                    nums1[idx] = nums2[k1]
                    nums2[k1] = -1
                    k1 +=1
                else:
                    nums1[idx] = nums2[j]
                    j +=1
            else:
                if i < m and nums1[i] <= nums2[j]:
                    nums1[idx] = nums1[i]
                    i += 1
                else:
                    if idx < m:
                        next = nums2[j]
                        nums2[k] =  nums1[idx]
                        nums1[idx] = next
                        j += 1
                        i += 1
                        k += 1
                    else:
                        nums1[idx] = nums2[j]
                        j += 1

            # print(nums1)
            # print(nums2)
            idx += 1


instance = Solution()
nums1 = [1,2,3,0,0,0]
nums2 = [2,5,6]
instance.merge2(nums1, 3, nums2, 3)
print(nums1)