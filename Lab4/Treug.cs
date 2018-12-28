using System;

namespace Lab4
{class Treug
    {public int a;
     public int b;
     public int c;
     public Treug(int a, int b, int c)
        {this.a = a;
         this.b = b;
         this.c = c;
        }

        public double mathSquare()
        {double p = (double)mathPerimeter() / 2;
        double square = p * (p - a) * (p - b) * (p - c);
        return Math.Sqrt(square);
        }
       public int mathPerimeter()
        {return a + b + c;
        }
    }
}

