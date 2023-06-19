using System;

namespace MethodsExercise
{
    public class MyMathClass
    {
        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static int Multiply(int a, int b)
        {
            int product = a * b;
            return product;
        }
        public static int Sum(params int[] sum)
        {
            int answer = 0;
            for (int i = 0; i < sum.Length; i++)
            {
                answer += sum[i];
            }

            return answer;
        }
        public static int Subtract(params int[] nums)
        {
            int answer = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                answer -= nums[i];
            }

            return answer;
        }
        public static int Divide(params int[] nums)
        {
            int answer = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                answer /= nums[i];
            }

            return answer;
        }

    }
  
}
