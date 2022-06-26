using System;

namespace ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var value = random.Next(int.MinValue, int.MaxValue);
            var result = ToString(value);
            var type = result.GetTypeCode();
            var resultReverse = ToStringReverse(value);
        }
        static string ToString(int value)
        {
            var nums = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var result = string.Empty;
            if (value == 0)
            {
                result = nums[0];
            }
            else
            {
                var isNegative = false;
                if (value < 0)
                {
                    isNegative = true;
                    value = -value;
                }
                while (value != 0)
                {
                    result = nums[value % 10] + result;
                    value /= 10;
                }
                if (isNegative)
                {
                    result = "-" + result;
                }
            }
            return result;
        }
        static string ToStringReverse(int value)
        {
            var nums = new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            var result = string.Empty;
            if (value == 0)
            {
                result = nums[0];
            }
            else
            {
                var isNegative = false;
                if (value < 0)
                {
                    isNegative = true;
                    value = -value;
                }
                while (value != 0)
                {
                    result += nums[value % 10];
                    value /= 10;
                }
                if (isNegative)
                {
                    result += "-";
                }
            }
            return result;
        }
    }
}
