using System;

namespace Lab2
{class Task1
    {private double num;
     private double power;
     public Task1(double num, double power)
        {this.num = num;
         this.power = power;
        }
        public double NewMath()
        {const double eps = 1e-15;
        double x0 = num / power;
        double tmp = (1 / power) * ((power - 1) * x0 + num / Math.Pow(x0, (int)power - 1));
        while (Math.Abs(tmp - x0) > eps)
            {x0 = tmp;
            tmp = (1 / power) * ((power - 1) * x0 + num / Math.Pow(x0, (int)power - 1));
            }
            return tmp;
        }
        public double MathPow()
        {double tmp = Math.Pow(num, Math.Pow(power, -1));
        return tmp;
        }
    }
}
