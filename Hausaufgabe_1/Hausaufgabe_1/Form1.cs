namespace Hausaufgabe_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = tbName.Text;
            String serie = tbSerie.Text;

            MessageBox.Show("Hello World,meine Name ist  " + name + "  und meine Lieblingsserie ist " + serie);
        }
    }
}