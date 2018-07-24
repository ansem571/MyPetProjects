namespace MathLibrary.BasicFormulas
{
    public class FibonaciCalculator
    {
        public int Fib(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return Fib(n - 2) + Fib(n - 1);
        }
    }
}
