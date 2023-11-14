namespace Goblins_GUIs
{
    public partial class Form1 : Form
    {
        // main menu
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameStart_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
            form2.Activate();
            this.Hide(); // hides form 1
        }

        private void gameQuit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // leaves the game
        }
    }
}