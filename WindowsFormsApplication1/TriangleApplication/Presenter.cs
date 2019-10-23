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
        Triangle triangle;

        public Presenter()
        {

        }

        public void AttachView(IView view)
        {
            m_view = view;
        }

        public void AddTriangle(double a, double b, double c)
        {
            try
            {
                triangle = new Triangle(a, b, c);
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
                m_view.ShowMessage(String.Format("Triangle ({0}, {1}, {2}) area is {3}", a, b, c, area));
            }
            catch (Exception e)
            {
                m_view.ShowMessage(e.Message);
            }
        }

        public void GetArea()
        {
            try
            {
                double area = triangle.Area();
                m_view.ShowMessage(String.Format("Triangle ({0}, {1}, {2}) area is {3}", triangle.A, triangle.B, triangle.C, area));
            }
            catch (NullReferenceException)
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
            try
            {
                triangle++;
                m_view.ShowMessage(String.Format("Triangle ({0}, {1}, {2})", triangle.A, triangle.B, triangle.C));
            }
            catch (NullReferenceException)
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle at first");
            }
        }

        public void DecrementTriangle()
        {
            try
            {
                triangle--;
                m_view.ShowMessage(String.Format("Triangle ({0}, {1}, {2})", triangle.A, triangle.B, triangle.C));
            }
            catch (NullReferenceException)
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle at first");
            }
            catch (Exception e)
            {
                m_view.ShowMessage(e.Message);
            }

        }

        public void CastTriangleToDouble()
        {
            try
            {
                double value = (double)triangle;
                m_view.ShowMessage(String.Format("Triangle ({0}, {1}, {2}) to double is {3}", triangle.A, triangle.B, triangle.C, value));
            }
            catch (NullReferenceException)
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle before Get area or use Static get area");
            }
        }

        public void CastTriangleToBool()
        {
            try
            {
                bool value = triangle;
                m_view.ShowMessage(String.Format("Triangle ({0}, {1}, {2}) to bool is {3}", triangle.A, triangle.B, triangle.C, value));
            }
            catch (NullReferenceException)
            {
                m_view.ShowMessage("Triangle not create yet. Press Add triangle before Get area or use Static get area");
            }
        }
    }
}
