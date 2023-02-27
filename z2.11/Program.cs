using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        public class Matrix
        {
            double[,] matrix;
            int Row = 0, Col = 0;

            public Matrix(int row, int col)  //матрица N x M
            {
                matrix = new double[row, col];
                Row = row; Col = col;
            }

            public Matrix(int N) //квадратная матрица
            {
                matrix = new double[N, N];
                Row = Col = N;
            }

            public double this[int i, int j] //перегрузка индексатора, чтобы обратится к элементу матрицы
            {
                get { return matrix[i, j]; }
                set { matrix[i, j] = value; }
            }

            public static Matrix operator +(Matrix first, Matrix second)
            {
                Matrix mat = new Matrix(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                    for (int j = 0; j < first.Col; j++)
                        mat[i, j] = first[i, j] + second[i, j];
                return mat;
            }

            public static Matrix operator -(Matrix first, Matrix second)
            {
                Matrix mat = new Matrix(first.Row, first.Col);
                for (int i = 0; i < first.Row; i++)
                    for (int j = 0; j < first.Col; j++)
                        mat[i, j] = first[i, j] - second[i, j];
                return mat;
            }

            public void PrintMatrix()
            {
                for (int i = 0; i < this.Row; i++)
                {
                    for (int j = 0; j < this.Col; j++)
                        Console.Write("{0}  ", this[i, j]);
                    Console.Write("\n");
                }

            }
        }
        static void Main(string[] args)
        {
            int N = 3;  //размерность
            int pow = 3; //степень

            Random rand = new Random();
            Matrix first = new Matrix(N);
            Matrix second = new Matrix(N);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    first[i, j] = rand.Next(1, 4);
                    second[i, j] = rand.Next(1, 4);
                }

            Console.WriteLine("Первая матрица:\n\n");
            first.PrintMatrix();
            Console.WriteLine("\n\nВторая матрица:\n\n");
            second.PrintMatrix();
            Console.WriteLine("\n\nСумма матриц:\n\n");
            (first + second).PrintMatrix();
            Console.WriteLine("\n\nРазница матриц:\n\n");
            (first - second).PrintMatrix();
            Console.ReadKey();
        }
    }
}
    