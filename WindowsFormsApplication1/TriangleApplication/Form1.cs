using System;
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
        }

        public void ShowMessage(string message)
        {
            outputTextBox.AppendText(message + "\n");
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aTextBox.Text);
            double b = Convert.ToDouble(bTextBox.Text);
            double c = Convert.ToDouble(cTextBox.Text);

            presenter.AddTriangle(a, b, c);
        }

        private void getAreaButton_Click(object sender, EventArgs e)
        {
            presenter.GetArea();
        }

        private void staticGetAreaButton_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aTextBox.Text);
            double b = Convert.ToDouble(bTextBox.Text);
            double c = Convert.ToDouble(cTextBox.Text);
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
