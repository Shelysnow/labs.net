using System;

namespace Lab6
{
    class Helper : Converter, Checker
    {public bool CheckSyntax(string line, string lang)
        {Random random = new Random();
        int result = random.Next(0, 2);
        if (result == 1)
        return true;
        else
        return false;
        }
    }
}
