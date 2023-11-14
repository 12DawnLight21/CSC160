using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_GUIs.Logic.Characters
{
    public class Player : Actor
    {
        bool active = false;
        public Player() 
        {
            //sets a default player if the user doesnt want to make one
            m_class = Enums.Classes.homestuckClass.KNIGHT; //determines your class
            active = true;
            m_aspect = Enums.Aspects.homestuckAspect.SPACE; //determines your magic
            m_strifeDeck = Enums.StrifeDeck.homestuckStrifeDeck.FISTKIND; //determines the weapon
            m_name = "Dawn";
            m_weapon = "Magma's Fury"; //weapon names dont matter, could be random generated perhaps

            m_money = 500;

            m_str = 16;
            m_con = 14;
            m_dex = 12;
            m_int = 11;
            m_chr = 17;
            m_wis = 10;

            //set image to Dawn's image
        }

        //move
        //ACTIVE means physical stats are buffed (str, con, chr)
        //PASSIVE means non-physical stats are buffed (wis, int, dex)

        public bool isActive(Enum className)
        {
            switch (className)
            {
                case Enums.Classes.homestuckClass.LORD:
                    active = true;
                    break;
                case Enums.Classes.homestuckClass.THIEF:
                    active = true;
                    break;
                case Enums.Classes.homestuckClass.PRINCE:
                    active = true;
                    break;
                case Enums.Classes.homestuckClass.WITCH:
                    active = true;
                    break;
                case Enums.Classes.homestuckClass.KNIGHT:
                    active = true;
                    break;
                case Enums.Classes.homestuckClass.MAID:
                    active = true;
                    break;
                case Enums.Classes.homestuckClass.MAGE:
                    active = true;
                    break;
            }
            return active; //SHOULD return false if it doesnt go through the switch
        }


    }
}
