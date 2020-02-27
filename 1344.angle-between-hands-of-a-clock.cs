using System;
using System.Linq;


public class Solution1344 {
    public double AngleClock(int hour, int minutes) {
        double res = Math.Abs(minutes * 6 - (hour % 12) * 30 - 0.5 * minutes);
        return res > 180 ? 360 - res : res;
    }
}