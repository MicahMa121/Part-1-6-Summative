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
            Console.WriteLine("Do you think the sum of 2 dices will be higher than 7 or lower?(\'h\' or \'l\')");
            bool done = false;
            while (!done)
            {
                string input = Console.ReadLine();
                if (input == "h"||input == "higher")
                {
                    done = true;
                }
                else if (input == "l" || input == "lower")
                {
                    done = true;
                }
                else if (input == "q" || input == "quit")
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
