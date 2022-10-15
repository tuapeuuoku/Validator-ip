namespace IPVALIDATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sprawdzip();
            klasa();

        }

        public void sprawdzip()
        {
            if (numericUpDown4.Value <= 255 && numericUpDown3.Value <= 255 && numericUpDown2.Value <= 255 && numericUpDown1.Value <= 255 && maska.Value >= 1 && maska.Value <= 30)
            {
                label2.Visible = true;
                label2.ForeColor = Color.Green;
                label2.Text = "Git";

            }
            else
            {

                label2.Visible = true;
                label2.ForeColor = Color.Red;
                label2.Text = "Nie git";
            }


        }
        private void klasa()
        {
            if (numericUpDown1.Value <= 127 && maska.Value <= 8)
            {
                klasaip.Text = "Klasa A";
                klasaip.Visible = true;
            }
            else if
                (numericUpDown1.Value >= 128 && numericUpDown1.Value <= 191 && maska.Value >= 9 && maska.Value <= 16)
            {
                klasaip.Text = "Klasa B";
                klasaip.Visible = true;
            }
            else if (numericUpDown1.Value >= 192 && numericUpDown1.Value <= 223 && maska.Value >= 17 && maska.Value <= 24)
            {
                klasaip.Text = "Klasa C";
                klasaip.Visible = true;
            }
            else if (numericUpDown1.Value >= 224 && numericUpDown1.Value <= 239 && maska.Value == 24)
            {
                klasaip.Text = "klasa D";
                klasaip.Visible = true;
            }
            else if (numericUpDown1.Value >= 240 && numericUpDown1.Value <= 247 && maska.Value >= 25)
            {
                klasaip.Text = "klasa E";
                klasaip.Visible = true;
            }
            else if (numericUpDown1.Value >= 248 && numericUpDown1.Value <= 255 && maska.Value >= 25)
            {
                klasaip.Text = "klasa F";
                klasaip.Visible = true;
            }
            else
            {
                klasaip.Text = "¯adna klasa nie pasuje do wpisanych danych";
                klasaip.Visible = true;
                label2.Text = "Nie git";
                label2.ForeColor = Color.Red;
                label4.Visible = true;
                label4.Text = "Klasa A >127 oraz <=8";
                label6.Visible = true;
                label6.Text = "Klasa B <=127 >=191 oraz >=9 <=19";
                label7.Visible = true;
                label7.Text = "Klasa C <=192 >=223 oraz >=17 <=24";
                label8.Visible = true;
                label8.Text = "Klasa D <=224 >=239 oraz ==24";
                label9.Visible = true;
                label9.Text = "Klasa E <=240 >=247 oraz >=25";
                label9.Visible = true;
                label9.Text = "Klasa F <=248 >=255 oraz >=25";







            }
        }
        private void button_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {


        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}