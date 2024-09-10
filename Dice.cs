using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_6_Summative
{
    public class Dice
    {
        private int _roll;
        private Random _generator;

        public Dice()
        {
            _generator = new Random();
            _roll = 0;
        }


        public int Roll {  get { return _roll; } set { _roll = value; } }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;
        }

        public void DrawRoll(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            if (_roll == 1)
            {
                Console.WriteLine("-----");
                Console.SetCursorPosition(x, y+1);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("| o |");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|o  |");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|  o|");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("-----");
            }

            else if (_roll == 3)
            {
                Console.WriteLine("-----");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|o  |");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("| o |");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|  o|");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("-----");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-----");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|o o|");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|o o|");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("-----");
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|o o|");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("| o |");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|o o|");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|o o|");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("|o o|");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|o o|");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine("-----");
                Console.SetCursorPosition(x, y + 1);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x, y + 2);
                Console.WriteLine("| ? |");
                Console.SetCursorPosition(x, y + 3);
                Console.WriteLine("|   |");
                Console.SetCursorPosition(x, y + 4);
                Console.WriteLine("-----");
            }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

    }
}