﻿namespace Hausaufgabe1_
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
            tbName = new TextBox();
            tbSerie = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(133, 77);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Havva Nur";
            tbName.Size = new Size(510, 27);
            tbName.TabIndex = 1;
            tbName.TextChanged += textBox1_TextChanged;
            // 
            // tbSerie
            // 
            tbSerie.Location = new Point(133, 142);
            tbSerie.Name = "tbSerie";
            tbSerie.PlaceholderText = "Gilmore Girls";
            tbSerie.Size = new Size(510, 27);
            tbSerie.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(312, 197);
            button1.Name = "button1";
            button1.Size = new Size(155, 51);
            button1.TabIndex = 3;
            button1.Text = "Klicken";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(tbSerie);
            Controls.Add(tbName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbName;
        private TextBox tbSerie;
        private Button button1;
    }
}