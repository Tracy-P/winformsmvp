namespace WinFormsMVP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox2 = new BaseTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(12, 9);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(67, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 27);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(237, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "John";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 56);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Paul";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 56);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Jane";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(174, 129);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Jane";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(93, 129);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "Paul";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 129);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 7;
            button6.Text = "John";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 82);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "First Name:";
            // 
            // button7
            // 
            button7.Location = new Point(174, 202);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 14;
            button7.Text = "Jane";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(93, 202);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 13;
            button8.Text = "Paul";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(12, 202);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 12;
            button9.Text = "John";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button9_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 23);
            textBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "First Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 260);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Label label1;
        private Button button7;
        private Button button8;
        private Button button9;
        private BaseTextBox textBox2;
        private Label label2;
    }
}
