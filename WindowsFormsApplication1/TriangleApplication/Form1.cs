﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleApplication
{
    public partial class Form1 : Form, IView
    {
        Presenter presenter;

        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter();
            presenter.AttachView(this);

            MyList<int> list = new MyList<int>();
            list.Add(2);
            list.Add(6);
            list.Add(9);

            outputTextBox.AppendText(list.ToString() + "\n");

            list.Insert(2, 17);
            outputTextBox.AppendText(list.ToString() + "\n");

            list.Remove(6);
            outputTextBox.AppendText(list.ToString() + "\n");

            list.Insert(3, 4);
            outputTextBox.AppendText(list.ToString() + "\n");

            foreach(int val in list)
                outputTextBox.AppendText(val.ToString() + "\n");
        }

        public void ShowMessage(string message)
        {
            outputTextBox.AppendText(message + "\n");
        }

        private void GetValuesFromTextBox(out double a, out double b, out double c)
        {
            a = -1; b = -1; c = -1;
            try
            {
                a = Convert.ToDouble(aTextBox.Text);
                b = Convert.ToDouble(bTextBox.Text);
                c = Convert.ToDouble(cTextBox.Text);
            }
            catch (Exception)
            {
                outputTextBox.AppendText("Incorrect values\n");
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            GetValuesFromTextBox(out a, out b, out c);
            presenter.AddTriangle(a, b, c);            
        }

        private void getAreaButton_Click(object sender, EventArgs e)
        {
            presenter.GetArea();
        }

        private void staticGetAreaButton_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            double c;
            GetValuesFromTextBox(out a, out b, out c);
            presenter.GetAreaStatic(a, b, c);            
        }

        private void getCountButton_Click(object sender, EventArgs e)
        {
            presenter.GetObjectCount();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (incrementCheckBox.Checked)
                presenter.IncrementTriangle();
            if (decrementCheckBox.Checked)
                presenter.DecrementTriangle();
            if (castToDoubleCheckBox.Checked)
                presenter.CastTriangleToDouble();
            if (castToBoolCheckBox.Checked)
                presenter.CastTriangleToBool();
        }        
    }
}
