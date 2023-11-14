using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Goblins_GUIs.Logic;
using Goblins_GUIs.Logic.Characters;

namespace Goblins_GUIs
{
    public partial class Form2 : Form
    {
        // character creation

        public Form2()
        {
            DataManager dm = new DataManager(this);
            InitializeComponent();
            dm.setDropdownValues();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var form = new Form1(); //replace new Form1() with your form's name
            form.Show();
            form.Activate();
            this.Hide(); // hides form 2
        }

        // data manager couldnt see them, now it can
        public NumericUpDown strUpDown { get { return strSetter; } }
        public NumericUpDown conUpDown { get { return conSetter; } }
        public NumericUpDown dexUpDown { get { return dexSetter; } }
        public NumericUpDown intUpDown { get { return intSetter; } }
        public NumericUpDown chrUpDown { get { return chrSetter; } }
        public NumericUpDown wisUpDown { get { return wisSetter; } }

    }
}
