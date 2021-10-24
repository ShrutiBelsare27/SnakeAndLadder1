﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder1
{
    public class UC5EnsureWinningPosition
    {
        const int START_POSITION = 0;
        const int END_POSITION = 100;
        public static int currentPosition = 1;
        public static int selectedOption = 0;
        static Random random = new Random();
        public  int throwDice()
        {
            return random.Next(1, 7);
        }

        public int checkForOption()
        {
            return random.Next(1, 4);
        }

        public void Check()
        {

            while (currentPosition < END_POSITION)
            {
                int throwDices = throwDice();
                int selectedOption = checkForOption();
                switch (selectedOption)
                {
                    case 1:
                        Console.WriteLine("Player got ladder");
                        currentPosition += throwDices;
                        if (currentPosition > END_POSITION)
                        {
                            currentPosition -= throwDices;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got snake");
                        if ((currentPosition - throwDices) < 0)
                        {
                            currentPosition = 0;
                        }
                        else
                        {
                            currentPosition -= throwDices;
                        }
                        break;
                    case 3:
                        Console.WriteLine("player not play");
                        break;
                    default:
                        break;
                }

            }
            }
        }
}
