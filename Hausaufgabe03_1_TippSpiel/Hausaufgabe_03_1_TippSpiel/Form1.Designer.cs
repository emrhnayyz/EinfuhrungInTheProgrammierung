namespace Hausaufgabe_03_1_TippSpiel
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
            groupBox1 = new GroupBox();
            heimErgebnis = new NumericUpDown();
            btn_tipp = new Button();
            label2 = new Label();
            label1 = new Label();
            auswärtsErgebnis = new NumericUpDown();
            groupBox2 = new GroupBox();
            punkt_textbox = new TextBox();
            punkt_label = new Label();
            tippedScore = new TextBox();
            label4 = new Label();
            ergebnis_Label = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)heimErgebnis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)auswärtsErgebnis).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(heimErgebnis);
            groupBox1.Controls.Add(btn_tipp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(auswärtsErgebnis);
            groupBox1.Location = new Point(18, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 218);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "TippScore";
            // 
            // heimErgebnis
            // 
            heimErgebnis.Location = new Point(39, 55);
            heimErgebnis.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            heimErgebnis.Name = "heimErgebnis";
            heimErgebnis.Size = new Size(89, 23);
            heimErgebnis.TabIndex = 3;
            heimErgebnis.TextAlign = HorizontalAlignment.Center;
            heimErgebnis.ValueChanged += heimErgebnis_ValueChanged;
            // 
            // btn_tipp
            // 
            btn_tipp.Location = new Point(34, 94);
            btn_tipp.Name = "btn_tipp";
            btn_tipp.Size = new Size(240, 23);
            btn_tipp.TabIndex = 2;
            btn_tipp.Text = "Tipp";
            btn_tipp.UseVisualStyleBackColor = true;
            btn_tipp.Click += btn_tipp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 37);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Auswärtsergebnis ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Heim Ergebnis";
            // 
            // auswärtsErgebnis
            // 
            auswärtsErgebnis.Location = new Point(171, 55);
            auswärtsErgebnis.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            auswärtsErgebnis.Name = "auswärtsErgebnis";
            auswärtsErgebnis.Size = new Size(84, 23);
            auswärtsErgebnis.TabIndex = 0;
            auswärtsErgebnis.TextAlign = HorizontalAlignment.Center;
            auswärtsErgebnis.ValueChanged += auswärtsErgebnis_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(punkt_textbox);
            groupBox2.Controls.Add(punkt_label);
            groupBox2.Controls.Add(tippedScore);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(ergebnis_Label);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(18, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 278);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ergebnis und Toren";
            // 
            // punkt_textbox
            // 
            punkt_textbox.Location = new Point(248, 73);
            punkt_textbox.Name = "punkt_textbox";
            punkt_textbox.ReadOnly = true;
            punkt_textbox.Size = new Size(100, 23);
            punkt_textbox.TabIndex = 5;
            punkt_textbox.TextChanged += punkt_textbox_TextChanged;
            // 
            // punkt_label
            // 
            punkt_label.AutoSize = true;
            punkt_label.Location = new Point(277, 38);
            punkt_label.Name = "punkt_label";
            punkt_label.Size = new Size(44, 15);
            punkt_label.TabIndex = 4;
            punkt_label.Text = "Punkt :";
            // 
            // tippedScore
            // 
            tippedScore.Location = new Point(148, 73);
            tippedScore.Name = "tippedScore";
            tippedScore.ReadOnly = true;
            tippedScore.Size = new Size(84, 23);
            tippedScore.TabIndex = 3;
            tippedScore.TextAlign = HorizontalAlignment.Center;
            tippedScore.TextChanged += tippedScore_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 76);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 2;
            label4.Text = "Ihre Vorhersage :";
            // 
            // ergebnis_Label
            // 
            ergebnis_Label.Location = new Point(148, 38);
            ergebnis_Label.Name = "ergebnis_Label";
            ergebnis_Label.ReadOnly = true;
            ergebnis_Label.Size = new Size(84, 23);
            ergebnis_Label.TabIndex = 1;
            ergebnis_Label.TextAlign = HorizontalAlignment.Center;
            ergebnis_Label.TextChanged += ergebnis_Label_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 41);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 0;
            label3.Text = "Spiel Ergebniss :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 598);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Tipp Anwendung";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)heimErgebnis).EndInit();
            ((System.ComponentModel.ISupportInitialize)auswärtsErgebnis).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private NumericUpDown auswärtsErgebnis;
        private Button btn_tipp;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox ergebnis_Label;
        private TextBox tippedScore;
        private Label label4;
        private NumericUpDown heimErgebnis;
        private TextBox punkt_textbox;
        private Label punkt_label;
    }
}