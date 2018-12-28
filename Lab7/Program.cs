using System;

namespace Lab7
{
    public class AddingException : Exception
    {public AddingException(string message) : base(message) { }
    }
    public class MultiplyException : Exception
    {public MultiplyException(string message) : base(message) { }
    }
    class Program
    {private static void Check(int n1, int n2, int m1, int m2)
        {if (m1 != n2)
        throw new MultiplyException("Нельзя умножить");
        if (n1 != n2 || m1 != m2)
        throw new AddingException("Нельзя сложенить");
        }
        public static void Main(string[] args)
        {Console.WriteLine("Введите размерность пустой матрицы: ");
        int x1 = Int32.Parse(Console.ReadLine());
        int x2 = Int32.Parse(Console.ReadLine());
        Matrix e = new Matrix(x1, x2);
        e.GetEmpty(x1, x2);
        e.Print();
        Console.WriteLine("Введите размерность матрицы А: ");
        int q1 = Int32.Parse(Console.ReadLine());
        int w1 = Int32.Parse(Console.ReadLine());
        Matrix a = new Matrix(q1, w1);
        Console.WriteLine("Введите размерность матрицы B: ");
        int q2 = Int32.Parse(Console.ReadLine());
        int w2 = Int32.Parse(Console.ReadLine());
        Matrix b = new Matrix(q2, w2);
        Check(q1, q2, w1, w2);
        Console.WriteLine("Введите элементы матрицы A: ");
        a.Enter();
        Console.WriteLine("Введите элементы матрицы B: ");
        b.Enter();
        Console.WriteLine("Введенные матрицы: \n A: "); a.Print();
        Console.WriteLine(" B:"); b.Print();
        Matrix c = new Matrix(q1, w1);
        c = a + b;
        Console.WriteLine("Сумма матриц: ");
        c.Print();
        c = a - b;
        Console.WriteLine("Разность матриц: ");           
        c.Print();
        c = new Matrix(q1, w2);
        c = a * b;
        Console.WriteLine("Произведение матриц: ");      
        c.Print();
        Console.ReadKey();
        }
    }



    class Matrix
    {
        int n;
        int m;
        int[,] matrix;

        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            matrix = new int[n, m];
        }

        public void Enter()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Введите элемент (" + (i + 1).ToString() + ";" + (j + 1).ToString() + ")" + "\t");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.n, a.m);
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.m; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            return c;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.n, a.m);
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < a.m; j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }
            return c;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix c = new Matrix(a.n, b.m);
            for (int i = 0; i < a.n; i++)
            {
                for (int j = 0; j < b.m; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < a.m; ++k)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return c;
        }

        public Matrix GetEmpty(int s1, int s2)
        {
            Matrix e = new Matrix(s1, s2);
            for (int i = 0; i < s1; i++)
            {
                for (int j = 0; j < s2; j++)
                {
                    e[i, j] = 0;
                }
            }
            return e;
        }
    }
}


