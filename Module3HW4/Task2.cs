using System;

namespace Module3HW4
{
    public class Task2
    {
        public event Func<int, int, int> Count;
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int MethodsSum(int x, int y)
        {
            var sum = 0;
            foreach (Func<int, int, int> function in Count.GetInvocationList())
            {
                sum += function(x, y);
            }

            Console.WriteLine(sum);
            return sum;
        }

        public void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Run(int x, int y)
        {
            Count += Sum;
            Count += Sum;
            TryCatch(() => MethodsSum(x, y));
        }
    }
}