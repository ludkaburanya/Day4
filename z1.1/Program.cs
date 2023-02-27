namespace z1
{
    class Program
    {
        static double min(double a, double b)
        {
            return (a < b) ? a : b; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x=");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y=");
            double y = double.Parse(Console.ReadLine());
            double z = min(3 * x, 2 * y) + min(x - y, x + y);
            Console.WriteLine("В данном случае z будет равняться:" + z);
        }
    }
}