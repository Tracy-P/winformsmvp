using WinformsMVPMDI.BaseLIbrary;

namespace WinformsMVPMDI
{
    partial class PeopleView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFirstName = new BaseTextBox();
            buttonJohn = new Button();
            buttonPaul = new Button();
            buttonJane = new Button();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 12);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(241, 23);
            textBoxFirstName.TabIndex = 0;
            // 
            // buttonJohn
            // 
            buttonJohn.Location = new Point(16, 45);
            buttonJohn.Name = "buttonJohn";
            buttonJohn.Size = new Size(75, 23);
            buttonJohn.TabIndex = 1;
            buttonJohn.Text = "John";
            buttonJohn.UseVisualStyleBackColor = true;
            buttonJohn.Click += ButtonJohn_Click;
            // 
            // buttonPaul
            // 
            buttonPaul.Location = new Point(97, 45);
            buttonPaul.Name = "buttonPaul";
            buttonPaul.Size = new Size(75, 23);
            buttonPaul.TabIndex = 2;
            buttonPaul.Text = "Paul";
            buttonPaul.UseVisualStyleBackColor = true;
            buttonPaul.Click += ButtonPaul_Click;
            // 
            // buttonJane
            // 
            buttonJane.Location = new Point(178, 45);
            buttonJane.Name = "buttonJane";
            buttonJane.Size = new Size(75, 23);
            buttonJane.TabIndex = 3;
            buttonJane.Text = "Jane";
            buttonJane.UseVisualStyleBackColor = true;
            buttonJane.Click += ButtonJane_Click;
            // 
            // People
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 196);
            Controls.Add(buttonJane);
            Controls.Add(buttonPaul);
            Controls.Add(buttonJohn);
            Controls.Add(textBoxFirstName);
            Name = "People";
            Text = "People";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BaseTextBox textBoxFirstName;
        private Button buttonJohn;
        private Button buttonPaul;
        private Button buttonJane;
    }
}