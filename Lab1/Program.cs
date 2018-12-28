using System;
using System.Globalization;
using System.Threading;

namespace Lab1
{class Program
    {static void Main(string[] args)
        {Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
         string line;
         System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\text.txt");
         while ((line = file.ReadLine()) != null)
           {decimal x = decimal.Parse(line.Substring(0, line.IndexOf(',')));
            decimal y = decimal.Parse(line.Substring(line.LastIndexOf(',') + 1));
            Console.WriteLine("X: {0} Y: {1}", x, y);
           }
          Console.ReadKey();
        }
    }
}
