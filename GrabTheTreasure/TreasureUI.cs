using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GrabTheTreasure
{
    internal class TreasureUI
    {
        //all my UI needs
        private string playerName;
        private bool isPlaying = true;

        public string getPlayerName()
        {
            if (playerName == null) setPlayerName();
            
            return playerName;
        }

        public void setPlayerName()
        {
            playerName = Console.ReadLine();
        }

        public void displayMenu()
        {
            Console.WriteLine("What's your name, Adventurer?");
            getPlayerName();

            Console.WriteLine($"Welcome to Grab the Treasure, {playerName}! Please choose an option.");
            Console.WriteLine("1) Play game!\n2) Exit");

            string userChoice = "";

            do
            {
                userChoice = Console.ReadLine();
                switch (userChoice) 
                {
                    case "1": //starts the game
                        Console.WriteLine("Use WASD to move! Must Enter to input movement.");
                        TreasureGame game1 = new TreasureGame();
                        if (game1.startGame())
                        {
                            displayWin();
                        } else { displayLose(); }
                        isPlaying = false;
                        break;

                    case "2": //ends the program
                        Console.WriteLine("Goodbye");
                        isPlaying = false;
                        break;
                }
            } while (isPlaying);
        }

        public void displayWin()
        {
            Console.WriteLine($"{playerName}, you win! Congratz");
        }

        public void displayLose()
        {
            Console.WriteLine("You died! Wanna try again?");
        }
    }
}
