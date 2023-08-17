from typing import List


class Solution:
    def permute(self, nums: List[int]) -> List[List[int]]:
        items = [[]]
        for i in range(len(nums)):
            while len(items[0]) == i:
                tmp = items.pop(0)
                for num in nums:
                    if num not in tmp:
                        newItem = tmp[:]
                        newItem.append(num)
                        items.append(newItem)

            i+=1
        
        return items

instance = Solution()
print(instance.permute([1,2,3,4]))