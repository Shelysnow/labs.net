namespace Lab5
{
    class Vector
    {private double x { get; set; }
    private double y { get; set; }
    private double z { get; set; }

    public Vector(double x = 0, double y = 0, double z = 0)
        {this.x = x;
         this.y = y;
         this.z = z;
        }
        public override string ToString()
        {string result = x + " " + y + " " + z;
        return result;
        }

        public static bool operator &(Vector v1, Vector v2)
        {return v1.x == v2.x && v1.y == v2.y && v1.z == v2.z;
        }
        public static bool operator |(Vector v1, Vector v2)
        {return (v1.x / v2.x == v1.y / v2.y && v1.x / v2.x == v1.z / v2.z);
        }
        public static Vector operator +(Vector v1, Vector v2)
        {Vector v = new Vector();
        v.x = v1.x + v2.x;
        v.y = v1.y + v2.y;
        v.z = v1.z + v2.z;
        return v;
        }
    public static Vector operator -(Vector v1, Vector v2)
        {Vector v = new Vector();
        v.x = v1.x - v2.x;
        v.y = v1.y - v2.y;
        v.z = v1.z - v2.z;
        return v;
        }
        public static Vector operator *(Vector v1, Vector v2)
        {Vector v = new Vector();
        v.x = v1.y * v2.z - v1.z * v2.y;
        v.y = v1.z * v2.x - v1.x * v2.z;
        v.z = v1.x * v2.y - v1.y * v2.x;
        return v;
        }

        public static double operator ^(Vector v1, Vector v2)
        {double scalyr = v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        return scalyr;
        }

        public static Vector operator *(Vector v1, double l)
        {Vector v = new Vector();
        v.x = v1.x * l;
        v.y = v1.y * l;
        v.z = v1.z * l;
        return v;
        }
    }
}
