namespace Hausaufgabe_1
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
            button1 = new Button();
            tbName = new TextBox();
            tbSerie = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(365, 158);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Klick mich!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(292, 68);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Emirhan";
            tbName.Size = new Size(243, 27);
            tbName.TabIndex = 1;
            tbName.TextChanged += textBox1_TextChanged;
            // 
            // tbSerie
            // 
            tbSerie.Location = new Point(292, 125);
            tbSerie.Name = "tbSerie";
            tbSerie.PlaceholderText = "Dark";
            tbSerie.Size = new Size(243, 27);
            tbSerie.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbSerie);
            Controls.Add(tbName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbName;
        private TextBox tbSerie;
    }
}