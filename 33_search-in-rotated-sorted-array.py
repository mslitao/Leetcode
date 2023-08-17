class Solution:
    def search(self, nums: List[int], target: int) -> int:
        return self.binarySearch(nums, target, 0, len(nums) -1 )
    
    def binarySearch(self, nums, target,  start, end):
        if start > end: return -1
        middle = (start + end) // 2
        if nums[middle] == target:
            return middle
        
        hasReverse = nums[start] > nums[end]
        res = -1
        if nums[middle] < target:
            res = self.binarySearch(nums, target, middle + 1, end)

            if res == -1 and hasReverse:
                res = self.binarySearch(nums, target, start, middle -1)
        else:
            res = self.binarySearch(nums, target, start, middle -1)  
            if res == -1 and hasReverse:
                res = self.binarySearch(nums, target, middle + 1, end)
        
        return res
        
