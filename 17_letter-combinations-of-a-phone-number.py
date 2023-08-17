from typing import List


class Solution:
    def letterCombinations(self, digits: str) -> List[str]:
        phone = {'2': 'abc', '3': 'def', '4': 'ghi', '5': 'jkl', 
             '6': 'mno', '7': 'pqrs', '8': 'tuv', '9': 'wxyz'}
        if not digits:
            return []

        queue = []
        queue.append('')

        for i in range(len(digits)):
            while len(queue[0]) == i:
                tmp = queue.pop(0)
                for j in range(len(phone[digits[i]])):
                    queue.append(tmp + phone[digits[i]][j])

        return queue