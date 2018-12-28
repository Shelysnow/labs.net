using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {static void Main(string[] args)
        {Console.Write("0 : Вектор \n" + "1 : Многочлен \n" + "Введите номер : ");
        int switcher = int.Parse(Console.ReadLine());
        switch (switcher) {
        case 0:
        Console.WriteLine("Введите координаты вектора 1:");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        Vector v1 = new Vector(x, y, z);
        Console.WriteLine("Введите координаты вектора 2:");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        z = int.Parse(Console.ReadLine());
        Vector v2 = new Vector(x, y, z);
        Console.Write("Сравнение векторов: ");
        if (v1 & v2) Console.Write("равны, ");
        else Console.Write("не равны, ");
        if (v1 | v2) Console.WriteLine("коллинеарны");
        else Console.WriteLine("не коллинеарны");
        Vector sum = v1 + v2;
        Vector raz = v1 - v2;
        Vector vect = v1 * v2;
        double scalyr = v1 ^ v2;
        Vector v1Mult = v1 * 5.5;
        Vector v2Mult = v2 * 5.5;
        Console.WriteLine("Сумма векторов: \n{0} "+"\nРазность векторов: \n{1} "+"\nВекторное произведение: \n{2} "+"\nСкалярное произведение: \n{3} "+"\nУмножение на число 5.5: \n{4} \n{5}",
        sum.ToString(), raz.ToString(), vect.ToString(), scalyr, v1Mult.ToString(), v2Mult.ToString());
        break;
        case 1:
        Dictionary<string, int> d1 = new Dictionary<string, int>();
        Dictionary<string, int> d2 = new Dictionary<string, int>();
        Console.WriteLine("Введите размер многочлена 1: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер многочлена 2: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы многочлена 1: ");
        int i = 0;
        while (i < n1) { 
        Console.Write("Коэффициент: ");
        string number = Console.ReadLine();
        Console.Write("Параметр: ");
        int key = int.Parse(Console.ReadLine());
        d1.Add(number, key);
        i++;
        }
                Console.WriteLine("Введите элементы многочлена 2: ");
                i = 0;
                while (i < n2)
                    {Console.Write(i + 1 + ": ");
                    string number = Console.ReadLine();
                    int key = int.Parse(Console.ReadLine());
                    d2.Add(number, key);
                    i++;
                    }

                    Poly p1 = new Poly(d1);
                    Poly p2 = new Poly(d2);
                    Console.WriteLine("Введенные многочлены: ");
                    Console.WriteLine(p1);
                    Console.WriteLine(p2);
                    Console.Write("Сложение: {0} \nВычитание: {1}", p1 + p2, p1 - p2);
                    break;
            }
            Console.ReadKey();
        }
    }
    class Poly
    {public Dictionary<string, int> exit = new Dictionary<string, int>();
    public Poly(Dictionary<string, int> exit)
        {this.exit = exit;
        }
        public static Poly operator +(Poly p1, Poly p2)
        {Dictionary<string, int> dictionary = new Dictionary<string, int>();
        var quit = dictionary.Concat(p1.exit).Concat(p2.exit).GroupBy(x => x.Key).ToDictionary(x => x.Key, x => x.Sum(y => y.Value));
        return new Poly(quit);
        }
        public static Poly operator -(Poly p1, Poly p2)
        {Dictionary<string, int> dictionary = new Dictionary<string, int>();
        Dictionary<string, int> dictionary1 = new Dictionary<string, int>(p2.exit);
        foreach (var key in dictionary1.Keys.ToList())
            {dictionary1[key] *= -1;
            }
            var quit = dictionary.Concat(p1.exit).Concat(dictionary1).GroupBy(x => x.Key).ToDictionary(x => x.Key, x => x.Sum(y => y.Value));
            return new Poly(quit);
        }
        override
        public string ToString()
        {StringBuilder quit = new StringBuilder();
        bool check = true;
        foreach (KeyValuePair<string, int> entry in exit)
            {if (exit.Values.First().Equals(entry.Value) && check && entry.Value != 0)
                {quit.Append(entry.Value + "" + entry.Key);
                check = !check;
                }
                else
                {if (entry.Value == 0) continue;
                var cond = (entry.Value > 0) ? quit.Append(" + " + entry.Value + "" + entry.Key) : quit.Append(" " + entry.Value + "" + entry.Key);
                }
            }
            return quit.ToString();
        }
    }
}
