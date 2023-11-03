namespace OpenTheSafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            totalGuesses = 0;

            InitializeComponent();
            generateNumbers();

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
        }
        private void crackSafeButton_Click(object sender, EventArgs e) //validates answers
        {
            totalGuesses++;

            if (didWin())
            {
                numberHistory.Items.Clear();
                numberHistory.Items.Add("You won!");
            }

            if (totalGuesses >= 5)
            {
                numberHistory.Items.Clear();
                numberHistory.Items.Add("You've lost!");
            }

            // 1st number
            if (validateGuess(number1.Value, answer1))
            {
                pictureBox2.Visible = true;
                number1.BackColor = Color.Green;
            }
            else if (isANumberAway(number1.Value, answer1))
            {
                //image shows that you've "clicked"
                pictureBox1.Visible = true;
                number1.BackColor = Color.Yellow;
            }
            else
            {
                number1.BackColor = Color.Red;
                numberHistory.Items.Add("Number 1 is not close.");
            }

            // 2nd number
            if (validateGuess(number2.Value, answer2))
            {
                pictureBox2.Visible = true;
                number2.BackColor = Color.Green;
            }
            else if (isANumberAway(number2.Value, answer2))
            {
                //image shows that you've "clicked"
                pictureBox1.Visible = true;
                number2.BackColor = Color.Yellow;
            }
            else
            {
                number2.BackColor = Color.Red;
                numberHistory.Items.Add("Number 2 is not close.");
            }

            // 3rd number
            if (validateGuess(number3.Value, answer3))
            {
                pictureBox2.Visible = true;
                number3.BackColor = Color.Green;
            }
            else if (isANumberAway(number3.Value, answer3))
            {
                //image shows that you've "clicked"
                pictureBox1.Visible = true;
                number3.BackColor = Color.Yellow;
            }
            else
            {
                number3.BackColor = Color.Red;
                numberHistory.Items.Add("Number 3 is not close.");
            }


        }

        private void number1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void number2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void number3_ValueChanged(object sender, EventArgs e)
        {
        }

        private bool didWin()
        {
            if (validateGuess(number1.Value, answer1) && validateGuess(number2.Value, answer2) && validateGuess(number3.Value, answer3))
            {
                return true;
            }

            return false;
        }

        private void generateNumbers()
        {
            Random r = new Random();
            answer1 = r.Next(0, 9);
            answer2 = r.Next(0, 9);
            answer3 = r.Next(0, 9);

            //generates numbers
        }

        private bool isANumberAway(decimal value, int answer)
        {
            //less than
            if ((value - 1) == answer) return true;

            //greater than
            if ((value + 1) == answer) return true;


            return false;
        }
        private bool validateGuess(decimal value, int answer)
        {
            if (value == answer)
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e) //uHHH cheat button
        {
            string answers = "Safe code is: " + answer1.ToString() + ", " + answer2.ToString() + ", " + answer3.ToString();

            numberHistory.Items.Add(answers);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void reset_Click(object sender, EventArgs e)
        {
            //resets the game
            generateNumbers();
            totalGuesses = 0;

            //clears board and previous items (if any)
            numberHistory.Items.Clear();
            number1.BackColor = Color.White;
            number2.BackColor = Color.White;
            number3.BackColor = Color.White;

            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //leaves application
            Application.Exit();
        }


    }
}