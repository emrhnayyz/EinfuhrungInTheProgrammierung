namespace Vep_Dataa_Ü02_Gutachtenschreiber
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
            rtbAll = new RichTextBox();
            groupBox2 = new GroupBox();
            btnAnlegen = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            btnGenTitel = new Button();
            groupBox3 = new GroupBox();
            groupBox5 = new GroupBox();
            button1 = new Button();
            richTextBox2 = new RichTextBox();
            groupBox4 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            numericUpDown5 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            tbInfoMatrikel = new TextBox();
            label6 = new Label();
            tbInfoTyp = new TextBox();
            label4 = new Label();
            rfbInfoTitel = new RichTextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbAll);
            groupBox1.Location = new Point(22, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alle Arbeiten";
            // 
            // rtbAll
            // 
            rtbAll.Location = new Point(12, 37);
            rtbAll.Name = "rtbAll";
            rtbAll.Size = new Size(265, 151);
            rtbAll.TabIndex = 0;
            rtbAll.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAnlegen);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnGenTitel);
            groupBox2.Location = new Point(19, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 380);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Arbeit anlegen";
            // 
            // btnAnlegen
            // 
            btnAnlegen.Location = new Point(205, 240);
            btnAnlegen.Name = "btnAnlegen";
            btnAnlegen.Size = new Size(75, 23);
            btnAnlegen.TabIndex = 7;
            btnAnlegen.Text = "Anlegen";
            btnAnlegen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 211);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "Typ";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(160, 178);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 197584, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-2, 186);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Matrikel";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(77, 68);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(203, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 68);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "Titel";
            // 
            // btnGenTitel
            // 
            btnGenTitel.Location = new Point(136, 31);
            btnGenTitel.Name = "btnGenTitel";
            btnGenTitel.Size = new Size(150, 23);
            btnGenTitel.TabIndex = 0;
            btnGenTitel.Text = "Titel generieren";
            btnGenTitel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(tbInfoMatrikel);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(tbInfoTyp);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(rfbInfoTitel);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(315, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(528, 624);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "AbschlussArbeit";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(richTextBox2);
            groupBox5.Location = new Point(3, 444);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(499, 172);
            groupBox5.TabIndex = 8;
            groupBox5.TabStop = false;
            groupBox5.Text = "Gutachten";
            // 
            // button1
            // 
            button1.Location = new Point(6, 40);
            button1.Name = "button1";
            button1.Size = new Size(489, 23);
            button1.TabIndex = 7;
            button1.Text = "Generieren";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 79);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(487, 76);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(numericUpDown5);
            groupBox4.Controls.Add(numericUpDown4);
            groupBox4.Controls.Add(numericUpDown3);
            groupBox4.Controls.Add(numericUpDown2);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(6, 286);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(492, 146);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Teilnoten";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(315, 63);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 3;
            label10.Text = "Quelienarbeit";
            label10.Click += label5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(344, 34);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 3;
            label9.Text = "Formalia";
            label9.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 62);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 3;
            label8.Text = "Sprache";
            label8.Click += label5_Click;
            // 
            // numericUpDown5
            // 
            numericUpDown5.DecimalPlaces = 1;
            numericUpDown5.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown5.Location = new Point(400, 61);
            numericUpDown5.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(34, 23);
            numericUpDown5.TabIndex = 4;
            numericUpDown5.Value = new decimal(new int[] { 300, 0, 0, 131072 });
            numericUpDown5.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown4
            // 
            numericUpDown4.DecimalPlaces = 1;
            numericUpDown4.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown4.Location = new Point(400, 32);
            numericUpDown4.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(34, 23);
            numericUpDown4.TabIndex = 4;
            numericUpDown4.Value = new decimal(new int[] { 300, 0, 0, 131072 });
            numericUpDown4.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 1;
            numericUpDown3.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown3.Location = new Point(105, 62);
            numericUpDown3.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(34, 23);
            numericUpDown3.TabIndex = 4;
            numericUpDown3.Value = new decimal(new int[] { 300, 0, 0, 131072 });
            numericUpDown3.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 1;
            numericUpDown2.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDown2.Location = new Point(105, 27);
            numericUpDown2.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(34, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 300, 0, 0, 131072 });
            numericUpDown2.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 32);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 3;
            label7.Text = "Inhalt";
            label7.Click += label5_Click;
            // 
            // tbInfoMatrikel
            // 
            tbInfoMatrikel.Location = new Point(81, 207);
            tbInfoMatrikel.Name = "tbInfoMatrikel";
            tbInfoMatrikel.Size = new Size(100, 23);
            tbInfoMatrikel.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 210);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 6;
            label6.Text = "Typ";
            label6.Click += label3_Click;
            // 
            // tbInfoTyp
            // 
            tbInfoTyp.Location = new Point(340, 204);
            tbInfoTyp.Name = "tbInfoTyp";
            tbInfoTyp.Size = new Size(100, 23);
            tbInfoTyp.TabIndex = 3;
            tbInfoTyp.TextChanged += tbInfoTyp_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 37);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 1;
            label4.Text = "Titel";
            // 
            // rfbInfoTitel
            // 
            rfbInfoTitel.Location = new Point(6, 55);
            rfbInfoTitel.Name = "rfbInfoTitel";
            rfbInfoTitel.ReadOnly = true;
            rfbInfoTitel.Size = new Size(492, 133);
            rfbInfoTitel.TabIndex = 2;
            rfbInfoTitel.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 207);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 3;
            label5.Text = "Matrikel";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 668);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Thesis Grader";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox rtbAll;
        private GroupBox groupBox2;
        private Button btnGenTitel;
        private Button btnAnlegen;
        private Label label3;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox tbInfoMatrikel;
        private TextBox tbInfoTyp;
        private Label label4;
        private RichTextBox rfbInfoTitel;
        private Label label5;
        private Label label6;
        private GroupBox groupBox4;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown5;
        private GroupBox groupBox5;
        private Button button1;
        private RichTextBox richTextBox2;
    }
}