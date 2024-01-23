namespace Two_Sum_And_Palindrome_Number
{
    public class Implement
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else
            {
                int revers = 0;
                int num = x;
                int remein;
                while (num > 0)
                {
                    remein = num % 10;
                    num /= 10;
                    revers = (revers * 10) + remein;
                }
                if (revers == x)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public int[] TwoSum(int[] nums, int target)
        {
            int firstIndext = 0;
            int secondIndext = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        firstIndext = i;
                        secondIndext = j;
                        break;
                    }
                }
            }
            int[] result = new int[] { firstIndext, secondIndext };
            return result;
        }
    }
}

