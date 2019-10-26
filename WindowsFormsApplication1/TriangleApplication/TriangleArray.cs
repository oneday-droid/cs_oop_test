using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApplication
{
    class TriangleRepository : IRepository<Triangle>
    {
        Triangle[] triArray;
        int size;
        Random random;

        public int Size
        {
            get { return size; }
            private set { if (value >= 0) size = value; }
        }

        public Triangle this[int index]
        {
            get 
            {
                if ((index > 0) && (index < Size))
                    return triArray[index]; 
                else
                    throw new IndexOutOfRangeException();
            }
            set { triArray[index] = value; }
        }

        public TriangleRepository()
        {
            Size = 0;
            triArray = new Triangle[0];
        }

        public TriangleRepository(int size)
        {
            Size = size;
            triArray = new Triangle[Size];
            random = new Random();

            int k = 0;
            while ( k < Size )
            {
                double a = random.NextDouble();
                double b = random.NextDouble();
                double c = random.NextDouble();
                try
                {
                    triArray[k] = new Triangle(a, b, c);
                    k++;
                }
                catch (Exception)
                { }
            }
        }

        public override string ToString() 
        {
            string str = "";

            for (int k = 0; k < Size; k++)
            {
                Triangle triangle = triArray[k];
                str += String.Format("Triangle {0} ({1},{2},{3})\n", k, triangle.A, triangle.B, triangle.C);
            }

            return str;
        }

        public void Add(Triangle value)
        {
            Triangle[] tempArray = triArray;
            Size = Size + 1;
            triArray = new Triangle[Size];
            for (int k = 0; k < Size - 1; k++)
                triArray[k] = tempArray[k];

            triArray[Size - 1] = value;
        }

        public void Clear()
        {
            Size = 0;
        }

        public IRepository<Triangle> GetAll()
        {
            throw new NotImplementedException();
        }

        public Triangle Get(int index)
        {
            return triArray[index];
        }

        public Triangle First()
        {
            return triArray[0];
        }

        public Triangle Last()
        {
            return triArray[Size - 1];
        }

        public void Replace(int index, Triangle newValue)
        {
            if ((index > 0) && (index < Size))
                triArray[index] = newValue;
            else
                throw new IndexOutOfRangeException();
        }
    }
}
