namespace VEP_ÜB__Control_Mathematik
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
            num_a = new NumericUpDown();
            bt_a = new Button();
            tb_a = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            num_b = new NumericUpDown();
            tb_b = new TextBox();
            bt_b = new Button();
            groupBox3 = new GroupBox();
            rtb_c = new RichTextBox();
            num_c = new NumericUpDown();
            bt_c = new Button();
            ((System.ComponentModel.ISupportInitialize)num_a).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_b).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_c).BeginInit();
            SuspendLayout();
            // 
            // num_a
            // 
            num_a.Location = new Point(19, 38);
            num_a.Name = "num_a";
            num_a.Size = new Size(120, 23);
            num_a.TabIndex = 0;
            num_a.TextAlign = HorizontalAlignment.Center;
            num_a.ValueChanged += num_a_ValueChanged;
            // 
            // bt_a
            // 
            bt_a.Location = new Point(145, 37);
            bt_a.Name = "bt_a";
            bt_a.Size = new Size(75, 23);
            bt_a.TabIndex = 1;
            bt_a.Text = "Berechner";
            bt_a.UseVisualStyleBackColor = true;
            bt_a.Click += btb_Click;
            // 
            // tb_a
            // 
            tb_a.Location = new Point(226, 37);
            tb_a.Name = "tb_a";
            tb_a.Size = new Size(100, 23);
            tb_a.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(num_a);
            groupBox1.Controls.Add(tb_a);
            groupBox1.Controls.Add(bt_a);
            groupBox1.Location = new Point(44, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 102);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fakultät berechnen";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(num_b);
            groupBox2.Controls.Add(tb_b);
            groupBox2.Controls.Add(bt_b);
            groupBox2.Location = new Point(44, 167);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 102);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Primzahltest";
            // 
            // num_b
            // 
            num_b.Location = new Point(19, 38);
            num_b.Name = "num_b";
            num_b.Size = new Size(120, 23);
            num_b.TabIndex = 0;
            num_b.TextAlign = HorizontalAlignment.Center;
            num_b.ValueChanged += num_b_ValueChanged;
            // 
            // tb_b
            // 
            tb_b.Location = new Point(226, 37);
            tb_b.Name = "tb_b";
            tb_b.Size = new Size(100, 23);
            tb_b.TabIndex = 2;
            // 
            // bt_b
            // 
            bt_b.Location = new Point(145, 37);
            bt_b.Name = "bt_b";
            bt_b.Size = new Size(75, 23);
            bt_b.TabIndex = 1;
            bt_b.Text = "Starte";
            bt_b.UseVisualStyleBackColor = true;
            bt_b.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtb_c);
            groupBox3.Controls.Add(num_c);
            groupBox3.Controls.Add(bt_c);
            groupBox3.Location = new Point(44, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(540, 341);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Das Sieb des Eratosthenes";
            // 
            // rtb_c
            // 
            rtb_c.Location = new Point(226, 38);
            rtb_c.Name = "rtb_c";
            rtb_c.Size = new Size(203, 273);
            rtb_c.TabIndex = 2;
            rtb_c.Text = "";
            // 
            // num_c
            // 
            num_c.Location = new Point(19, 38);
            num_c.Name = "num_c";
            num_c.Size = new Size(120, 23);
            num_c.TabIndex = 0;
            num_c.TextAlign = HorizontalAlignment.Center;
            // 
            // bt_c
            // 
            bt_c.Location = new Point(145, 37);
            bt_c.Name = "bt_c";
            bt_c.Size = new Size(75, 23);
            bt_c.TabIndex = 1;
            bt_c.Text = "Los";
            bt_c.UseVisualStyleBackColor = true;
            bt_c.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 702);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Mathematik";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)num_a).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_b).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)num_c).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown num_a;
        private Button bt_a;
        private TextBox tb_a;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown num_b;
        private TextBox tb_b;
        private Button bt_b;
        private GroupBox groupBox3;
        private RichTextBox rtb_c;
        private NumericUpDown num_c;
        private Button bt_c;
    }
}