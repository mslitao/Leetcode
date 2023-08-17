from typing import List


class Solution:
    def firstMissingPositive(self, nums: List[int]) -> int:
        size = len(nums)
        for i in range(size):
            if nums[i] == i+1 : continue
            if nums[i] < 1 or nums[i] > size: 
                nums[i] = -1
                continue
            
            target = nums[i]
            nums[i] = -1
            while target > 0 and target <= size and nums[target -1] != target:
                tmp = nums[target -1]
                nums[target -1] = target

                target = tmp

        for i in range(size):
            if nums[i] == -1:
                return i+1
        
        return size + 1

instance = Solution()
print(instance.firstMissingPositive([3,4,-1,1]))

