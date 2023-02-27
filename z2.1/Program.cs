namespace z2
{
    class Program
    {
        static double f(double x)
        {
            double y;
            if (x >= 0.9) y = 1 / Math.Pow(1 + x, 2);
            else if (x >= 0) y = 0.2 * x + 0.1;
            else y = x * x + 0.2;
            return y;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите h:");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
        }
    }
}