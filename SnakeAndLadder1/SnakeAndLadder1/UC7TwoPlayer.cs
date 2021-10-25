using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder1
{
    public class UC7TwoPlayer
    {
        const int WIN_POSITION = 100;
        public int currentPosition = 1;
        static Random random = new Random();
        public int throwDice()
        {
            return random.Next(1, 7);
        }

        public int checkForOption()
        {
            return random.Next(1, 4);
        }
        public void oneplayer()
        {

            int playerOnePosition = 0;
            int playerOneRollDiceCount = 0;
            while (playerOnePosition < WIN_POSITION)
            {

                int playerOnethrowDices = throwDice();
                playerOneRollDiceCount++;
                int selectedOption = checkForOption();

                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        playerOnePosition += playerOnethrowDices;
                        if (playerOnePosition > WIN_POSITION)
                        {
                            playerOnePosition -= playerOnethrowDices;
                        }
                        Console.WriteLine("player one position is =" + playerOnePosition);
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
                        Console.WriteLine("player one position is =" + playerOnePosition);
                        break;
                    case 3:
                        Console.WriteLine("player not play");
                        break;
                    default:
                        break;
                }

                if (currentPosition == WIN_POSITION)
                {
                    Console.WriteLine("Player 1 won!");
                    Console.WriteLine("number of dice was played by player for win the game is" + playerOneRollDiceCount);
                    break;
                }
            }



        }
            public void twoplayer()
            {

                int playerTwoPosition = 0;
                int playerOnePosition = 0;
                int playerTwoRollDiceCount = 0;
                while (playerTwoPosition < WIN_POSITION)
                {

                    int playerTwothrowDices = throwDice();
                    playerTwoRollDiceCount++;
                    int selectedOption = checkForOption();

                    switch (selectedOption)
                    {
                        case 1:
                            Console.WriteLine("Player got ladder");
                            playerTwoPosition += playerTwothrowDices;
                            if (playerTwoPosition > WIN_POSITION)
                            {
                                playerTwoPosition -= playerTwothrowDices;
                            }
                            Console.WriteLine("player one position is =" + playerTwoPosition);
                            break;
                        case 2:
                            Console.WriteLine("Player got snake");
                            if ((playerTwoPosition - playerTwothrowDices) < 0)
                            {
                                playerTwoPosition = 0;
                            }
                            else
                            {
                                playerTwoPosition -= playerTwothrowDices;
                            }
                            Console.WriteLine("player one position is =" + playerTwoPosition);
                            break;
                        case 3:
                            Console.WriteLine("player not play");
                            break;
                        default:
                            break;
                    }

                    if ((playerTwoPosition == WIN_POSITION) && (playerOnePosition != WIN_POSITION))
                    {
                        Console.WriteLine("Player 2 won!");
                        Console.WriteLine("number of dice was played by player for win the game is" + playerTwoRollDiceCount);
                        break;
                    }
                }


            }

        }
    }
