using Goblins_GUIs.Logic.Characters;
using Goblins_GUIs.Logic.Characters.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goblins_GUIs;

namespace Goblins_GUIs.Logic
{
    public class DataManager
    {
        // needs the player class
        private Player player;
        // needs the form class
        private Form formm;

        public DataManager(Form form)
        {
            this.formm = form;
            this.player = new Player();
        }
        public DataManager(Player player, Form Form2) 
        {
            this.formm = Form2;
            this.player = player;
        }

        // data binder goes here
        public void dataBinder()
        {
            Form2 form = (Form2)formm;
            var playerName = form.Controls["playerName"] as TextBox;
            var playerWeapon = form.Controls["playerWeapon"] as TextBox;

            // numeric updowns
            form.strUpDown.DataBindings.Add("Value", player, "m_str", false, DataSourceUpdateMode.OnPropertyChanged);
            form.conUpDown.DataBindings.Add("Value", player, "m_con", false, DataSourceUpdateMode.OnPropertyChanged);
            form.dexUpDown.DataBindings.Add("Value", player, "m_dex", false, DataSourceUpdateMode.OnPropertyChanged);
            form.intUpDown.DataBindings.Add("Value", player, "m_int", false, DataSourceUpdateMode.OnPropertyChanged);
            form.chrUpDown.DataBindings.Add("Value", player, "m_chr", false, DataSourceUpdateMode.OnPropertyChanged);
            form.wisUpDown.DataBindings.Add("Value", player, "m_wis", false, DataSourceUpdateMode.OnPropertyChanged);

            // textboxes
            if (playerName != null) playerName.DataBindings.Add("Text", player, "m_name");
            if (playerWeapon != null) playerWeapon.DataBindings.Add("Text", player, "m_wepaon");

            // enums

        }

        // same for the dropdown menu initialization stuff
        public void setDropdownValues()
        {
            Form2 form = (Form2)formm;
            var strifeDeck = form.Controls["playerStrifeDeck"] as ComboBox;
            var playerClass = form.Controls["playerClass"] as ComboBox;
            var playerAspect = form.Controls["playerAspect"] as ComboBox;

            // chatGBT helped me get this logic down for this funciton -- https://chat.openai.com/share/eae1d6dd-e317-4f0c-9e5d-0e8e386bd373
            foreach (StrifeDeck.homestuckStrifeDeck value in Enum.GetValues(typeof(StrifeDeck.homestuckStrifeDeck)))
            {
                if (strifeDeck != null)
                {
                    strifeDeck.Items.Add(value); // iters through strifeDeck enum, sets dropdown items
                }                
            }

            foreach (Classes.homestuckClass value in Enum.GetValues(typeof(Classes.homestuckClass)))
            {
                if (playerClass != null)
                {
                    playerClass.Items.Add(value);
                }
            }

            foreach (Aspects.homestuckAspect value in Enum.GetValues(typeof(Aspects.homestuckAspect)))
            {
                if (playerAspect != null) 
                {
                    playerAspect.Items.Add(value);
                }
            }
        }

    }
}