from typing import List


class Solution:
    def trap(self, height: List[int]) -> int:
        size = len(height)
        stack = []
        res = 0
        for i in range(size):
            cur = height[i]
            
            while len(stack) > 0 and cur > height[stack[-1]]:
                top = stack.pop()

                if len(stack) == 0: break

                distance = i - stack[-1] -1
                bound = min(cur, height[stack[-1]]) - height[top]

                res += distance* bound
            stack.append(i)
        
        return res

instance = Solution()
print(instance.trap([0,1,0,2,1,0,1,3,2,1,2,1]))