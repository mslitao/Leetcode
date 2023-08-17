from typing import List


class Solution:
    def grayCode(self, n: int) -> List[int]:
        res = [0]
        for i in range(n):
            j = len(res) -1
            while j >=0:
                res.append(2**i + res[j])
                j -= 1
        
        return res

instance = Solution()
print('next->')
print(instance.grayCode(1))
print('next->')
print(instance.grayCode(2))
print('next->')
print(instance.grayCode(3))
