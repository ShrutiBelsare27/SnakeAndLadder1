using System;

namespace SnakeAndLadder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome message");
            /*Console.WriteLine("Use case1: ");
            UC1InitializePositionOfPlayer obj1 = new UC1InitializePositionOfPlayer();
            obj1.initalizeplayer();*/

            /*Console.WriteLine("Use case2: ");
            UC2RollDie obj2 = new UC2RollDie();
            obj2.throwDice();*/

           /* Console.WriteLine("Use case3: ");
            UC3CheckOption obj3 = new UC3CheckOption();
            obj3.throwDice();
            obj3.checkForOption();
            obj3.playerOption();*/

            /*Console.WriteLine("Use case4: ");
            UC4TillWinningPosition obj4 = new UC4TillWinningPosition();
            obj4.throwDice();
            obj4.checkForOption();
            obj4.playerOption();*/

            /*Console.WriteLine("Use case5: ");
            UC5EnsureWinningPosition obj5 = new UC5EnsureWinningPosition();
            obj5.throwDice();
            obj5.checkForOption();
            obj5.Check();
*/
           /* Console.WriteLine("Use case6: ");
            UC6PositionAfterEveryDiceRoll obj6 = new UC6PositionAfterEveryDiceRoll();
            obj6.throwDice();
            obj6.checkForOption();
            obj6.exactwinning();
*/
            Console.WriteLine("Use case7: ");
            UC7TwoPlayer obj7 = new UC7TwoPlayer();
            obj7.throwDice();
            obj7.checkForOption();
            obj7.twoplayer();
        }
    }
}
