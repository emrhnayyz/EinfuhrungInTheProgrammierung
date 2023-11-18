namespace Hausaufgabe_03_1_TippSpiel
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private (int heimScore, int ausw�rtsScore) GenerateRandomScore()
        {

            int heimScore = random.Next(0, 10);
            int ausw�rtsScore = random.Next(0, 10);
            return (heimScore, ausw�rtsScore);
        }

        private int PunkteRechner(int score1, int score2, int tippedHeimScore, int tippedAusw�rtsScore)
        {
            int p;
            if (score1 == tippedHeimScore && score2 == tippedAusw�rtsScore)
            {

                return 3;
            }
            else if ((score1 > score2 && tippedHeimScore > tippedAusw�rtsScore) ||
                     (score1 < score2 && tippedHeimScore < tippedAusw�rtsScore) ||
                     (score1 == score2 && tippedHeimScore == tippedAusw�rtsScore))
            {

                return 2;
            }
            else if ((score1 > score2 && tippedHeimScore > tippedAusw�rtsScore) ||
                     (score1 < score2 && tippedHeimScore < tippedAusw�rtsScore))
            {

                return 1;
            }
            else
            {

                return 0;
            }
        }













        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void btn_tipp_Click(object sender, EventArgs e)
        {
            (int score1, int score2) = GenerateRandomScore(); //Zuf�llige Ergebnis gernerieren

            ergebnis_Label.Text = score1 + ":" + score2; //Ergebnis ausgeben

            tippedScore.Text = heimErgebnis.Value + ":" + ausw�rtsErgebnis.Value;

            int tippedHeimScore = (int)heimErgebnis.Value;
            int tippedAusw�rtsScore = (int)ausw�rtsErgebnis.Value; //getippte Ergebnisse

            int punkte = PunkteRechner(score1, score2, tippedHeimScore, tippedAusw�rtsScore);

            punkt_textbox.Text = punkte.ToString();//Punkte ausgeben

            int anzahlTore = score1 + score2;
            string toreText;

            switch (anzahlTore)
            {
                case int n when (n <= 2):
                    toreText = "Wenige Tore (0 bis 2)";
                    break;
                case int n when (n >= 3 && n <= 4):
                    toreText = "Einige Tore (3-4)";
                    break;
                default:
                    toreText = "Viele Tore (mehr als 4)";
                    break;
            }

            MessageBox.Show($"Anzahl Tore: {anzahlTore}\n{toreText}", "Tore Auswertung");
        













    }

        private void ausw�rtsErgebnis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void heimErgebnis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ergebnis_Label_TextChanged(object sender, EventArgs e)
        {

        }

        private void tippedScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void punkt_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}