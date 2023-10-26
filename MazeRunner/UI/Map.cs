using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

// MAP
    
    // Diplay the map
        //Initial display (game start)
        //print/draw base map definition
        //display current map state when changed

namespace MazeRunner.UI
{
    internal class Map
    {
        public static void DrawMap(string mapState, int mapWidth)
        {
            Console.Clear();
            //display the current map
            string row = "";

            for (int i = 0; i < mapState.Length; i++)
            {   
                row = row + mapState[i];

                if (i > 0 && (i+ 1) % mapWidth == 0)
                {
                    Console.WriteLine(row);
                    row = "";
                }
            }
        }


    }
}
