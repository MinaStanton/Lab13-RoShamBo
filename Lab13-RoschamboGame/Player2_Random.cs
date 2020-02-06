using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RoschamboGame
{
    class Player2_Random
    {

        public static string PlayerTwoSelects()
        { 
            Random random = new Random();
            int pick = random.Next(1,4);
            string select = Enum.GetName(typeof(Roshambo), pick);
            return select; 
        }
    }
}
