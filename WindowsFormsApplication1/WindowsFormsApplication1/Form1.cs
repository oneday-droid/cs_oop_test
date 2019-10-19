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
            languageComboBox.DataSource = new BindingSource(Presenter.AvailableLanguage(), null);
            languageComboBox.DisplayMember = "Key";
            languageComboBox.ValueMember = "Value";
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

            string text = presenter.AddPerson(name, age, languageComboBox.SelectedIndex);
            conversationTextBox.AppendText(text + "\n");
        }
    }
}
