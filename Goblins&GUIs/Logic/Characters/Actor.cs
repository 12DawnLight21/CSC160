using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_GUIs.Logic.Characters
{
    public abstract class Actor
    {
        public string m_name = "";
        public string m_weapon = "";

        public int m_str; //strength
        public int m_dex; //dexterity
        public int m_wis; //wisdom
        public int m_int; //intelligence
        public int m_chr; //charasima
        public int m_con; //constitution

        public int m_money;

        public Enum m_class;
        public Enum m_aspect;
        public Enum m_strifeDeck;

    }
}
