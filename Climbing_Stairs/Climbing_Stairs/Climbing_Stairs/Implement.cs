namespace Climbing_Stairs
{
    public class Implement
    {
        public int ClimbStairs(int n)
        {
            int first = 1;
            int second = 2;
            int result = 0;

            if (n == 1)
                return first;
            if (n == 2)
                return second;

            for (int i = 2; i < n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }

            return result;
        }
    }

}
