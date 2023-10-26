using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//XXXXXXXXXXX
//X      X  X
//X      X  X
//X X  P    X
//X XXXXXX XX
//X         X
//XXXX  XXXXX
//X X       X
//X XXXXX  XX
//X     X   X
//XXXXXXXEXXX


// Definition/Schema (storage of info making up map)
//Array of characters (for the example demo only)


//Tiles:
//Empty Space
//Walls
//1 Player, exit
// Determine/check win condition
//if player is on the exit, player wins
// Update map state based on user input
//map state implementations
//1)array of characters (schema updated with player)
//2)store player position
//validate player movement/position changes
//player cant go through walls (or share spare with walls)
//collision/prioritization
//win condition (share space with exit)

namespace MazeRunner.Game
{
    internal class Maze
    {
        public char[] mazeState;
        private static char[] mazeSchema = "XXXXXXXXXXXX      X  XX      X  XX X  P    XX XXXXXX XXX         XXXXX  XXXXXX X       XX XXXXX  XXX     X   XXXXXXXXEXXX".ToCharArray();
        public int rowLength = 11;

        public static int PlayerStartPosition;

        public Maze()
        {
            mazeState = mazeSchema;
            mazeState[PlayerStartPosition] = 'P';
        }

        public void UpdateUserPosition(int currentPosition, int newPosition)
        {
            if (newPosition < 0 || newPosition > mazeSchema.Length)
            { 
            
            }

            if (isValidSpace(newPosition))
            {
                mazeState[currentPosition] = ' ';
                mazeState[newPosition] = 'P';

                //change position

            } else
            {
                //throw error
                //return message
                //nofity user move is invalid
            }
        }
        private bool isValidSpace(int position)
        {
            return true;
            //return mazeSchema[position] == ' ';
        }
    }
}
