using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeRunner.Game
{
    internal class Player
    {
        public string name { get; set; }
        public string color { get; set; }

        private int playerPosition;

        public Player(int initialPosition, string playerName, string playerColor)
        {
            name = playerName;
            color = playerColor;

            playerPosition = initialPosition;
        }

        public void MovePlayer()
        {            
            //+11 for down
            //-11 for up
            //+1 right
            //-1 left

            //validate new position
        }

        public char getPlayerMove()
        {
            return 'w';
        }

        public bool isValidInput(char input)
        {
            char[] validPlayerInputs = { 'w', 'a', 's', 'd' };

            return validPlayerInputs.Contains(input);
        }
    }
}
