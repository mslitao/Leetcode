public class Solution1342 
{
    public int NumberOfSteps (int num) {
        int steps = 0;
        while(num > 0)
        {
            if(num % 2 == 1)
            {
                num--;
                steps++;
            }

            if(num > 0)
            {
                num = num / 2;
                steps++;
            }
        }

        return steps;
    }
}