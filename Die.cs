using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_T5._5_Classes
{
    public class Die
    {
        //fields (variables in a class)
        private Random _generator;
        private int _roll;
        private ConsoleColor _colour;

        //constructor
        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _colour = ConsoleColor.Green;
        }

        public Die(ConsoleColor colour)
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
            _colour = colour;
        }

        public Die (int roll)
        {
            _colour = ConsoleColor.Green;
            _generator = new Random();
            if (roll < 1)
                _roll = 1;

            else if (roll > 6)
                _roll = 6;
            else
                _roll = roll;
        }

        //accessor
        public int Roll
        {
            get { return _roll; }
            //set { _roll = value; } <-- allows user to change Roll
        }

        public void RollDie()
        {
            _roll  = _generator.Next(1, 7);
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void DrawRoll()
        {
            ConsoleColor temp = Console.ForegroundColor;
            Console.ForegroundColor = _colour;
            if (_roll == 1)
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|       |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("|       |");
                Console.WriteLine(" ------- ");
            }
            else if (_roll == 2)
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("| *     |");
                Console.WriteLine("|       |");
                Console.WriteLine("|     * |");
                Console.WriteLine(" ------- ");
            }
            else if (_roll == 3)
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("| *     |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("|     * |");
                Console.WriteLine(" ------- ");
            }
            else if (_roll == 4)
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|       |");
                Console.WriteLine("| *   * |");
                Console.WriteLine(" ------- ");
            }
            else if (_roll == 5)
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("| *   * |");
                Console.WriteLine(" ------- ");
            }
            else if (_roll ==6)
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("| *   * |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("| *   * |");
                Console.WriteLine(" ------- ");
            }
            else
            {
                Console.WriteLine(" ------- ");
                Console.WriteLine("|       |");
                Console.WriteLine("|   ?   |");
                Console.WriteLine("|       |");
                Console.WriteLine(" ------- ");
            }
            Console.ForegroundColor = temp;
        }
    }
    
}
