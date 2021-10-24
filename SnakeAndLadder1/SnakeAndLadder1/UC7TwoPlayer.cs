﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder1
{
    public class UC7TwoPlayer
    {
        const int WIN_POSITION = 100;
        public  int currentPosition = 1;
        static Random random = new Random();
        public  int throwDice()
        {
            return random.Next(1, 7);
        }

        public  int checkForOption()
        {
            return random.Next(1, 4);
        }

        public void twoplayer()
        { 
            int playerOnePosition = 0;
            int playerTwoPosition = 0;
            int playerOneRollDiceCount = 0;
            int playerTwoRollDiceCount = 0;

            while (playerOnePosition < WIN_POSITION || playerTwoPosition < WIN_POSITION)
            {
                int playerOnethrowDices = throwDice();
                playerOneRollDiceCount++;
                int playerTwothrowDices = throwDice();
                playerTwoRollDiceCount++;
                int selectdOption = checkForOption();
                switch (selectdOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        playerOnePosition += playerOnethrowDices;
                        playerTwoPosition += playerTwothrowDices;
                        if (playerOnePosition > WIN_POSITION)
                        {
                            playerOnePosition -= playerOnethrowDices;
                        }
                        else if (playerTwoPosition > WIN_POSITION)
                        {
                            playerTwoPosition -= playerTwothrowDices;
                        }
                        Console.WriteLine("player one poistion is =" + playerOnePosition);
                        Console.WriteLine("player two poistion is =" + playerTwoPosition);

                        break;
                    case 2:
                        Console.WriteLine("Player got snake");
                        if ((playerOnePosition - playerOnethrowDices) < 0)
                        {
                            playerOnePosition = 0;
                        }
                        else
                        {
                            playerOnePosition -= playerOnethrowDices;
                        }
                        if ((playerTwoPosition - playerTwothrowDices) < 0)
                        {
                            playerTwoPosition = 0;
                        }
                        else
                        {
                            playerTwoPosition -= playerTwothrowDices;
                        }
                        Console.WriteLine("player one poistion is =" + playerOnePosition);
                        Console.WriteLine("player two poistion is =" + playerTwoPosition);
                        break;
                    case 3:
                        Console.WriteLine("player not play");
                        break;
                    default:
                        break;
                }
                if (playerOnePosition == WIN_POSITION)
                {
                    Console.WriteLine("Player one is won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + playerOneRollDiceCount);
                    break;
                }
                else if ((playerTwoPosition == WIN_POSITION) && (playerOnePosition != WIN_POSITION))
                {
                    Console.WriteLine("Player two is won!");
                    Console.WriteLine("number of dice was played by player for win the game is =" + playerTwoRollDiceCount);
                    break;
                }
            }
        }
    }
}
