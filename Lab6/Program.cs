using System;
using System.Collections.Generic;
namespace Lab6
{
    class Program
    {static void Main(string[] args)
        {Converter object0 = new Converter();
        Helper object1 = new Helper();
         Helper object2 = new Helper();
         List<Converter> ObjectList = new List<Converter>();
            ObjectList.Add(object0);
            ObjectList.Add(object1);
            ObjectList.Add(object2);
            foreach (var objec in ObjectList)
            {Checker check = objec as Checker;
            if (check != null)
                {Console.WriteLine(check.CheckSyntax("code", "C#"));
                Console.WriteLine(objec.ConvertToVB("code"));
                }
                else
                {Console.WriteLine(objec.ConvertToCSharp("code"));
                Console.WriteLine(objec.ConvertToVB("code"));
                }
            }
            Console.ReadKey();
        }
    }
}
