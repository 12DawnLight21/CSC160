// See https://aka.ms/new-console-template for more information

// MAZE RUNNER

// ENHANCEMENTS
//Changing walls during game
//procedural generation of initial maze state
//treasure
//enemy


//class GFG
//{

//    // Main Method 
//    public static void Main()
//    {
//        int c = 0;
//        Console.WriteLine("The series is-");
//        for (int i = 1; i < 10; i++)
//        {
//            c = c + i;
//            Console.Write(c + " ");
//        }
//        Console.Write("\nPress 'E' to exit the process...");

//        // here it asks to press "E" to exit 
//        // and the key "E" is not shown in 
//        // the console output window 
//        while (Console.ReadKey(true).Key != ConsoleKey.E) << THIS FOR PLAYER 'E' INPUT!!
//        {
//        }

//    }
//}
using MazeRunner.Game;
using MazeRunner.UI;

Maze gameMaze = new Maze();
Player ourPlayer = new Player(5, "Prince", "Green");
updateUI();
gameMaze.UpdateUserPosition(65, 53);
updateUI();


void updateUI()
{
    string mapString = new string(gameMaze.mazeState);
    Map.DrawMap(mapString, gameMaze.rowLength);

}