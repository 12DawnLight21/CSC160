using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GrabTheTreasure
{
    internal class TreasureGame
    {
        //gonna hold my game logic

        //this isnt the best way but it works
        private static char[] mazeSchema = "XXXXXXXXXXXX      X  XX      X  XX X       XX XXXXXX XXX         XXXXX  XXXXXX X       XX XXXXX  XXX     X   XXXXXXXXEXXX".ToCharArray();
        private int rowLength = 11; //must be 11 or change the schema and the length

        private int playerPosition;
        private int prevPosition;

        private int enemyPosition;
        private int enemyPrevPosition;

        private int treasurePosition;
        private int exitPosition;
        private bool gotTreasure = false;

        private bool didWin;
        private bool didLose;

        public int getRowLength() { return rowLength; }
        public void setRowLength(int length) { rowLength = length; }
        public char[] getSchema() { return mazeSchema; }
        public void setSchema(char[] schema) {  mazeSchema = schema; }

        public bool startGame()
        {
            initializeGame(25, 64, 20, 117);
            mazeSchema[playerPosition] = 'P';
            mazeSchema[enemyPosition] = 'H';
            mazeSchema[treasurePosition] = 'T';
            displayMap(getSchema(), getRowLength());

            bool win = false;
            do
            {
                movePlayer();
                moveEnemy();
                displayMap(getSchema(), getRowLength());

                if (didWin)
                {
                    win = true;
                }

                if (didLose) break;

            } while (!win);

            if (didLose) return false;

            return true;
        }

        //from our in-class MazeRunner project
        public void displayMap(char[] schema, int rowLength)
        {
            string row = "";

            for (int i = 0; i < schema.Length; i++)
            {
                row = row + schema[i];

                if (i > 0 && (i + 1) % rowLength == 0)
                {
                    Console.WriteLine(row);
                    row = "";
                }
            }

            if (mazeSchema[exitPosition] != 'E') mazeSchema[exitPosition] = 'E';
        }

        public void initializeGame(int playerInitialPosition, int enemyInitial, int treasureInitial, int exit)
        {
            playerPosition = playerInitialPosition;
            prevPosition = playerPosition;

            enemyPosition = enemyInitial;
            enemyPrevPosition = enemyPosition;

            treasurePosition = treasureInitial;

            exitPosition = exit;
        }

        public void movePlayer()
        {
            bool didMove = true;
            string playerInput = Console.ReadLine();
            int newPos;
            do
            {
                if (isValidChar(playerInput.ToCharArray()[0]))
                {
                    if (playerInput.ToCharArray()[0] == 'w' || playerInput.ToCharArray()[0] == 'W')
                    {
                        newPos = playerPosition -= rowLength; //up
                        if (isValidMove(newPos))
                        {
                            if (isValidMove(newPos))
                            {
                                if (checkWin(newPos)) didWin = true;
                                mazeSchema[playerPosition] = 'P';
                                mazeSchema[prevPosition] = ' ';

                                prevPosition = playerPosition;
                            }
                            else
                            { 
                                playerPosition = prevPosition;
                                Console.WriteLine("Please try a different move.");
                            }
                            //Console.WriteLine("Up");
                        }
                        break;
                    }

                    if (playerInput.ToCharArray()[0] == 'a' || playerInput.ToCharArray()[0] == 'A')
                    {
                        newPos = playerPosition -= 1; //left
                        if (isValidMove(newPos))
                        {
                            if (isValidMove(newPos))
                            {
                                if (checkWin(newPos)) didWin = true;
                                mazeSchema[playerPosition] = 'P';
                                mazeSchema[prevPosition] = ' ';

                                prevPosition = playerPosition;
                            }
                            else
                            {
                                playerPosition = prevPosition;
                                Console.WriteLine("Please try a different move.");
                            }
                            //Console.WriteLine("Left");

                        }
                        break;
                    }

                    if (playerInput.ToCharArray()[0] == 's' || playerInput.ToCharArray()[0] == 'S')
                    {
                        newPos = playerPosition += rowLength; //down
                        if (isValidMove(newPos))
                        {
                            if (isValidMove(newPos))
                            {
                                if (checkWin(newPos)) didWin = true;
                                mazeSchema[playerPosition] = 'P';
                                mazeSchema[prevPosition] = ' ';

                                prevPosition = playerPosition;
                            }
                            else
                            {
                                playerPosition = prevPosition;
                                Console.WriteLine("Please try a different move.");
                            }                           
                            //Console.WriteLine("Down");

                        }
                        break;
                    }

                    if (playerInput.ToCharArray()[0] == 'd' || playerInput.ToCharArray()[0] == 'D')
                    {
                        newPos = playerPosition += 1; //right
                        if (isValidMove(newPos))
                        {
                            if (isValidMove(newPos))
                            {
                                if (checkWin(newPos)) didWin = true;
                                mazeSchema[playerPosition] = 'P';
                                mazeSchema[prevPosition] = ' ';

                                prevPosition = playerPosition;
                                
                            }
                            else
                            {
                                playerPosition = prevPosition;
                                Console.WriteLine("Please try a different move.");
                            }                            
                            //Console.WriteLine("Right");

                        }
                        break;

                    }

                    didMove = false;
                }


                else
                {
                    Console.WriteLine("Try again");
                    playerInput = Console.ReadLine();
                }

                if (mazeSchema[prevPosition] == 'P') mazeSchema[prevPosition] = ' ';
                prevPosition = playerPosition;

            } while (didMove);
        }

        public bool checkWin(int position)
        {
            if (mazeSchema[position] == 'E' && gotTreasure)
            {
                return true;
                //Console.WriteLine("wow");
            }
            if (mazeSchema[position] == 'E' && !gotTreasure)
            {
                Console.WriteLine("Get the treasure ya goof!");
                mazeSchema[position] = 'E';
                return false;
                //Console.WriteLine("wow");
            }

            return false;
        }

        public void moveEnemy()
        {
            bool didMove = true;
            int newPos;
            Random r = new Random();
            newPos = r.Next(0, 3);

            do
            {
                switch (newPos)
                {
                    case 0: // up
                        newPos = enemyPosition -= rowLength; //up

                        if (enemyTriesToLeaveTheArray(newPos))
                        {
                            if (enemyMoveCheck(newPos))
                            {
                                mazeSchema[enemyPosition] = 'H';
                                mazeSchema[enemyPrevPosition] = ' ';

                                enemyPrevPosition = enemyPosition;
                            }
                        } else enemyPosition = enemyPrevPosition;

                        break;
                    case 1: //left
                        newPos = enemyPosition -= 1; //left

                        if (enemyTriesToLeaveTheArray(newPos))
                        {
                            if (enemyMoveCheck(newPos))
                            {
                                mazeSchema[enemyPosition] = 'H';
                                mazeSchema[enemyPrevPosition] = ' ';

                                enemyPrevPosition = enemyPosition;
                            }
                        }
                        else enemyPosition = enemyPrevPosition;

                        break;
                    case 2: //down
                        newPos = enemyPosition += rowLength; //down

                        if (enemyTriesToLeaveTheArray(newPos))
                        {
                            if (enemyMoveCheck(newPos))
                            {
                                mazeSchema[enemyPosition] = 'H';
                                mazeSchema[enemyPrevPosition] = ' ';

                                enemyPrevPosition = enemyPosition;
                            }
                        }
                        else enemyPosition = enemyPrevPosition;

                        break;
                    case 3: //right
                        newPos = enemyPosition += 1; //right

                        if (enemyTriesToLeaveTheArray(newPos))
                        {
                            if (enemyMoveCheck(newPos))
                            {
                                mazeSchema[enemyPosition] = 'H';
                                mazeSchema[enemyPrevPosition] = ' ';

                                enemyPrevPosition = enemyPosition;
                            }
                        }
                        else enemyPosition = enemyPrevPosition;

                        break;
                }

                enemyPrevPosition = enemyPosition;

            } while (!didMove);
        }

        public bool isValidChar(char input)
        {
            char[] validPlayerInputs = { 'w', 'a', 's', 'd' };

            return validPlayerInputs.Contains(input);
        }

        public bool enemyTriesToLeaveTheArray(int position)
        {
            if (position <= 0) return false;
            if (position < mazeSchema.Length)
            {
                return true;
            }
            enemyPosition = enemyPrevPosition;
            return false;
        }

        public bool enemyMoveCheck(int position)
        {
            if (mazeSchema[position] == 'X' || mazeSchema[position] == 88)
            {
                mazeSchema[position] = 'X';
                return false;
            } 
            if (mazeSchema[position] == 'P')
            {
                didLose = true;
                mazeSchema[position] = ' ';
                mazeSchema[playerPosition] = ' ';
            }
            if (mazeSchema[position] == ' ') return true;


            if (mazeSchema[position] == 'T') return false;
            if (mazeSchema[position] == 'E') return false;

            return false;
        }

        public bool isValidMove(int newPosition)
        {
            if (mazeSchema[newPosition] == 'X') return false;
            if (mazeSchema[newPosition] == ' ') return true;
            if (mazeSchema[newPosition] == 'T')
            {
                Console.WriteLine("Got the Treasure!");
                gotTreasure = true;
                return true;
            }

            if (mazeSchema[newPosition] == 'H')
            {
                didLose = true;
                mazeSchema[newPosition] = ' ';
                mazeSchema[playerPosition] = ' ';
            }

            if (mazeSchema[newPosition] == 'E') return true;

            return false;
        }
    }
}