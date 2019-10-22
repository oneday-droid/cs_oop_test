using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApplication
{
    class Triangle
    {
        double m_a;
        double m_b;
        double m_c;

        public double A
        {
            set { if (value > 0) m_a = value; }
            get { return m_a; }
        }

        public double B
        {
            set { if (value > 0) m_b = value; }
            get { return m_b; }
        }

        public double C
        {
            set { if (value > 0) m_c = value; }
            get { return m_c; }
        }

        static int count = 0;

        static public int GetTrianglesCount()
        {
            return count;
        }

        static public bool IsValueCorrect(double a, double b, double c)
        {
            return true;
        }

        static public double Area(double a, double b, double c)
        {
            if (IsValueCorrect(a, b, c))
            {
                return CalculateArea(a, b, c);
            }
            else
                throw new ArgumentException("This value is not triangle");
        }

        public static Triangle operator++(Triangle obj)
        {
            double a = obj.A + 1;
            double b = obj.B + 1; ;
            double c = obj.C + 1; ; 
            return new Triangle(a, b, c);
        }

        public static Triangle operator--(Triangle obj)
        {
            double a = obj.A + 1;
            double b = obj.B + 1; ;
            double c = obj.C + 1; ;
            return new Triangle(a, b, c);
        }

        public static bool operator <=(Triangle obj1, Triangle obj2)
        {
            double area1 = obj1.Area();
            double area2 = obj2.Area();
            return (area1 <= area2);
        }

        public static bool operator >=(Triangle obj1, Triangle obj2)
        {
            double area1 = obj1.Area();
            double area2 = obj2.Area();
            return (area1 >= area2);
        }

        public static explicit operator double(Triangle obj)
        {
            return obj.Area();
        }

        public static implicit operator bool(Triangle obj)
        {
            return IsValueCorrect(obj.A, obj.B, obj.C);
        }
        
        public Triangle(double a, double b, double c)
        {
            if (IsValueCorrect(a, b, c))
            {
                A = a;
                B = b;
                C = c;

                count++;
            }
            else
                throw new ArgumentException("This value is not triangle");
        }

        public double Area()
        {
            return CalculateArea(A, B, C);
        }

        static double CalculateArea(double a, double b, double c)
        {
            double p = CalculatePerimeter(a, b, c) / 2;
            double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

            return area;
        }

        static double CalculatePerimeter(double a, double b, double c)
        {
            double p = a + b + c;
            return p;
        }
    }
}
