namespace Lab6
{
    class Converter : Convertible
    {public string ConvertToCSharp(string line)
        {line = "Converted to C#";
        return line;
        }

        public string ConvertToVB(string line)
        {line = "Переписать в Visual Basic";
        return line;
        }
    }
}
