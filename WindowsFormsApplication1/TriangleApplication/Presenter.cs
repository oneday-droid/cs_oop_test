using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleApplication
{
    class Presenter
    {
        IView m_view;
        MyList<Triangle> triangles;

        public Presenter()
        {
            triangles = new MyList<Triangle>();
        }

        public void AttachView(IView view)
        {
            m_view = view;
        }

        public void AddTriangle(double a, double b, double c)
        {
            try
            {
                triangles.Add(new Triangle(a, b, c));
            }
            catch (Exception e)
            {
                m_view.ShowMessage(e.Message);
            }
        }

        public void GetAreaStatic(double a, double b, double c)
        {
            try
            {
                double area = Triangle.Area(a, b, c);
                m_view.ShowMessage(String.Format("Triangle ({0},{1},{2}) area is {3}", a, b, c, area));
            }
            catch (Exception e)
            {
                m_view.ShowMessage(e.Message);
            }
        }

        public void GetArea()
        {
            if (triangles.Count != 0)
            {
                Triangle triangle = triangles.Last();
                double area = triangle.Area();
                m_view.ShowMessage(String.Format("Triangle ({0},{1},{2}) area is {3}", 
                                   triangle.A, triangle.B, triangle.C, area));
            }
            else
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle before Get area or use Static get area");
            }
        }

        public void GetObjectCount()
        {
            m_view.ShowMessage(String.Format("Triangles object count is {0}", Triangle.GetTrianglesCount()));
        }

        public void IncrementTriangle()
        {
            if (triangles.Count != 0)
            {
                Triangle triangle = triangles.Last();
                triangle++;
                m_view.ShowMessage(String.Format("Triangle ({0},{1},{2})", triangle.A, triangle.B, triangle.C));
                //triangles.Replace(triangles.Count - 1, triangle);
            }
            else
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle at first");
            }
        }

        public void DecrementTriangle()
        {
            try
            {
                if (triangles.Count != 0)
                {
                    Triangle triangle = triangles.Last();
                    triangle--;
                    m_view.ShowMessage(String.Format("Triangle ({0},{1},{2})", triangle.A, triangle.B, triangle.C));
                    //triangles.Replace(triangles.Count - 1, triangle);
                }
                else
                    m_view.ShowMessage("Triangle not create yet. Press Add triangle at first");                    
            }
            catch (Exception e)
            {
                m_view.ShowMessage(e.Message);
            }
        }

        public void CastTriangleToDouble()
        {
            if (triangles.Count != 0)
            {
                Triangle triangle = triangles.Last();
                double value = (double)triangle;
                m_view.ShowMessage(String.Format("Triangle ({0},{1},{2}) to double is {3}", 
                                   triangle.A, triangle.B, triangle.C, value));
            }
            else
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle before Get area or use Static get area");
            }
        }

        public void CastTriangleToBool()
        {
            if (triangles.Count != 0)
            {
                Triangle triangle = triangles.Last();
                bool value = triangle;
                m_view.ShowMessage(String.Format("Triangle ({0},{1},{2}) to bool is {3}", 
                                   triangle.A, triangle.B, triangle.C, value));
            }
            else
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle before Get area or use Static get area");
            }
        }
    }
}
