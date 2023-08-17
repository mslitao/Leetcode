class Solution:
    def reverse(self, x: int) -> int:
        if x >= 0:
            char_arr = str(x)[::-1]
        else:
            char_arr = '-' + str(x)[:0:-1]
            
        ans = int(char_arr)
        
        if ans > (1<<31) - 1 or ans < (1<<31) * -1:
            return 0
        else:
            return ans

instance = Solution()
print(instance.reverse(123))