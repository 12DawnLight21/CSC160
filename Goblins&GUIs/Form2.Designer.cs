namespace Goblins_GUIs
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backButton = new Button();
            strSetter = new NumericUpDown();
            conSetter = new NumericUpDown();
            dexSetter = new NumericUpDown();
            intSetter = new NumericUpDown();
            chrSetter = new NumericUpDown();
            wisSetter = new NumericUpDown();
            nameSetter = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            playerClass = new ComboBox();
            playerAspect = new ComboBox();
            playerStrifeDeck = new ComboBox();
            playerWeapon = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            explinationBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)strSetter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conSetter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dexSetter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intSetter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrSetter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wisSetter).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.Lime;
            backButton.Location = new Point(32, 687);
            backButton.Name = "backButton";
            backButton.Size = new Size(124, 34);
            backButton.TabIndex = 0;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // strSetter
            // 
            strSetter.Location = new Point(913, 66);
            strSetter.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            strSetter.Name = "strSetter";
            strSetter.Size = new Size(77, 31);
            strSetter.TabIndex = 1;
            // 
            // conSetter
            // 
            conSetter.Location = new Point(913, 127);
            conSetter.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            conSetter.Name = "conSetter";
            conSetter.Size = new Size(77, 31);
            conSetter.TabIndex = 2;
            // 
            // dexSetter
            // 
            dexSetter.Location = new Point(913, 190);
            dexSetter.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            dexSetter.Name = "dexSetter";
            dexSetter.Size = new Size(77, 31);
            dexSetter.TabIndex = 3;
            // 
            // intSetter
            // 
            intSetter.Location = new Point(913, 250);
            intSetter.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            intSetter.Name = "intSetter";
            intSetter.Size = new Size(77, 31);
            intSetter.TabIndex = 4;
            // 
            // chrSetter
            // 
            chrSetter.Location = new Point(913, 316);
            chrSetter.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            chrSetter.Name = "chrSetter";
            chrSetter.Size = new Size(77, 31);
            chrSetter.TabIndex = 5;
            // 
            // wisSetter
            // 
            wisSetter.Location = new Point(913, 378);
            wisSetter.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            wisSetter.Name = "wisSetter";
            wisSetter.Size = new Size(77, 31);
            wisSetter.TabIndex = 6;
            // 
            // nameSetter
            // 
            nameSetter.Location = new Point(168, 66);
            nameSetter.Name = "nameSetter";
            nameSetter.Size = new Size(172, 31);
            nameSetter.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(740, 68);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 8;
            label1.Text = "Strength";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(727, 127);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 9;
            label2.Text = "Constitution";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(740, 378);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 10;
            label3.Text = "Wisdom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(737, 316);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 11;
            label4.Text = "Charisma";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(727, 252);
            label5.Name = "label5";
            label5.Size = new Size(123, 28);
            label5.TabIndex = 12;
            label5.Text = "Intelligence";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(737, 190);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 13;
            label6.Text = "Dexterity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 69);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 14;
            label7.Text = "Player Name";
            // 
            // playerClass
            // 
            playerClass.FormattingEnabled = true;
            playerClass.Location = new Point(168, 252);
            playerClass.Name = "playerClass";
            playerClass.Size = new Size(172, 33);
            playerClass.TabIndex = 15;
            // 
            // playerAspect
            // 
            playerAspect.FormattingEnabled = true;
            playerAspect.Location = new Point(168, 314);
            playerAspect.Name = "playerAspect";
            playerAspect.Size = new Size(172, 33);
            playerAspect.TabIndex = 16;
            // 
            // playerStrifeDeck
            // 
            playerStrifeDeck.FormattingEnabled = true;
            playerStrifeDeck.Location = new Point(168, 190);
            playerStrifeDeck.Name = "playerStrifeDeck";
            playerStrifeDeck.Size = new Size(172, 33);
            playerStrifeDeck.TabIndex = 17;
            // 
            // playerWeapon
            // 
            playerWeapon.Location = new Point(168, 126);
            playerWeapon.Name = "playerWeapon";
            playerWeapon.Size = new Size(172, 31);
            playerWeapon.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 127);
            label8.Name = "label8";
            label8.Size = new Size(151, 28);
            label8.TabIndex = 19;
            label8.Text = "Weapon Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(32, 193);
            label9.Name = "label9";
            label9.Size = new Size(117, 28);
            label9.TabIndex = 20;
            label9.Text = "Strife Deck";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(32, 256);
            label10.Name = "label10";
            label10.Size = new Size(124, 28);
            label10.TabIndex = 21;
            label10.Text = "Player Class";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(21, 316);
            label11.Name = "label11";
            label11.Size = new Size(141, 28);
            label11.TabIndex = 22;
            label11.Text = "Player Aspect";
            // 
            // explinationBox
            // 
            explinationBox.Location = new Point(168, 529);
            explinationBox.Name = "explinationBox";
            explinationBox.Size = new Size(822, 192);
            explinationBox.TabIndex = 23;
            explinationBox.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 755);
            Controls.Add(explinationBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(playerWeapon);
            Controls.Add(playerStrifeDeck);
            Controls.Add(playerAspect);
            Controls.Add(playerClass);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameSetter);
            Controls.Add(wisSetter);
            Controls.Add(chrSetter);
            Controls.Add(intSetter);
            Controls.Add(dexSetter);
            Controls.Add(conSetter);
            Controls.Add(strSetter);
            Controls.Add(backButton);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)strSetter).EndInit();
            ((System.ComponentModel.ISupportInitialize)conSetter).EndInit();
            ((System.ComponentModel.ISupportInitialize)dexSetter).EndInit();
            ((System.ComponentModel.ISupportInitialize)intSetter).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrSetter).EndInit();
            ((System.ComponentModel.ISupportInitialize)wisSetter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private NumericUpDown strSetter;
        private NumericUpDown conSetter;
        private NumericUpDown dexSetter;
        private NumericUpDown intSetter;
        private NumericUpDown chrSetter;
        private NumericUpDown wisSetter;
        private TextBox nameSetter;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox playerClass;
        private ComboBox playerAspect;
        private ComboBox playerStrifeDeck;
        private TextBox playerWeapon;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private RichTextBox explinationBox;
    }
}