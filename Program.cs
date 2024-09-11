using System.Runtime.CompilerServices;

namespace Part_1_6_Summative
{
    internal class Program
    {
        static double balance;
        static int x, y;
        static void Main(string[] args)
        {
            balance = 100;

            bool quit = false;
            do
            {
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
                    if (input == "h" || input == "higher")
                    {
                        done = true;
                        Console.WriteLine("How much do you want to bet? (at least $1.00)");
                        double bet;
                        while (!double.TryParse(Console.ReadLine(), out bet) || bet < 1 || bet > balance)
                        {
                            Console.WriteLine("Please enter a valid number!");
                        }
                        balance = balance - bet;

                        UpdateBank();

                        dice1.RollDie();
                        dice1.DrawRoll(3, 2);

                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("Do you want to add on to your bet?(Cannot be higher than your original bet)");
                        string second_bet = Console.ReadLine();
                        if (second_bet != "")
                        {
                            double add;
                            while (!double.TryParse(second_bet, out add) || add < 0 || add > balance|| add > bet)
                            {
                                Console.WriteLine("Please enter a valid number");
                                second_bet = Console.ReadLine();
                            }
                            balance = balance - add;
                            bet = bet + add;
                            UpdateBank();
                        }

                        dice2.RollDie();
                        dice2.DrawRoll(12, 2);
                        Console.SetCursorPosition(x, y);
                        if (dice1.Roll + dice2.Roll > 7)
                        {
                            if (dice1.Roll == dice2.Roll)
                            {
                                balance = balance + bet * 4;
                                Console.WriteLine("You won!");
                                Console.WriteLine("It's also a double, your earned " + (bet * 4).ToString("C") + "!");
                                UpdateBank();
                            }
                            else
                            {
                                balance += bet * 2;
                                Console.WriteLine("You won!");
                                Console.WriteLine("Your earned " + (bet * 2).ToString("C") + "!");
                                UpdateBank();
                            }
                            Console.SetCursorPosition(x, y);
                        }
                        else if (dice1.Roll + dice2.Roll == 7)
                        {
                            Console.WriteLine("That's close!");
                        }
                        else if (dice1.Roll + dice2.Roll < 7)
                        {
                            Console.WriteLine("Try again next time!");
                        }
                        Console.WriteLine("Play Again?(Press enter)");
                        Console.WriteLine("or enter \"quit\" to exit");
                        if (Console.ReadLine() == "quit")
                        {
                            quit = true;
                        }
                        Console.Clear();
                    }
                    else if (input == "l" || input == "lower")
                    {
                        done = true;
                        Console.WriteLine("How much do you want to bet? (at least $1.00)");
                        double bet;
                        while (!double.TryParse(Console.ReadLine(), out bet) || bet < 1 || bet > balance)
                        {
                            Console.WriteLine("Please enter a valid number!");
                        }
                        balance = balance - bet;

                        UpdateBank();

                        dice1.RollDie();
                        dice1.DrawRoll(3, 2);

                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("Do you want to add on to your bet?(Cannot be higher than your original bet)");
                        string second_bet = Console.ReadLine();
                        if (second_bet != "")
                        {
                            double add;
                            while (!double.TryParse(second_bet, out add) || add < 0 || add > balance || add > bet)
                            {
                                Console.WriteLine("Please enter a valid number");
                                second_bet = Console.ReadLine();
                            }
                            balance = balance - add;
                            bet = bet + add;
                            UpdateBank();
                        }

                        dice2.RollDie();
                        dice2.DrawRoll(12, 2);
                        Console.SetCursorPosition(x, y);
                        if (dice1.Roll + dice2.Roll > 7)
                        {
                            Console.WriteLine("Try again next time!");
                        }
                        else if (dice1.Roll + dice2.Roll == 7)
                        {
                            Console.WriteLine("That's close!");
                        }
                        else if (dice1.Roll + dice2.Roll < 7)
                        {
                            if (dice1.Roll == dice2.Roll)
                            {
                                balance = balance + bet * 4;
                                Console.WriteLine("You won!");
                                Console.WriteLine("It's also a double, your earned " + (bet * 4).ToString("C") + "!");
                                UpdateBank();
                            }
                            else
                            {
                                balance += bet * 2;
                                Console.WriteLine("You won!");
                                Console.WriteLine("Your earned " + (bet * 2).ToString("C") + "!");
                                UpdateBank();
                            }
                            Console.SetCursorPosition(x, y);
                        }
                        Console.WriteLine("Play Again?(Press enter)");
                        Console.WriteLine("or enter \"quit\" to exit");
                        if (Console.ReadLine() == "quit")
                        {
                            quit = true;
                        }
                        Console.Clear();
                    }
                    else if (input == "7")
                    {
                        done = true;
                        Console.WriteLine("How much do you want to bet? (at least $1.00)");
                        double bet;
                        while (!double.TryParse(Console.ReadLine(), out bet) || bet < 1 || bet > balance)
                        {
                            Console.WriteLine("Please enter a valid number!");
                        }
                        balance = balance - bet;

                        UpdateBank();

                        dice1.RollDie();
                        dice1.DrawRoll(3, 2);

                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("Do you want to add on to your bet?(Cannot be higher than your original bet)");
                        string second_bet = Console.ReadLine();
                        if (second_bet != "")
                        {
                            double add;
                            while (!double.TryParse(second_bet, out add) || add < 0 || add > balance || add > bet)
                            {
                                Console.WriteLine("Please enter a valid number");
                                second_bet = Console.ReadLine();
                            }
                            balance = balance - add;
                            bet = bet + add;
                            UpdateBank();
                        }

                        dice2.RollDie();
                        dice2.DrawRoll(12, 2);
                        Console.SetCursorPosition(x, y);
                        if (dice1.Roll + dice2.Roll > 7)
                        {
                            Console.WriteLine("Try again next time!");
                        }
                        else if (dice1.Roll + dice2.Roll == 7)
                        {
                            balance += bet * 5;
                            Console.WriteLine("You won! High risk high reward!");
                            Console.WriteLine("Your earned " + (bet * 5).ToString("C") + "!");
                            UpdateBank();
                            Console.SetCursorPosition(x, y);
                        }
                        else if (dice1.Roll + dice2.Roll < 7)
                        {
                            Console.WriteLine("Try again next time!");
                        }
                        Console.WriteLine("Play Again?(Press enter)");
                        Console.WriteLine("or enter \"quit\" to exit");
                        if (Console.ReadLine() == "quit")
                        {
                            quit = true;
                        }
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input!(\"higher\" or \"lower\" or \"7\")");
                    }
                }
                if (balance <= 0)
                {
                    quit = true;
                }
            }
            while (!quit);
            Console.WriteLine("Thank you for playing the dice casino game!");
            Console.WriteLine("You have " + balance.ToString("C") + " in your bank at the end of the day!");
        }
        public static void UpdateBank()
        {
            x = Console.GetCursorPosition().Left;
            y = Console.GetCursorPosition().Top;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Hello, You have " + balance.ToString("C")+" in your bank!");
        }
    }
}
