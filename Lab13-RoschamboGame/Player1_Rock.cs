using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RoschamboGame
{
    class Player1_Rock 
    {
        //Player 1 will always select Rock
        public static string PlayerOneSelects()
        {
            string rock = Enum.GetName(typeof(Roshambo), 1); 
            return rock;
        }
    }
}
