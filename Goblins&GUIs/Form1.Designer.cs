namespace Goblins_GUIs
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
            gameStart = new Button();
            gameQuit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gameStart
            // 
            gameStart.BackColor = Color.Lime;
            gameStart.Location = new Point(472, 567);
            gameStart.Name = "gameStart";
            gameStart.Size = new Size(271, 53);
            gameStart.TabIndex = 0;
            gameStart.Text = "Start Game";
            gameStart.UseVisualStyleBackColor = false;
            gameStart.Click += gameStart_Click;
            // 
            // gameQuit
            // 
            gameQuit.BackColor = Color.Lime;
            gameQuit.Location = new Point(472, 646);
            gameQuit.Name = "gameQuit";
            gameQuit.Size = new Size(271, 53);
            gameQuit.TabIndex = 1;
            gameQuit.Text = "Quit";
            gameQuit.UseVisualStyleBackColor = false;
            gameQuit.Click += gameQuit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 83);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1202, 828);
            Controls.Add(pictureBox1);
            Controls.Add(gameQuit);
            Controls.Add(gameStart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button gameStart;
        private Button gameQuit;
        private PictureBox pictureBox1;
    }
}