using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// UI
    // Initialization
        //Game menu?
        //game start input (player name? start game options?)
        //LOOORRREEE
        //Tutorial information (movement instructions)
    // Player Controls
        //WASD/arrows for movement
        //send changes to map based on input
        //give up option (press escape)
    // Display win screen


namespace MazeRunner.UI
{
    internal class Menu
    {
        //maintain game state?
        // is menu responsible for game flow?
        public void DisplayMenu()
        {
            //displays menu based on game state?
            //display instructions
            //display options
            getUserSelection();

            //handle selection (start game, exit, etc)
        }

        private void getUserSelection()
        {
            //"Would you like to play again?"

            //parse userselection


            handleUserSelection();
        }

        private void handleUserSelection()
        {
            
        }
    }
}
