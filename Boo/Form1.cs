namespace Boo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "BOO";
        }

        private void Button0_Click_Scare(object sender, EventArgs e)
        {
            Random myRandomSeed = new Random();
            int randomNumber = myRandomSeed.Next(0, 9); //inclusive of upper, exclusive of lower

            label1.BackColor = Color.Orange;
        }
    }
}