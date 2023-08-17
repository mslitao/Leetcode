from typing import List


class Solution:
    def nextPermutation(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        """
        if len(nums) < 2: return nums

        i = j = len(nums) -1 
        while i >0:
            if nums[i] > nums[i-1]: break
            i -=1
        
        if i == 0:
            nums.reverse()
            return

        while j>=0:
            if nums[j] > nums[i -1]: break
            j -=1

        nums[i-1], nums[j] = nums[j], nums[i-1]

        j = len(nums) -1
        while i < j:
            nums[i], nums[j] = nums[j], nums[i]
            i+=1
            j-=1
        
        return



instance = Solution()
test = [1,2,3]
instance.nextPermutation(test)
print(test)

test = [1,3, 2]
instance.nextPermutation(test)
print(test)