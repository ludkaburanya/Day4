
namespace Z2
{
    class dvumass
    {
        int[,] A;
        static int n;
        Random random = new Random();

        public dvumass (int size) // конструктор
        {
            n = size;
            A = new int[size, size];
        }

        public void ArrayInt_R(int max)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    A[i, j] = random.Next(max + 1); 
        }
        public void ArrayInt_Out() // вывод массива
        { 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.WriteLine(A[i, j].ToString() + "\t");
                Console.WriteLine();
            }
         
        }

        public static dvumass operator + (dvumass dvumass0,dvumass dvumass1) // перегрузка оператора
        {
            dvumass b = new dvumass(n);
            for( int i = 0; i < n; i++)
                for(int j = 0; j < n; j++)
                {
                    int inc = dvumass0 .A[i,j] + dvumass1 .A[i, j];
                    b.A[i,j] = inc;
                }
            return b;
        }

        class Program
        { 
            static void Main(string[]args)
            {
                dvumass l = new dvumass(3);
                dvumass u = new dvumass(3);
                dvumass d = new dvumass(3);

                l.ArrayInt_R(100); u.ArrayInt_R(50);d.ArrayInt_R(100);
                Console.WriteLine("\n"); u.ArrayInt_Out(); Console.WriteLine("\n");
                d = l + u;
                d.ArrayInt_Out();
                Console.WriteLine();
            }
            
        }
    }
}