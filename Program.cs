namespace _12_T1_6_Summative
{
    using _12_T5._5_Classes;
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1, die2;
            bool done = false;
            double balance = 100, bet;
            string outcomeGuess;

            die1 = new Die();
            die2 = new Die();

            Console.WriteLine("Welcome to the casino!");
            Console.WriteLine("You have 100$ in your account to start.");
            Console.WriteLine("You can use that money to bet on the outcome of a dice roll.");
            Console.WriteLine("If you bet more than your balance, it will be assumed that you are all in");
            Console.WriteLine("The house will roll two dice, and you will bet on whether you think");
            Console.WriteLine("it will be doubles, not doubles, an odd sum, or an even sum.");
            Console.WriteLine("Each option will win you different amounts of money.");
            Console.WriteLine();
            Console.WriteLine("Betting on doubles will win you twice your bet");
            Console.WriteLine("Betting on not doubles will win you half your bet");
            Console.WriteLine("Betting on an odd sum or an even sum will win you exactly your bet");
            Console.WriteLine("You can also choose to quit when prompted for which outcome you would like to bet on");

            while (!done)
            {
                if (balance <= 0)
                {
                    Console.WriteLine("You have run out of funds");
                    Console.WriteLine("Game Over");
                    done = true;
                }

                else
                {
                    die1.RollDie();
                    die2.RollDie();
                    Console.WriteLine("What do you think the outcome will be? (please enter the name, not the number)");
                    Console.WriteLine();
                    Console.WriteLine("1. Doubles");
                    Console.WriteLine("2. Not Doubles");
                    Console.WriteLine("3. Odd Sum");
                    Console.WriteLine("4. Even Sum");
                    Console.WriteLine("5. Quit");

                    outcomeGuess = Console.ReadLine().ToLower();

                    switch (outcomeGuess)
                    {
                        case "doubles":
                            Console.Clear();
                            Console.WriteLine("You bet on doubles");
                            Console.WriteLine("How much would you like to bet?");

                            while (!double.TryParse(Console.ReadLine(), out bet))
                            {
                                Console.WriteLine("That is not a valid number");
                                Console.WriteLine("Please try again");
                            }

                            if (bet > balance)
                            {
                                Console.WriteLine("You bet more than your balance");
                                Console.WriteLine("You are all in");
                                bet = balance;
                            }

                            Console.WriteLine();
                            Console.WriteLine($"You bet {bet} dollars");
                            die1.DrawRoll();
                            die2.DrawRoll();

                            if (die1.Roll == die2.Roll)
                            {
                                Console.WriteLine("Congratulations! You win");
                                balance += (bet * 2);
                                Console.WriteLine($"You have {balance} dollars in your account");
                            }

                            else
                            {
                                Console.WriteLine("You lost");
                                balance -= (bet * 2);
                                Console.WriteLine($"You have {balance} dollars in your account");
                            }

                                break;

                        case "not doubles":
                            Console.Clear();
                            Console.WriteLine("You bet on not doubles");
                            Console.WriteLine("How much would you like to bet?");

                            while (!double.TryParse(Console.ReadLine(), out bet))
                            {
                                Console.WriteLine("That is not a valid number");
                                Console.WriteLine("Please try again");
                            }

                            if (bet > balance)
                            {
                                Console.WriteLine("You bet more than your balance");
                                Console.WriteLine("You are all in");
                                bet = balance;
                            }

                            Console.WriteLine();
                            Console.WriteLine($"You bet {bet} dollars");
                            die1.DrawRoll();
                            die2.DrawRoll();

                            if (die1.Roll != die2.Roll)
                            {
                                Console.WriteLine("Congratulations! You win");
                                balance += (bet / 2);
                                Console.WriteLine($"You have {balance} dollars in your account");
                            }

                            else
                            {
                                Console.WriteLine("You lost");
                                balance -= (bet / 2);
                                Console.WriteLine($"You have {balance} dollars in your account");
                            }

                            break;

                        case "quit":
                            Console.Clear();
                            Console.WriteLine("Thank you for playing");
                            Console.WriteLine($"You ended with {balance} dollars in your account");
                            done = true;
                            break;
                    }
                }
            }
        }
    }
}
