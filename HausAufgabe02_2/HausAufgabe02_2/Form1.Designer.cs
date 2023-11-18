namespace HausAufgabe02_2
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
            label_titel = new Label();
            textBox1 = new TextBox();
            label_autor = new Label();
            textBox2 = new TextBox();
            label_jahr = new Label();
            textBox3 = new TextBox();
            label_vertrag = new Label();
            textBox4 = new TextBox();
            label_preis = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            gesamtKosten = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label_titel
            // 
            label_titel.AutoSize = true;
            label_titel.Location = new Point(203, 62);
            label_titel.Name = "label_titel";
            label_titel.Size = new Size(29, 15);
            label_titel.TabIndex = 0;
            label_titel.Text = "Titel";
            label_titel.Click += label_titel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label_autor
            // 
            label_autor.AutoSize = true;
            label_autor.Location = new Point(203, 91);
            label_autor.Name = "label_autor";
            label_autor.Size = new Size(37, 15);
            label_autor.TabIndex = 0;
            label_autor.Text = "Autor";
            label_autor.Click += label_autor_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(275, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label_jahr
            // 
            label_jahr.AutoSize = true;
            label_jahr.Location = new Point(203, 120);
            label_jahr.Name = "label_jahr";
            label_jahr.Size = new Size(28, 15);
            label_jahr.TabIndex = 0;
            label_jahr.Text = "Jahr";
            label_jahr.Click += label_jahr_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(275, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label_vertrag
            // 
            label_vertrag.AutoSize = true;
            label_vertrag.Location = new Point(203, 149);
            label_vertrag.Name = "label_vertrag";
            label_vertrag.Size = new Size(44, 15);
            label_vertrag.TabIndex = 0;
            label_vertrag.Text = "Vertrag";
            label_vertrag.Click += label_vertrag_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(275, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label_preis
            // 
            label_preis.AutoSize = true;
            label_preis.Location = new Point(203, 178);
            label_preis.Name = "label_preis";
            label_preis.Size = new Size(32, 15);
            label_preis.TabIndex = 0;
            label_preis.Text = "Preis";
            label_preis.Click += label_preis_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(275, 178);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 1;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(263, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Anliegen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(155, 319);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(307, 209);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // gesamtKosten
            // 
            gesamtKosten.Location = new Point(310, 556);
            gesamtKosten.Name = "gesamtKosten";
            gesamtKosten.ReadOnly = true;
            gesamtKosten.Size = new Size(96, 23);
            gesamtKosten.TabIndex = 4;
            gesamtKosten.TextChanged += gesamtKosten_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 559);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Gesamt:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 626);
            Controls.Add(label1);
            Controls.Add(gesamtKosten);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label_preis);
            Controls.Add(textBox4);
            Controls.Add(label_vertrag);
            Controls.Add(textBox3);
            Controls.Add(label_jahr);
            Controls.Add(textBox2);
            Controls.Add(label_autor);
            Controls.Add(textBox1);
            Controls.Add(label_titel);
            Name = "Form1";
            Text = "Buchverwaltung";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_titel;
        private TextBox textBox1;
        private Label label_autor;
        private TextBox textBox2;
        private Label label_jahr;
        private TextBox textBox3;
        private Label label_vertrag;
        private TextBox textBox4;
        private Label label_preis;
        private TextBox textBox5;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox gesamtKosten;
        private Label label1;
    }
}