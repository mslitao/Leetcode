class Solution:
    def getPermutation(self, n: int, k: int) -> str:
        res = ''
        num =[str(i+1) for i in range(9)]
        f = [1] * n

        for i in range(1,n):
            f[i] = f[i-1] *i
        k-=1
        i = n
        while i >=1:
            j = k // f[i-1]
            k = k % f[i-1]
            res = res + num[j]
            num.pop(j)
            i -=1

        return res

instance = Solution()
print(instance.getPermutation(3,3))
print(instance.getPermutation(4,9))