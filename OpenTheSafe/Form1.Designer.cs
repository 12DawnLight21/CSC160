namespace OpenTheSafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            number1 = new NumericUpDown();
            number2 = new NumericUpDown();
            number3 = new NumericUpDown();
            crackSafeButton = new Button();
            cheat = new Button();
            numberHistory = new ListBox();
            reset = new Button();
            exit = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 158);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // number1
            // 
            number1.Location = new Point(60, 53);
            number1.Name = "number1";
            number1.Size = new Size(122, 31);
            number1.TabIndex = 1;
            number1.ValueChanged += number1_ValueChanged;
            // 
            // number2
            // 
            number2.Location = new Point(435, 53);
            number2.Name = "number2";
            number2.Size = new Size(122, 31);
            number2.TabIndex = 2;
            number2.ValueChanged += number2_ValueChanged;
            // 
            // number3
            // 
            number3.Location = new Point(824, 53);
            number3.Name = "number3";
            number3.Size = new Size(122, 31);
            number3.TabIndex = 3;
            number3.ValueChanged += number3_ValueChanged;
            // 
            // crackSafeButton
            // 
            crackSafeButton.Location = new Point(419, 467);
            crackSafeButton.Name = "crackSafeButton";
            crackSafeButton.Size = new Size(181, 65);
            crackSafeButton.TabIndex = 4;
            crackSafeButton.Text = "Open the Safe!";
            crackSafeButton.UseVisualStyleBackColor = true;
            crackSafeButton.Click += crackSafeButton_Click;
            // 
            // cheat
            // 
            cheat.Location = new Point(445, 581);
            cheat.Name = "cheat";
            cheat.Size = new Size(112, 34);
            cheat.TabIndex = 5;
            cheat.Text = "Cheater";
            cheat.UseVisualStyleBackColor = true;
            cheat.Click += button1_Click;
            // 
            // numberHistory
            // 
            numberHistory.FormattingEnabled = true;
            numberHistory.ItemHeight = 25;
            numberHistory.Location = new Point(750, 411);
            numberHistory.Name = "numberHistory";
            numberHistory.Size = new Size(196, 204);
            numberHistory.TabIndex = 6;
            numberHistory.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // reset
            // 
            reset.Location = new Point(50, 482);
            reset.Name = "reset";
            reset.Size = new Size(122, 50);
            reset.TabIndex = 7;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // exit
            // 
            exit.Location = new Point(50, 581);
            exit.Name = "exit";
            exit.Size = new Size(122, 50);
            exit.TabIndex = 8;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(606, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 158);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 695);
            Controls.Add(pictureBox2);
            Controls.Add(exit);
            Controls.Add(reset);
            Controls.Add(numberHistory);
            Controls.Add(cheat);
            Controls.Add(crackSafeButton);
            Controls.Add(number3);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)number1).EndInit();
            ((System.ComponentModel.ISupportInitialize)number2).EndInit();
            ((System.ComponentModel.ISupportInitialize)number3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private NumericUpDown number1;
        private NumericUpDown number2;
        private NumericUpDown number3;
        private Button crackSafeButton;

        private int answer1;
        private int answer2;
        private int answer3;

        private int totalGuesses;

        private Button cheat;
        private ListBox numberHistory;
        private Button reset;
        private Button exit;
        private PictureBox pictureBox2;
    }
}