from typing import List


class Solution:
    def canJump(self, nums: List[int]) -> bool:
        size = len(nums)
        reach = 0
        if size == 0: return True
        for i in range(size):
            if i > reach or reach >= size -1: break
            reach = max(reach, i + nums[i])
        
        return reach >= size -1

    def canJump2(self, nums: List[int]) -> bool:
        next = [0]

        while len(next) > 0:
            idx = next.pop(0)
            if idx >= len(nums) - 1:
                print(idx) 
                return True
            if nums[idx] < 1: continue 
            for i in range(1, nums[idx] + 1):
                next.append(idx + i)
            
            print(next)
            

        return False

instance = Solution()
# print(instance.canJump([3,2,1,0,4]))
print(instance.canJump([2,3,1,1,4]))



