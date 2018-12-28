using System;

namespace Lab4
{class Program
    {public static bool Treug(int a, int b, int c)
        {bool posibility = true;
         if (a + b <= c || a + c <= b || b + c <= a) posibility = false;
         if (a == 0 || b == 0 || c == 0) posibility = false;
         return posibility;
        }
        static void Main(string[] args)
        {Console.Write("Введите стороны треугольника: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (!Treug(a, b, c))
            {Console.WriteLine("Треугольник не может существует!");
            Console.ReadKey();
            Environment.Exit(0);
            }
            else
            {Treug triagle = new Treug(a, b, c);
            string square = triagle.mathSquare().ToString("N3");
            int perimeter = triagle.mathPerimeter();
            Console.WriteLine("Площадь: {0} \nПериметр: {1}", square, perimeter);
            }
            Console.ReadKey();
        }
    }
}

