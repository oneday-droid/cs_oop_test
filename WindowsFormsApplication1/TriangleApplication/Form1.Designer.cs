namespace TriangleApplication
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.staticGetAreaButton = new System.Windows.Forms.Button();
            this.getAreaButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.getCountButton = new System.Windows.Forms.Button();
            this.incrementCheckBox = new System.Windows.Forms.CheckBox();
            this.decrementCheckBox = new System.Windows.Forms.CheckBox();
            this.castToDoubleCheckBox = new System.Windows.Forms.CheckBox();
            this.castToBoolCheckBox = new System.Windows.Forms.CheckBox();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.staticGetAreaButton);
            this.groupBox1.Controls.Add(this.getAreaButton);
            this.groupBox1.Controls.Add(this.setButton);
            this.groupBox1.Controls.Add(this.cTextBox);
            this.groupBox1.Controls.Add(this.bTextBox);
            this.groupBox1.Controls.Add(this.aTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangle";
            // 
            // staticGetAreaButton
            // 
            this.staticGetAreaButton.Location = new System.Drawing.Point(195, 60);
            this.staticGetAreaButton.Name = "staticGetAreaButton";
            this.staticGetAreaButton.Size = new System.Drawing.Size(75, 35);
            this.staticGetAreaButton.TabIndex = 7;
            this.staticGetAreaButton.Text = "Get area by values";
            this.staticGetAreaButton.UseVisualStyleBackColor = true;
            this.staticGetAreaButton.Click += new System.EventHandler(this.staticGetAreaButton_Click);
            // 
            // getAreaButton
            // 
            this.getAreaButton.Location = new System.Drawing.Point(103, 60);
            this.getAreaButton.Name = "getAreaButton";
            this.getAreaButton.Size = new System.Drawing.Size(75, 35);
            this.getAreaButton.TabIndex = 7;
            this.getAreaButton.Text = "Get area";
            this.getAreaButton.UseVisualStyleBackColor = true;
            this.getAreaButton.Click += new System.EventHandler(this.getAreaButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(10, 60);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 35);
            this.setButton.TabIndex = 6;
            this.setButton.Text = "Add triangle";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(211, 23);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(59, 20);
            this.cTextBox.TabIndex = 5;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(119, 23);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(59, 20);
            this.bTextBox.TabIndex = 4;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(26, 23);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(59, 20);
            this.aTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(12, 307);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(286, 182);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.Text = "";
            // 
            // getCountButton
            // 
            this.getCountButton.Location = new System.Drawing.Point(12, 145);
            this.getCountButton.Name = "getCountButton";
            this.getCountButton.Size = new System.Drawing.Size(286, 35);
            this.getCountButton.TabIndex = 8;
            this.getCountButton.Text = "Get object count";
            this.getCountButton.UseVisualStyleBackColor = true;
            this.getCountButton.Click += new System.EventHandler(this.getCountButton_Click);
            // 
            // incrementCheckBox
            // 
            this.incrementCheckBox.AutoSize = true;
            this.incrementCheckBox.Location = new System.Drawing.Point(18, 200);
            this.incrementCheckBox.Name = "incrementCheckBox";
            this.incrementCheckBox.Size = new System.Drawing.Size(137, 17);
            this.incrementCheckBox.TabIndex = 9;
            this.incrementCheckBox.Text = "show increment triangle";
            this.incrementCheckBox.UseVisualStyleBackColor = true;
            // 
            // decrementCheckBox
            // 
            this.decrementCheckBox.AutoSize = true;
            this.decrementCheckBox.Location = new System.Drawing.Point(18, 232);
            this.decrementCheckBox.Name = "decrementCheckBox";
            this.decrementCheckBox.Size = new System.Drawing.Size(141, 17);
            this.decrementCheckBox.TabIndex = 9;
            this.decrementCheckBox.Text = "show decrement triangle";
            this.decrementCheckBox.UseVisualStyleBackColor = true;
            // 
            // castToDoubleCheckBox
            // 
            this.castToDoubleCheckBox.AutoSize = true;
            this.castToDoubleCheckBox.Location = new System.Drawing.Point(161, 200);
            this.castToDoubleCheckBox.Name = "castToDoubleCheckBox";
            this.castToDoubleCheckBox.Size = new System.Drawing.Size(107, 17);
            this.castToDoubleCheckBox.TabIndex = 9;
            this.castToDoubleCheckBox.Text = "triangle -> double";
            this.castToDoubleCheckBox.UseVisualStyleBackColor = true;
            // 
            // castToBoolCheckBox
            // 
            this.castToBoolCheckBox.AutoSize = true;
            this.castToBoolCheckBox.Location = new System.Drawing.Point(161, 232);
            this.castToBoolCheckBox.Name = "castToBoolCheckBox";
            this.castToBoolCheckBox.Size = new System.Drawing.Size(95, 17);
            this.castToBoolCheckBox.TabIndex = 9;
            this.castToBoolCheckBox.Text = "triangle -> bool";
            this.castToBoolCheckBox.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 255);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(286, 34);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show operation";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 524);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.castToBoolCheckBox);
            this.Controls.Add(this.castToDoubleCheckBox);
            this.Controls.Add(this.decrementCheckBox);
            this.Controls.Add(this.incrementCheckBox);
            this.Controls.Add(this.getCountButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button getCountButton;
        private System.Windows.Forms.Button getAreaButton;
        private System.Windows.Forms.Button staticGetAreaButton;
        private System.Windows.Forms.CheckBox incrementCheckBox;
        private System.Windows.Forms.CheckBox decrementCheckBox;
        private System.Windows.Forms.CheckBox castToDoubleCheckBox;
        private System.Windows.Forms.CheckBox castToBoolCheckBox;
        private System.Windows.Forms.Button showButton;
    }
}

