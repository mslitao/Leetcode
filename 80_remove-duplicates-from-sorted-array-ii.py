from typing import List


class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        m = len(nums)
        if m <=2: return m

        start = 0
        prev = nums[0]
        cnt = 1
        for i in range(1, m):
            if nums[i] != prev:
                start +=1
                nums[start] = prev = nums[i]
                cnt = 1
            elif cnt == 1:
                start +=1
                nums[start] = nums[i]
                cnt += 1
        
        return start + 1
        