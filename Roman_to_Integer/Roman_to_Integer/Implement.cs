﻿namespace Roman_to_Integer
{
    public class Implement
    {
        public int RomanToInt(string s)
        {
            char[] symbols = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] values = { 1, 5, 10, 50, 100, 500, 1000 };
            int sum = 0;

            if (s.Length == 1)
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    if (s == symbols[i].ToString())
                    {
                        return values[i];
                    }
                }
            }
            else
            {

                for (int i = 0; i < s.Length; i++)
                {
                    int leftNumber = 0;
                    int rightNumber = 0;
                    int k = 0;
                    for (int j = 0; j < symbols.Length; j++)
                    {
                        if (s[i] == symbols[j])
                        {
                            leftNumber = values[j];
                        }
                        if (i + 1 != s.Length)
                        {
                            if (s[i + 1] == symbols[j])
                            {
                                rightNumber = values[j];
                            }
                        }
                    }

                    if (leftNumber < rightNumber)
                    {
                        sum += rightNumber - leftNumber;
                        i++;
                    }
                    else
                    {
                        sum += leftNumber;
                    }
                }
            }

            return sum;
        }
    }
}
