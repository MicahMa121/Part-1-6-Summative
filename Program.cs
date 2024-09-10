namespace Part_1_6_Summative
{
    internal class Program
    {
        static double balance;
        static void Main(string[] args)
        {
            balance = 100;
            UpdateBank();
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();

            dice1.DrawRoll(3, 2);
            dice2.DrawRoll(12, 2);
            Console.WriteLine("Do you think the sum of 2 dices will be higher than 7 or lower?(\'h\' or \'l\' or \'7\')");
            bool done = false;
            while (!done)
            {
                string input = Console.ReadLine();
                if (input == "h"||input == "higher")
                {
                    done = true;
                    Console.WriteLine("How much do you want to bet? (at least $1.00)");
                    double bet;
                    while (!double.TryParse(Console.ReadLine(),out bet)||bet <= 1|| bet > balance)
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    balance = balance-bet;  
                    UpdateBank();

                    dice1.RollDie();
                    dice1.DrawRoll(3, 2);
                    !
                    Console.WriteLine("Do you want to add on to your bet?(ENTER to skip)");
                    if (Console.ReadLine() != null)
                    {
                        double add;
                        while (!double.TryParse(Console.ReadLine(), out add) || bet <= 1 || bet > balance)
                        {
                            Console.WriteLine("Please enter a number");
                        }
                        balance = balance - add;
                        bet = bet + add;
                        UpdateBank();
                    }


                    dice2.RollDie();
                    dice2.DrawRoll(12, 2);
                    if (dice1.Roll+dice2.Roll > 7)
                    {

                    }
                    
                }
                else if (input == "l" || input == "lower")
                {
                    done = true;
                }
                else if (input == "7")
                {
                    done = true;
                }
            }
        }
        public static void UpdateBank()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Hello, You have " + balance.ToString("C")+" in your bank!");
        }
    }
}
