from typing import List


class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        idx = 0
        for i in range(len(nums)):
            
            if i == 0 or nums[i] != nums[idx-1]:
                print(idx)
                print(i)
                print(nums)
                nums[idx] = nums[i]
                idx +=1
        
        return idx

instance = Solution()

print(instance.removeDuplicates([0,0,1,1,1,2,2,3,3,4]))