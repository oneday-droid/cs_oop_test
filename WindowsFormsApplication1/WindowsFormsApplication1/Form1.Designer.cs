namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.conversationTextBox = new System.Windows.Forms.RichTextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.personGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.personGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(197, 146);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add person";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // conversationTextBox
            // 
            this.conversationTextBox.Location = new System.Drawing.Point(12, 191);
            this.conversationTextBox.Name = "conversationTextBox";
            this.conversationTextBox.ReadOnly = true;
            this.conversationTextBox.Size = new System.Drawing.Size(259, 151);
            this.conversationTextBox.TabIndex = 1;
            this.conversationTextBox.Text = "";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(13, 359);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(259, 20);
            this.inputTextBox.TabIndex = 2;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyPress);
            // 
            // personGroupBox
            // 
            this.personGroupBox.Controls.Add(this.label4);
            this.personGroupBox.Controls.Add(this.ageTextBox);
            this.personGroupBox.Controls.Add(this.languageComboBox);
            this.personGroupBox.Controls.Add(this.label3);
            this.personGroupBox.Controls.Add(this.label2);
            this.personGroupBox.Controls.Add(this.nameTextBox);
            this.personGroupBox.Controls.Add(this.label1);
            this.personGroupBox.Location = new System.Drawing.Point(13, 13);
            this.personGroupBox.Name = "personGroupBox";
            this.personGroupBox.Size = new System.Drawing.Size(258, 115);
            this.personGroupBox.TabIndex = 3;
            this.personGroupBox.TabStop = false;
            this.personGroupBox.Text = "Set person data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(61, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(179, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Language";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(61, 73);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(179, 21);
            this.languageComboBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(61, 47);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 397);
            this.Controls.Add(this.personGroupBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.conversationTextBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.personGroupBox.ResumeLayout(false);
            this.personGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox conversationTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.GroupBox personGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
    }
}

