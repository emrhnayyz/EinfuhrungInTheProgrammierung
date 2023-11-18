using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HausAufgabe02_2
{
    public partial class Form1 : Form
    {
        private List<Buch> buchListe = new List<Buch>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buch neuesBuch = new Buch(
                textBox1.Text,
                textBox2.Text,
                int.Parse(textBox3.Text),
                textBox4.Text,
                double.Parse(textBox5.Text)
            );

            buchListe.Add(neuesBuch);

            richTextBox1.AppendText($"Titel: {neuesBuch.Titel}, Autor: {neuesBuch.Autor}, Jahr: {neuesBuch.Jahr}, Verlag: {neuesBuch.Verlag}, Preis: {neuesBuch.Preis:C}\n");

            gesamtKosten.Text = buchListe.Sum(buch => buch.Preis).ToString("C");
        }

        public struct Buch
        {
            public string Titel;
            public string Autor;
            public int Jahr;
            public string Verlag;
            public double Preis;

            public Buch(string titel, string autor, int jahr, string verlag, double preis)
            {
                Titel = titel;
                Autor = autor;
                Jahr = jahr;
                Verlag = verlag;
                Preis = preis;
            }
        }

        #region Windows Form Designer generated code

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

            // Diðer tasarým kodlarý...

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
    }
}
