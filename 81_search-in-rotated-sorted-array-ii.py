from typing import List


class Solution:
    def search(self, nums: List[int], target: int) -> bool:
        if not nums or len(nums) == 0 : return False

        return self.binarySearch(nums, target, 0, len(nums) -1 )
    def binarySearch(self, nums, target, left, right) :
        if right < left : return False
        if right == left : return nums[left] == target
        middle = (left + right) // 2
        if nums[middle] == target: return True
        elif nums[middle] < target:
            return self.binarySearch(nums, target, middle + 1, right) or (nums[left] >= nums[right] and self.binarySearch(nums, target, left, middle -1))
        else:
            return self.binarySearch(nums, target, left, middle - 1) or (nums[left] >= nums[right] and self.binarySearch(nums, target, middle + 1, right))
        