using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution877
{
    public bool StoneGame(int[] piles) {
        return PlayStoneGame(piles, 0,0,0, piles.Length-1, 0);
    }

    public bool PlayStoneGame(int[] piles, int cur0, int cur1, int left, int right, int player) {
        if (left > right) return cur0 > cur1;
        if (player == 0) {
            return PlayStoneGame(piles, cur0 + piles[left], cur1, left + 1, right, 1) 
            || PlayStoneGame(piles, cur0 + piles[right], cur1, left + 1, right, 1);
        } 
        else {
            return PlayStoneGame(piles, cur0, cur1 + piles[left], left, right - 1, 0) 
            || PlayStoneGame(piles, cur0, cur1 + piles[right], left, right - 1, 0);
        }
    }
}