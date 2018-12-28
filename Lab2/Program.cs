using System;

namespace Lab2
{class Program
    {static void Main(string[] args)
        {Console.Write("Task1 \nВведите значение: ");
         double number = Int32.Parse(Console.ReadLine());
         Console.Write("Введите корень: ");
         double power = Int32.Parse(Console.ReadLine());
         Task1 task1 = new Task1(number, power);
         Console.WriteLine("Ньютон: {0} \nМетод Math.Pow: {1} \n", task1.NewMath(), task1.MathPow());
         Console.Write("Task2 \nВведите число: ");
         int value = Int32.Parse(Console.ReadLine());
         Task2 task2 = new Task2(value);
         Console.WriteLine("Свой : {0} \nСтандартный : {1}", task2.Con(), Convert.ToString(value, 2));  
         Console.ReadKey();
        }
    }
}
