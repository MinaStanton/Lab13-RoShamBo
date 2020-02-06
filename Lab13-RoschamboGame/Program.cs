using System;

namespace Lab13_RoschamboGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            //input asking user to enter their name
            Player3_User userPlayer = new Player3_User();
            Console.WriteLine("What's your name?");
            userPlayer.Name = Console.ReadLine();

            int win = 0, loss = 0;
            bool userContinue = true;
            while (userContinue)
            {
                string selectedOpponent = RoschamboApp.UserChoiceOfOpponent();//selects which opponent they will play against
                string opponent = "";
                if (selectedOpponent == "Rocky")
                {
                    opponent = Player1_Rock.PlayerOneSelects();//sets opponent to Rocky
                }
                else
                {
                    opponent = Player2_Random.PlayerTwoSelects();//sets opponent to Rando
                }

                //calling on the method to get user selection
                string userSelect = userPlayer.generateRoshambo();

                //printing out both selections
                Console.WriteLine($"{userPlayer.Name}: {userSelect}");
                Console.WriteLine($"{selectedOpponent}: {opponent}");

                //calling on the method to find out the results 
                int result = Play(opponent, userSelect);
                // using result to get keep track of the wins and losses
                if (result == 1)
                {
                    win++;
                }
                else if (result == 0)
                {
                    loss++;
                }

                userContinue = UserContinue("Would like to go again? (y/n)", "y", "n");
            }
            Console.WriteLine($"{userPlayer.Name}, You won: {win} and lost: {loss}. Thanks for playing!");
        }

        //method to get user input
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        //method to ask if a user will continue
        public static bool UserContinue(string message, string option1_true, string option2_false)
        {
            string input = GetUserInput(message).ToLower();
            while (input != option1_true && input != option2_false)
            {
                return UserContinue(message, option1_true, option2_false);
            }

            if (input == option1_true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //method using switch statements based on selection to print out if they won or lost 
        public static int Play(string opponent, string userSelection)
        {
            int winOrLoss = -1;
            switch (userSelection)
            {

                case "rock":
                    if (opponent == "rock")
                    {
                        Console.WriteLine("You tied!");
                        winOrLoss = 2;
                    }
                    else if (opponent == "paper")
                    {
                        Console.WriteLine("You lost");
                        winOrLoss = 0;
                    }
                    else if (opponent == "scissors")
                    {
                        Console.WriteLine("You won!");
                        winOrLoss = 1;
                    }
                    break;

                case "paper":
                    if (opponent == "rock")
                    {
                        Console.WriteLine("You won!");
                        winOrLoss = 1;
                    }
                    else if (opponent == "paper")
                    {
                        Console.WriteLine("You tied");
                        winOrLoss = 2;
                    }
                    else if (opponent == "sicissors")
                    {
                        Console.WriteLine("You lost");
                        winOrLoss = 0;
                    }
                    break;

                case "scissors":
                    if (opponent == "rock")
                    {
                        Console.WriteLine("You lost");
                        winOrLoss = 0;
                    }
                    else if (opponent == "paper")
                    {
                        Console.WriteLine("You won!");
                        winOrLoss = 1;
                    }
                    else if (opponent == "scissors")
                    {
                        Console.WriteLine("You tied");
                        winOrLoss = 2;
                    }
                    break;
            }

            return winOrLoss;
        }

    }
}
