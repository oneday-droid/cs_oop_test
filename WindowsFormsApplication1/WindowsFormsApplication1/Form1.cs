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
    public partial class Form1 : Form, ViewState
    {
        Presenter presenter;

        public Form1()
        {
            InitializeComponent();
            languageComboBox.DataSource = new BindingSource(Presenter.AvailableLanguage(), null);
            languageComboBox.DisplayMember = "Key";
            languageComboBox.ValueMember = "Value";

            presenter = new Presenter();
            presenter.attachView(this);
        }

        private void inputTextBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string inputText = inputTextBox.Text;
                UserMessage(inputText);
                presenter.NewMessageToPerson(inputText);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            uint age = 0;
            try
            {
                age = Convert.ToUInt32(ageTextBox.Text);
            }
            catch (Exception)
            {
                age = 0;
            }

            presenter.AddPerson(name, age, languageComboBox.SelectedIndex);
        }

        public void InformMessage(string message)
        {
            conversationTextBox.AppendText(message + "\n");
        }

        public void PersonMessage(string message)
        {
            conversationTextBox.SelectionStart = conversationTextBox.Text.Length;
            string text = ">> " + message + "\n";
            conversationTextBox.SelectionLength = text.Length;
            conversationTextBox.SelectionColor = Color.DarkBlue;
            conversationTextBox.AppendText(text);            
        }

        public void UserMessage(string message)
        {
            conversationTextBox.SelectionStart = conversationTextBox.Text.Length;
            string text = "<< " + message + "\n";
            conversationTextBox.SelectionLength = text.Length;
            conversationTextBox.SelectionColor = Color.DarkCyan; 
            conversationTextBox.AppendText(text);                       
        }
    }
}
