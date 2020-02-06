using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RoschamboGame
{
    class RoschamboApp
    {

        public static string UserChoiceOfOpponent()
        {
            Console.WriteLine("Would you like to play against 1. Rocky or 2. Rando?");
            int userPick = int.Parse(Console.ReadLine()); 

            if(userPick == 1)
            {
                return "Rocky";
            }
            else if(userPick == 2)
            {
                return "Rando";
            }
            else
            {
                return UserChoiceOfOpponent();
            }
        }
    }
}
