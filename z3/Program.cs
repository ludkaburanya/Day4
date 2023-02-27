using System;
using System.Collections.Generic;
using System.Text;

namespace z3
{
    class matrix
    {
        private int a, b, x, y;
        public matrix(int a, int b)
        {
            Random r = new Random();
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Matrix[i, j] = r.Next(-10, 10);
        }
        public int[,] Matrix = new int[10, 10];

        public void w (int x, int y) // вывод матрицы
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                    Console.Write(Matrix[i, j] + "\t");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        public void printElememtOfMatrix(int numberOfLine, int numberOfolumn)
        {
            for (int j = 0; j <= a; j++)
            {
                for (int i = 0; i <= b; i++)
                {
                    if (i == numberOfLine && j == numberOfolumn) ;
                    {
                        Console.WriteLine( Matrix[i, j]);
                    }

                }
            }
        }   
    } 
    class podmatrix
    {
        public podmatrix(ref int[,] matr, int a, int b)
        //в конструктор передаём параметры: указатель на исх. матрицу
        {
            A = a; B = b;
            for (int i = 0; i < a; i++)
                for (int j = 0; j < b; j++)
                    Array[i, j] = matr[i, j]; //передаём элементы исх. матрицы в подматрицу
        }

        private int A, B; // размер матрицы
        private int[,] Array = new int[10, 10]; //объявление матрицы

        public void showArray() //вывод подматрицы
        {
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                    Console.Write(Array[i, j] + "\t");
                Console.Write("\n");
            }
        }
       
    }
    class z3
    {
        public static void Main()
        {

            int a, b, x, y;
            Console.Write("Введите количество строк исходной матрицы: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов исходной матрицы: ");
            b = Int32.Parse(Console.ReadLine());
            matrix rev = new matrix(a, b);
            rev.w(a, b);

            Console.WriteLine("Введите номер строки:");
            int numberOfLine= Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер столбца:");
            int numberOfColumn = Int32.Parse(Console.ReadLine());
            rev.printElememtOfMatrix(numberOfLine, numberOfColumn);


            Console.Write("Введите количество строк подматрицы:");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов подматрицы: ");
            y = Int32.Parse(Console.ReadLine());

            podmatrix A = new podmatrix(ref rev.Matrix, x, y);
            A.showArray();
            Console.ReadKey();

        }
    }
}