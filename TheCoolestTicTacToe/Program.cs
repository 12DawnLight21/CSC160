// 2 players, turn based

// prompt-based inputs from each player
// display board
// update board per turn

// check for win
// check for draw
// is move valid?
// win, lose and draw states

// start game
// reset game
// give up.

// board class -> displayBoard(), placeMark(Player player), clearBoard(), validateSpace()
// player class -> endTurn(), checkForWin(), checkForDraw()
//this doesnt seem right cause the player cant check the board aspects
// hmmmmmmmmmm

/*
public class Game
{
    private int[] board = {0, 1, 2, 3, 4, 5, 6, 7, 8};
    private int totalTurns = 0; //++ every round, if == 9 game over // dont check until turn 5
    private int player = 1; //player numbers self explanitory, make 1 = x and 2 = o
    
    //kenneth, we need to keep track of spots on a 3x3 grid, could use a multidimensional array but it sucks ass
    //we also need to differenciate players
    //calling this game seems better to me fr fr

    //{" | | |", " | | | ", " | | | "}; //board display


    public void Display()
    {
        //show the board loser
        //literally the easiest part but NOOOO 

        // provide options 1-9
        // loop over until given valid answer
        // whatever the player chooses, it puts their mark on that spot
        // repeat while removing taken spaces
    }

    public void Clear()
    {
        //set all symbols to spaces
    }

    public bool IsValidPlacement()
    {
        //if space != 1 or 2, valid

        return true;
    }

    public void PlaceMark() //parameters including mark n player
    {
        //validate legal placement of mark
        //player 1 = x, player 2 = o, replace the numbers with characters

        //update board space to show mark
    }

    public int CheckForWin()
    {
        //nested for loops perhaps?
        //if space 1 = x and space 2 = x and space 3 = x, player 1 wins
        //repeat until you die

        return 0;
    }

}
*/