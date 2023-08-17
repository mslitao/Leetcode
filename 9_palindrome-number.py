class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x<0: return False

        tmp = x
        y=0
        while tmp >0:
            y = y*10 + tmp%10
            tmp = tmp // 10
        
        return x==y
        