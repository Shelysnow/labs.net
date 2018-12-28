using System;
using System.Collections;
using System.Diagnostics;

namespace Lab3
{class Program
    {static int Euclid(int a, int b)
        {while (a != 0 && b != 0)
            {if (a > b)
                {a = a % b;
                }
                else
                {b = b % a;
                }
            }
            return a + b;
        }
        static int Euclid(ArrayList list)
        {int tmp = Euclid((int)list[0], (int)list[1]);
        int i = 2;
        while (i < list.Count)
            {tmp = Euclid(tmp, (int)list[i]);
             i++;
            }
            return tmp;
        }

        static int GCD(int a, int b)
        {if (a == 0)
        return b;
        if (b == 0)
        return a;
        if (a == b)
        return a;
        if (a == 1 || b == 1)
        return 1;
        if ((a & 1) == 0)
        return ((b & 1) == 0)
        ? GCD(a >> 1, b >> 1) << 1
        : GCD(a >> 1, b);
        else
        return ((b & 1) == 0)
        ? GCD(a, b >> 1)
        : GCD(b, a > b ? a - b : b - a);
        }

        static void Main(string[] args)
        {Stopwatch stopWatch = new Stopwatch();
        Console.Write("Введите количество чисел для Евклида: ");
        int n = Int32.Parse(Console.ReadLine());
        Console.Write("Введите числа: ");
        ArrayList array = new ArrayList();
        int tmp;
        int i = 0;
        while (i < n)
            {tmp = Int32.Parse(Console.ReadLine());
             array.Add(tmp);
             i++;
            }
            Console.Write("Евклид НОД : ", n);
            stopWatch.Start();
            if (n == 2)
            {Console.WriteLine(Euclid((int)array[0], (int)array[1]));
            }
            else
            {Console.WriteLine(Euclid(array));           
            }
            stopWatch.Stop();
            Console.WriteLine("Время: " + stopWatch.Elapsed);
            stopWatch.Restart();
            int gcd = GCD((int)array[0], (int)array[1]);
            Console.WriteLine("Стейн НОД чисел: {0}  ", gcd);
            stopWatch.Stop();
            Console.WriteLine("Время: " + stopWatch.Elapsed);
            Console.ReadKey();
        }
    }
}
