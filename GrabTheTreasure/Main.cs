// See https://aka.ms/new-console-template for more information

// get player name
// hero moves with WASD or up down left right
// hero starts in doorway on map
// map is 7x7 
// random enemy + treasure spawn
// enemy must use randomness to move
// enemy kills hero if touched
// hero gets treasure if touched
// hero brings treasure to door to win

// at LEAST one switch statement

// generate map function is better as 
// new char[,] = [10][10];
// for loops interating through each one
// make some of them X while others are just ' '

// F I N I S H E D
    //player move check is finished



using GrabTheTreasure;

TreasureGame game = new TreasureGame();
TreasureUI treasureUI = new TreasureUI();

//treasureUI.displayMenu(); //menu works, gotta make the map now
//game.displayMap(game.getSchema(), game.getRowLength()); //displays properly, no player, treasure, or enemy
//game.movePlayer(); //movement works, gotta double check the isValidMove


treasureUI.displayMenu(); // I CAN WIN



//treasureUI.displayWin(game.startGame());