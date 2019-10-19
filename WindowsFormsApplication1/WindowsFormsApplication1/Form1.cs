using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Presenter presenter;

        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter();
        }

        private void inputTextBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string inputText = inputTextBox.Text;
                conversationTextBox.AppendText(">> " + inputText + "\n");
                string text = presenter.NewMessageToPerson(inputText);
                conversationTextBox.AppendText("<< " + text + "\n");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string text = presenter.AddPerson();
            conversationTextBox.AppendText(text + "\n");
        }
    }
}
