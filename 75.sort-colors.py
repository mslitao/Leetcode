from typing import List


class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        i = 0
        start = 0
        end = len(nums) - 1
        while i <= end:
            if nums[i] == 0:
                nums[start], nums[i] = nums[i], nums[start]
                start += 1
                i += 1
            elif nums[i] == 2:
                nums[end], nums[i] = nums[i], nums[end]
                end -=1
            else:
                i +=1